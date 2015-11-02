using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PrizeDraw.Entity;

namespace PrizeDraw
{
    public class Common
    {
        public static PrizeSystem GlobalPrizeSystem = null;
        public static DataController GlobalDataController = null;

        public static bool Initialize()
        {
            GlobalPrizeSystem = new PrizeSystem();
            GlobalDataController = new DataController();

            if (!GlobalPrizeSystem.Initialize())
            {
                return false;
            }

            return true;
        }
 
        #region mainform object
        private static MainBox _mBox = null;
        public static MainBox mBox
        {
            get
            {
                if (_mBox == null)
                {
                    _mBox = new MainBox();
                }
                return _mBox;
            }
        }


        #endregion

        #region main
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Common.mBox);
        }
        #endregion
    }
}
