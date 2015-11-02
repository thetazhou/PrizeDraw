using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

using PrizeDraw.Entity;
using PrizeDraw.Utils;
using System.Xml.Serialization;

namespace PrizeDraw
{
    public static class Config
    {
        private static readonly object lockXmlObject = new object();

        public static readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string PathPerson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "person.dat");
        public static readonly string PathRank = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rank.dat");
        public static readonly string PathPrize = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "prize.dat");

        public static readonly string PathSysSet = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sysSet2.dat");
        public static readonly string PathImgPositionSet = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imgPositionSet.dat");

        public static string PathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");
  
        static Config()
        {



        }
 
    }
}
