using System;
using System.Collections.Generic;
using System.Text;

namespace PrizeDraw.Entity
{

    #region 抽奖人员
    /// <summary>
    /// 参与抽奖人员
    /// </summary>
    [Serializable]
    public class Person
    {
        public int PersonId;
        public string PersonName;
        public string PersonPhoto;

        public Person()
        {
            PersonId = 0;
            PersonName = "";
            PersonPhoto = "";
        }
    }
    #endregion

    #region 奖项设置
    /// <summary>
    /// 奖项设置
    /// </summary>
    [Serializable]
    public class Rank
    {
        public int RankId;
        public string RankName;//奖项名称（如:特等奖，一等奖etc.）
        public int RankMax;//获奖人数上限
        public string RankPrize;//奖品

        public Rank()
        {
            RankId = 0;
            RankName = "";
            RankMax = 0;
            RankPrize = "";
        }
    }
    #endregion

    #region 系统设置
    [Serializable]
    public class SystemSet
    {
        public string Title1;
        public string Title2;
        public string Clr3;
        public string Clr4;

        public SystemSet()
        {
            Title1 = "";
            Title2 = "";
            Clr3 = "#336699";
            Clr4 = "#336699";
        }
    }
    #endregion

    #region 图片长宽
    [Serializable]
    public class ImgPositionSet
    {
        public int Width;
        public int Height;
        public int Hoffset;
        public int VoffSet;

        public ImgPositionSet()
        {
            Width = 400;
            Height = 300;
            Hoffset = 0;
            VoffSet = 0;
        }
    }
    #endregion

}