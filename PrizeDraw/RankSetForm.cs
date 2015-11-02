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
    public partial class RankSetForm : Form
    {
        private Dictionary<int, Rank> mapAllRank = null;

        public RankSetForm()
        {
            InitializeComponent();
        }

        private void RankSetForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        #region 加载列表到窗口
        private void Initialize()
        {
            try
            {
                mapAllRank = new Dictionary<int, Rank>();
                mapAllRank = Common.GlobalPrizeSystem.GetAllRankSet();

                dgvRankSet.Rows.Clear();
                foreach (var data in mapAllRank)
                {
                    dgvRankSet.Rows.Add(data.Key, data.Value.RankName, data.Value.RankMax, data.Value.RankPrize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region 添加修改
        private void btnUpdateRanSet_Click(object sender, EventArgs e)
        {
            bool bRet = false;
            try
            {
                foreach (DataGridViewRow row in dgvRankSet.Rows)
                {
                    if (row.Cells["RankName"].Value == null)
                        continue;

                    //MessageBox.Show("遍历：" + row.Cells["RankName"].Value.ToString());

                    if (row.Cells["RankId"].Value != null )
                    {
                        Rank data = new Rank();
                        data.RankId = Convert.ToInt32(row.Cells["RankId"].Value);
                        data.RankName = row.Cells["RankName"].Value.ToString();
                        data.RankMax = Convert.ToInt32(row.Cells["RankMax"].Value);
                        data.RankPrize = row.Cells["RankPrize"].Value.ToString();

                        if (!Common.GlobalPrizeSystem.UpdateRankSet(data.RankId, data))
                        {
                            bRet = false;
                           // MessageBox.Show("更新失败！" + data.RankId);
                        }
                        else
                        {
                            bRet = true;
                           // MessageBox.Show("更新成功！" + data.RankId);
                        }
                    }
                    else
                    {
                        Rank data = new Rank();
                        data.RankName = row.Cells["RankName"].Value.ToString();
                        data.RankMax = Convert.ToInt32(row.Cells["RankMax"].Value.ToString());
                        data.RankPrize = row.Cells["RankPrize"].Value.ToString();

                        int nAddRankId = -1;
                        if (!Common.GlobalPrizeSystem.AddRankSet(data, out nAddRankId))
                        {
                            bRet = false;
                            //MessageBox.Show("添加失败！" + data.RankId);
                        }
                        else
                        {
                            if (nAddRankId > -1)
                            {
                                bRet = true;
                               // MessageBox.Show("添加成功！" + data.RankId);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("格式不正确！");
                return;
            }
            if (bRet)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
            
            Initialize();
        }
        #endregion

        #region 取消并关闭窗口
        private void btnCancelRankSet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection rowsSelected = dgvRankSet.SelectedRows;
                int nRemoveCount = rowsSelected.Count;
                if (nRemoveCount < 1)
                {
                    MessageBox.Show("请点击行首选择整行");
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
                    int nRankId = Convert.ToInt32(item.Cells["RankId"].Value.ToString());
                    if (!Common.GlobalPrizeSystem.RemoveRankSet(nRankId))
                    {
                        MessageBox.Show("remove error on : " + nRankId);
                    }
                    else
                    {

                    }
                }
                Initialize();
            }
            catch (System.Exception ex)
            {
                lblMsg.Text = "new line";
            }
        }
        #endregion
    }
}
