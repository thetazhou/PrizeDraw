using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using PrizeDraw.Entity;

namespace PrizeDraw
{
    public partial class TitleSetForm : Form
    {
        public TitleSetForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SystemSet _old = Common.GlobalPrizeSystem.GetSystemSet();

            SystemSet _set = new SystemSet();
            _set.Title1 = txtBoxTitle1.Text;
            _set.Title2 = txtBoxTitle2.Text;

            _set.Clr3 = _old.Clr3;
            _set.Clr4 = _old.Clr4;

            Common.GlobalPrizeSystem.UpdateSystemSet(_set);
            Common.mBox.UpdateTitle();

            this.Close();
        }

        private void TitleSetForm_Load(object sender, EventArgs e)
        {
            SystemSet _set = new SystemSet();
            _set = Common.GlobalPrizeSystem.GetSystemSet();
            if (_set != null)
            {
                txtBoxTitle1.Text = _set.Title1;
                txtBoxTitle2.Text = _set.Title2;
            }
        }
    }
}
