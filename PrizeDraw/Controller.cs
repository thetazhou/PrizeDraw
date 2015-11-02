using System;
using System.Collections.Generic;
using System.Text;

using PrizeDraw.Entity;
using System.Xml;
using PrizeDraw.Utils;
using System.IO;

namespace PrizeDraw
{
    public class DataController
    {
        /// <summary>
        /// 反序列化填充数据
        /// </summary>
        /// <param name="m_mapPerson"></param>
        /// <param name="m_mapRank"></param>
        /// <param name="m_mapPrize"></param>
        /// <returns></returns>
        public Boolean Initialize(ref Dictionary<int, Person> m_mapPerson, ref Dictionary<int, Rank> m_mapRank, ref Dictionary<int, List<int>> m_mapPrize
            , ref SystemSet m_systemSet, ref ImgPositionSet m_imgPositionSet, ref Dictionary<int, List<int>> m_mapPrizeInSet)
        {
            Loger.Debug(" >>> Controller Initialize start <<< ");
            try
            {
                bool bExists = false;
                m_mapPerson = Loger.DeSerialize<Dictionary<int, Person>>(Config.PathPerson, out bExists);
                if (!bExists)
                {
                    m_mapPerson = new Dictionary<int, Person>();
                    Loger.Debug("person dat is not exist.");
                }

                bExists = false;
                m_mapRank = Loger.DeSerialize<Dictionary<int, Rank>>(Config.PathRank, out bExists);
                if (!bExists)
                {
                    m_mapRank = new Dictionary<int, Rank>();
                    Loger.Debug("rank dat is not exist.");
                }

                bExists = false;
                m_mapPrize = Loger.DeSerialize<Dictionary<int, List<int>>>(Config.PathPrize, out bExists);
                if (!bExists)
                {
                    m_mapPrize = new Dictionary<int, List<int>>();
                    Loger.Debug("prize dat is not exist.");
                }

                bExists = false;
                m_systemSet = Loger.DeSerialize<SystemSet>(Config.PathSysSet, out bExists);
                if (!bExists)
                {
                    m_systemSet = new SystemSet();
                    Loger.Debug("systemSet dat is not exist.");
                }

                bExists = false;
                m_imgPositionSet = Loger.DeSerialize<ImgPositionSet>(Config.PathImgPositionSet, out bExists);
                if (!bExists)
                {
                    m_imgPositionSet = new ImgPositionSet();
                    Loger.Debug("ImgPositionSet dat is not exist.");
                }

                #region 内定
                string fileSc = Config.PathConfig + @"\config.xml";
                if (File.Exists(fileSc))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(fileSc);
                    XmlNode root = null;
                    XmlNode SingleNode = null;
                    root = doc.SelectSingleNode("/RankSet");

                    SingleNode = root;
                    m_mapPrizeInSet.Clear();

                    Loger.Debug(" child count = " + SingleNode.ChildNodes.Count);

                    foreach (XmlNode child in SingleNode.ChildNodes) //遍历设置项
                    {
                        if (child.Name.ToLower() == "rank") //找到rank行
                        {
                            #region 搜索对应奖项
                            string strRankName = XmlUtils.GetXmlAttributeValue(child, "name", "");

                            bool bRankExist = false;
                            int nRankId = 0;
                            foreach (var data in m_mapRank) //遍历奖项列表
                            {
                                if (data.Value.RankName == strRankName) //奖项列表中存在设置的奖项
                                {
                                    bRankExist = true;
                                    nRankId = data.Value.RankId;
                                    break;
                                }
                            }
                            if (!bRankExist)
                            {
                                continue;
                            }
                            #endregion

                            string strPrizeSet = XmlUtils.GetXmlAttributeValue(child, "Set", ""); //获取set组
                            string[] arrPrizeSet = strPrizeSet.Split(',');
                            if (arrPrizeSet.Length <= 0)
                            {
                                continue;
                            }

                            foreach (var s in arrPrizeSet)
                            {
                                foreach (var p in Common.GlobalPrizeSystem.mapPerson) //遍历人员列表
                                {
                                    if (s == p.Value.PersonName)
                                    {
                                        if (!m_mapPrizeInSet.ContainsKey(nRankId))
                                        {
                                            m_mapPrizeInSet.Add(nRankId, new List<int>());
                                        }
                                        m_mapPrizeInSet[nRankId].Add(p.Key);

                                        break;
                                    }
                                }
                            }
                            Loger.Debug("m_mapPrizeInSet count = " + m_mapPrizeInSet.Count);

                          


                        }
                    }
                }
                else
                {
                    Loger.Debug("PrizeInSet file not exist ");
                }
                #endregion

                Loger.Debug(" <<< Controller Initialize successed.>>> ");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
