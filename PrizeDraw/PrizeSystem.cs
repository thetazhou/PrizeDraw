using System;
using System.Collections.Generic;
using System.Text;
using PrizeDraw.Entity;

namespace PrizeDraw
{
    public class PrizeSystem
    {
        #region 变量区域

        protected readonly static object lockPrizeObject = new object();

        protected Dictionary<int, Rank> mapRank = null;

        public Dictionary<int, Person> mapPerson = null;

        protected Dictionary<int, List<int>> mapPrize = null;

        protected SystemSet sysSet = null;

        protected ImgPositionSet imgPositionSet = null;

        public Dictionary<int, List<int>> mapPrizeInSet = null; //内定，你懂的
        #endregion

        #region 初始化

        public PrizeSystem()
        {
            this.mapPerson=new Dictionary<int,Person>();
            this.mapRank=new Dictionary<int,Rank>();
            this.mapPrize=new Dictionary<int,List<int>>();

            sysSet = new SystemSet();
            imgPositionSet = new ImgPositionSet();

            mapPrizeInSet = new Dictionary<int, List<int>>();
        }

        /// <summary>
        /// 初始化加载数据到内存
        /// </summary>
        /// <returns></returns>
        public Boolean Initialize()
        {
            try
            {
                bool dataResult = Common.GlobalDataController.Initialize(ref mapPerson, ref mapRank, ref mapPrize, ref sysSet, ref imgPositionSet, ref mapPrizeInSet);

                return dataResult;
            }
            catch (Exception ex)
            {
                Loger.Debug(ex.ToString());
                return false;
            }
        }
        #endregion

        #region 奖项管理

        /// <summary>
        /// 获取所有奖项设置
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Rank> GetAllRankSet()
        {
            Dictionary<int, Rank> mapAllRank = new Dictionary<int, Rank>(mapRank);
            return mapAllRank;
        }

        /// <summary>
        /// 获取指定的奖项设置
        /// </summary>
        /// <param name="nRankid"></param>
        /// <param name="bExist"></param>
        /// <returns></returns>
        public Rank GetRankSet(int nRankid,out bool bExist)
        {
            Rank m_rank = new Rank();
            bExist = false;

            if (!mapRank.ContainsKey(nRankid))
            {
                bExist = false;
                return m_rank;
            }
            else
            {
                bExist = true;
                m_rank = mapRank[nRankid];
                return m_rank;
            }
        }

        /// <summary>
        /// 添加奖项设置
        /// </summary>
        /// <param name="m_rank"></param>
        /// <returns></returns>
        public bool AddRankSet(Rank m_rank,out int nRankId)
        {
            nRankId = -1;
            if (m_rank.RankName == string.Empty || m_rank.RankMax < 0)
            {
                Loger.Debug(" --- add rankSet error : rankName is null or rankMax < 0 --- ");
                return false;
            }

            #region 判断是否已存在
            int nKey = 0;
            if (mapRank.Count > 0)
            {
                foreach (var data in mapRank)
                {
                    if (data.Key > nKey)
                    {
                        nKey = data.Key;
                    }
                    if (data.Value.RankName == m_rank.RankName)
                    {
                        Loger.Debug(" --- add rankSet error : mapRank has cantains this name : " + m_rank.RankName + " --- ");
                        return false;
                    }
                }
            }
            nKey++;
            #endregion

            if (!mapRank.ContainsKey(nKey))
            {
                mapRank.Add(nKey, m_rank);
                nRankId = nKey;
                Loger.Serialize(Config.PathRank, mapRank);
                Loger.Debug(" --- add rankSet successed. name : " + m_rank.RankName + " --- ");
                return true;
            }
            else
            {
                Loger.Debug(" --- add rankSet error : mapRank has cantains this name : " + m_rank.RankName + " --- . ");
                return false;
            }
        }

        /// <summary>
        /// 更新奖项设置
        /// </summary>
        /// <param name="nRankId"></param>
        /// <param name="m_rank"></param>
        /// <returns></returns>
        public bool UpdateRankSet(int nRankId, Rank m_rank)
        {
            if (m_rank.RankName == string.Empty || m_rank.RankMax < 0)
            {
                Loger.Debug(" --- update rankSet error : rankName is null or rankMax < 0 --- ");
                return false;
            }
            if (!mapRank.ContainsKey(nRankId))
            {
                Loger.Debug(" --- update rankSet error : mapRank not cantains this id : " + nRankId+" --- ");
                return false;
            }
            mapRank[nRankId] = m_rank;
            Loger.Serialize(Config.PathRank, mapRank);
            return true;
        }

        /// <summary>
        /// 删除奖项设置
        /// </summary>
        /// <param name="nRankId"></param>
        /// <returns></returns>
        public bool RemoveRankSet(int nRankId)
        {
            if (!mapRank.ContainsKey(nRankId))
            {
                return false;
            }

            mapRank.Remove(nRankId);

            //删除对应的获奖名单
            if (mapPrize.ContainsKey(nRankId))
            {
                mapPrize.Remove(nRankId);
                Loger.Serialize(Config.PathPrize, mapPrize);
            }
            Loger.Serialize(Config.PathRank, mapRank);
            return true;
        }

        #endregion

        #region 抽奖名单管理


        /// <summary>
        /// 获取所有抽奖名单
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Person> GetAllPerson()
        {
            Dictionary<int, Person> mapAllPerson = new Dictionary<int, Person>(mapPerson);
            return mapAllPerson;
        }

        /// <summary>
        /// 所有未中奖的名单
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Person> GetAllNotPrizePerson()
        {
            Dictionary<int, Person> mapAllPerson = new Dictionary<int, Person>(mapPerson);
            Dictionary<int, List<int>> mapAllPrize = new Dictionary<int, List<int>>(mapPrize);

            foreach (var data in mapAllPrize)
            {
                int nKey = data.Key;
                List<int> _listPrize = new List<int>(data.Value);

                foreach (int nPersonId in _listPrize)
                {
                    if (mapAllPerson.ContainsKey(nPersonId))
                    {
                        mapAllPerson.Remove(nPersonId);
                    }
                }
            }
            return mapAllPerson;
        }

        /// <summary>
        /// 获取指定的抽奖人员
        /// </summary>
        /// <param name="nRankid"></param>
        /// <param name="bExist"></param>
        /// <returns></returns>
        public Person GetPerson(int nPersonid, out bool bExist)
        {
            Person m_person = new Person();
            bExist = false;

            if (!mapPerson.ContainsKey(nPersonid))
            {
                bExist = false;
                return m_person;
            }
            else
            {
                bExist = true;
                m_person = mapPerson[nPersonid];
                return m_person;
            }
        }

        /// <summary>
        /// 添加抽奖人员
        /// </summary>
        /// <param name="m_rank"></param>
        /// <returns></returns>
        public bool AddPerson(Person m_person, out int nPersonId)
        {
            nPersonId = -1;
            if (m_person.PersonPhoto == string.Empty)
            {
                Loger.Debug(" --- add person error : photoName is null --- ");
                return false;
            }

            #region 判断是否已存在
            int nKey = 0;
            if (mapPerson.Count > 0)
            {
                foreach (var data in mapPerson)
                {
                    if (data.Key > nKey)
                    {
                        nKey = data.Key;
                    }
                    if (data.Value.PersonPhoto == m_person.PersonPhoto)
                    {
                        Loger.Debug(" --- add person error : mapPerson has cantains this photo : " + m_person.PersonPhoto + " --- ");
                        return false;
                    }
                }
            }
            nKey++;
            #endregion

            if (!mapPerson.ContainsKey(nKey))
            {
                mapPerson.Add(nKey, m_person);
                nPersonId = nKey;
                Loger.Serialize(Config.PathPerson, mapPerson);
               // Loger.Debug(" --- add person successed. photo : " + m_person.PersonPhoto + " --- ");
                return true;
            }
            else
            {
                Loger.Debug(" --- add person error : mapPerson has cantains this photo : " + m_person.PersonPhoto + " --- . ");
                return false;
            }
        }

        /// <summary>
        /// 更新抽奖人员
        /// </summary>
        /// <param name="nRankId"></param>
        /// <param name="m_rank"></param>
        /// <returns></returns>
        public bool UpdatePerson(int nPersonId, Person m_person)
        {
            if (m_person.PersonPhoto == string.Empty)
            {
                Loger.Debug(" --- update person error : person photo is null --- ");
                return false;
            }
            if (!mapPerson.ContainsKey(nPersonId))
            {
                Loger.Debug(" --- update person error : mapPerson not cantains this id : " + nPersonId + " --- ");
                return false;
            }
            mapPerson[nPersonId] = m_person;
            Loger.Serialize(Config.PathPerson, mapPerson);
            return true;
        }

        /// <summary>
        /// 删除抽奖人员
        /// </summary>
        /// <param name="nRankId"></param>
        /// <returns></returns>
        public bool RemovePerson(int nPersonId)
        {
            if (!mapPerson.ContainsKey(nPersonId))
            {
                return false;
            }

            mapPerson.Remove(nPersonId);

            //删除对应的获奖名单
            bool bRemove = false;
            if (mapPrize.Count > 0)
            {
                Dictionary<int, List<int>> _tempMapPrize = new Dictionary<int, List<int>>(mapPrize);

                foreach (var data in _tempMapPrize)
                {
                    int nKey = data.Key;
                    List<int> _listPerson = new List<int>(data.Value);

                    foreach (int _itemId in _listPerson)
                    {
                        if (_itemId == nPersonId)
                        {
                            mapPrize[nKey].Remove(_itemId);
                            bRemove = true;
                        }
                    }
                }
            }
            if (bRemove)
            {
                Loger.Serialize(Config.PathPrize, mapPrize);
            }
            Loger.Serialize(Config.PathPerson, mapPerson);
            return true;
        }

        #endregion

        # region 获奖名单管理

        #region Get

        /// <summary>
        /// 所有获奖名单
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, List<int>> GetAllPrize()
        {
            Dictionary<int, List<int>> _mapAllPrize = new Dictionary<int, List<int>>(mapPrize);
            return _mapAllPrize;
        }

        /// <summary>
        /// 通过获奖人获取对应奖项
        /// </summary>
        /// <param name="nPersonId"></param>
        /// <param name="bExist"></param>
        /// <returns></returns>
        public Rank GetRankByPersonId(int nPersonId,out bool bExist)
        {
            bExist = false;
            int nRankId = 0;

            Dictionary<int, List<int>> _mapAllPrize = new Dictionary<int, List<int>>(mapPrize);
            foreach (var data in _mapAllPrize)
            {
                if (data.Value.Contains(nPersonId))
                {
                    mapPrize[data.Key].Remove(nPersonId);
                    bExist = true;
                    nRankId = data.Key;
                }
            }

            Rank _rank = new Rank();
            _rank = GetRankSet(nRankId,out bExist);
            return _rank;
        }

        /// <summary>
        /// 指定奖项是否达到规定获奖人数
        /// </summary>
        /// <param name="nRankId"></param>
        /// <returns></returns>
        public bool AllowAddPrize(int nRankId)
        {
            if (!mapRank.ContainsKey(nRankId))
            {
                return false;
            }

            if (!mapPrize.ContainsKey(nRankId)) 
            {
                return true;
            }

            if (mapPrize[nRankId].Count < mapRank[nRankId].RankMax)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 通过奖项获取对应获奖人列表
        /// </summary>
        /// <param name="nRankId"></param>
        /// <param name="bExist"></param>
        /// <returns></returns>
        public List<int> GetListPersonByRankId(int nRankId, out bool bExist)
        {
            bExist = false;
            List<int> _listRet = new List<int>();

            if (mapPrize.ContainsKey(nRankId))
            {
                if (mapPrize[nRankId].Count > 0)
                {
                    bExist = true;
                    _listRet = mapPrize[nRankId];
                }
            }
            return _listRet;
        }
        #endregion

        #region remove
        /// <summary>
        /// 移除指定获奖名单中的获奖人
        /// </summary>
        /// <param name="nRankId"></param>
        /// <param name="nPersonId"></param>
        /// <returns></returns>
        public bool RemovePrizeByPerson(int nPersonId)
        {
            bool bRet = false;

            Dictionary<int, List<int>> _mapAllPrize = new Dictionary<int, List<int>>(mapPrize);
            foreach (var data in _mapAllPrize)
            {
                if (data.Value.Contains(nPersonId))
                {
                    mapPrize[data.Key].Remove(nPersonId);
                    bRet = true;
                }
            }
            if (bRet)
            {
                Loger.Serialize(Config.PathPrize, mapPrize);
                Loger.Debug(" --- remove prize by personId successed. personId : " + nPersonId + " --- ");
            }
            return bRet;
        }

        /// <summary>
        /// 移除指定获奖名单中的奖项及对应的获奖人
        /// </summary>
        /// <param name="nRankId"></param>
        /// <returns></returns>
        public bool RemovePrizeByRank(int nRankId)
        {
            bool bRet = false;

            if (mapPrize.ContainsKey(nRankId))
            {
                mapPrize.Remove(nRankId);
                bRet = true;
            }
            if (bRet)
            {
                Loger.Serialize(Config.PathPrize, mapPrize);
                Loger.Debug(" --- remove prize by nRankId successed. nRankId : " + nRankId + " --- ");
            }
            return bRet;
        }

        public bool RemovePrizeAll()
        {
            bool bRet = false;

            if (mapPrize!=null)
            {
                mapPrize.Clear();
                bRet = true;
            }
            if (bRet)
            {
                Loger.Serialize(Config.PathPrize, mapPrize);
                Loger.Debug(" --- remove prize all --- ");
            }
            return bRet;
        }
        #endregion

        #region Add
        /// <summary>
        /// 添加获奖名单
        /// </summary>
        /// <param name="nRankId"></param>
        /// <param name="nPerson"></param>
        /// <returns></returns>
        public bool AddPrize(int nRankId, int nPerson)
        {
            if (!mapPrize.ContainsKey(nRankId))
            {
                mapPrize.Add(nRankId, null);
            }
            if (mapPrize[nRankId] == null)
            {
                mapPrize[nRankId] = new List<int>();
            }

            if (mapPrize[nRankId].Contains(nPerson))
            {
                Loger.Debug(" --- prize has contains this person nRankId = " + nRankId + " nPersonId = " + nPerson + " --- ");
                return false;
            }

            if (mapPrize[nRankId].Count < mapRank[nRankId].RankMax)
            {
                mapPrize[nRankId].Add(nPerson);
                Loger.Serialize(Config.PathPrize, mapPrize);
                Loger.Debug(" --- add prize successed. nRankId = " + nRankId + " nPersonId = "+nPerson+" --- ");
                return true;
            }
            else
            {
                Loger.Debug(" --- prize count >= RankMax. nRankId = " + nRankId + " nPersonId = " + nPerson + " --- ");
                return false;
            }
        }
        #endregion

        #endregion

        #region 系统设置

        public SystemSet GetSystemSet()
        {
            if (sysSet != null)
            {
                return sysSet;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateSystemSet(SystemSet m_sysSet)
        {
            try
            {
                sysSet.Title1 = m_sysSet.Title1;
                sysSet.Title2 = m_sysSet.Title2;
                sysSet.Clr3 = m_sysSet.Clr3;
                sysSet.Clr4 = m_sysSet.Clr4;

                Loger.Serialize(Config.PathSysSet, m_sysSet);

                return true;
            }
            catch (System.Exception ex)
            {
                Loger.Debug(ex.ToString());
                return false;
            }

        }

        #endregion

        #region 长宽设置

        public ImgPositionSet GetImgPositionSet()
        {
            if (imgPositionSet != null)
            {
                return imgPositionSet;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateImgPositionSet(ImgPositionSet m_imgPositionSet)
        {
            try
            {
                imgPositionSet.Height = m_imgPositionSet.Height;
                imgPositionSet.Width = m_imgPositionSet.Width;
                imgPositionSet.Hoffset = m_imgPositionSet.Hoffset;
                imgPositionSet.VoffSet = m_imgPositionSet.VoffSet;

                Loger.Serialize(Config.PathImgPositionSet, m_imgPositionSet);

                return true;
            }
            catch (System.Exception ex)
            {
                Loger.Debug(ex.ToString());
                return false;
            }

        }

        #endregion
    }
}
