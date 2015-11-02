using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrizeDraw
{
    public partial class PrizeSetForm : Form
    {
        private Dictionary<int, List<int>> mapAllPrize = null;

        public PrizeSetForm()
        {
            InitializeComponent();
        }

        private void PrizeSetForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        #region 加载列表到窗口
        private void Initialize()
        {
            try
            {
                mapAllPrize = new Dictionary<int, List<int>>();
                mapAllPrize = Common.GlobalPrizeSystem.GetAllPrize();

                dgvPrizeSet.Rows.Clear();
                foreach (var data in mapAllPrize)
                {
                    foreach (int nPerson in data.Value)
                    {
                        bool bRankExist = false;
                        bool bPersonExist = false;
                        dgvPrizeSet.Rows.Add(Common.GlobalPrizeSystem.GetRankSet(data.Key, out bRankExist).RankName,
                                                       Common.GlobalPrizeSystem.GetPerson(nPerson, out bPersonExist).PersonName, data.Key, nPerson);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowsSelected = dgvPrizeSet.SelectedRows;
            int nRemoveCount = rowsSelected.Count;
            if (nRemoveCount < 1)
            {
                MessageBox.Show("请点击行首选择整行，可按Ctrl或Shift多选。");
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult dRet = MessageBox.Show("有" + nRemoveCount + "行将被删除", "删除提示", buttons, MessageBoxIcon.Warning);
            if (dRet != DialogResult.OK && dRet != DialogResult.Yes)
            {
                return;
            }

            foreach (DataGridViewRow item in rowsSelected)
            {
                int nPersonId = Convert.ToInt32(item.Cells["PersonId"].Value.ToString());
                if (!Common.GlobalPrizeSystem.RemovePrizeByPerson(nPersonId))
                {
                    MessageBox.Show("remove error on : " + nPersonId);
                }
                else
                {

                }
            }
            Initialize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
