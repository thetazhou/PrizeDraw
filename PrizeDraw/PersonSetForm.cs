using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using PrizeDraw.Entity;

namespace PrizeDraw
{
    public partial class PersonSetForm : Form
    {
        public delegate void DlgPgChange(string path);

        public void PgChangedMethod(string path)
        {
            int nPersonId = -1;
            Person _person = new Person();
            _person.PersonPhoto = path;
            _person.PersonName = Path.GetFileNameWithoutExtension(path);
            if (!Common.GlobalPrizeSystem.AddPerson(_person, out nPersonId))
            {
                Loger.Debug(" --- import photo error . photo = " + path);
            }
            else
            {
                pgBar.Value++;
                if (pgBar.Value == pgBar.Maximum)
                {
                    Initialize();
                    MessageBox.Show("导入完成");
                }
            }
            return;
        }

        public PersonSetForm()
        {
            InitializeComponent();
        }

        private void PersonSetForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        #region 加载列表到窗口
        private void Initialize()
        {
            try
            {
               Dictionary<int, Person> mapAllPerson = new Dictionary<int, Person>();
                mapAllPerson = Common.GlobalPrizeSystem.GetAllPerson();

                dgvPerson.Rows.Clear();
                foreach (var data in mapAllPerson)
                {
                    dgvPerson.Rows.Add(data.Key, data.Value.PersonName, data.Value.PersonPhoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void btnImport_Click(object sender, EventArgs e)
        {
            List<string> listFiles = new List<string>();

            OpenFileDialog oFileDialog = new OpenFileDialog();
             oFileDialog.Filter = "照片|*.jpg|所有文件|*.*";
            oFileDialog.RestoreDirectory = true;
            oFileDialog.FilterIndex = 1;
            oFileDialog.Multiselect = true;
            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                listFiles.AddRange(oFileDialog.FileNames);
            }

            pgBar.Maximum = listFiles.Count;
            pgBar.Minimum = 0;
            pgBar.Step = 1;
            pgBar.Value = 0;
            pgBar.Visible = true;

            new Thread(delegate()
           {
               foreach (string path in listFiles)
               {
                   Invoke(new DlgPgChange(PgChangedMethod), new object[] { path });
               }
           }).Start();
               
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowsSelected = dgvPerson.SelectedRows;
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
                if (!Common.GlobalPrizeSystem.RemovePerson(nPersonId))
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
