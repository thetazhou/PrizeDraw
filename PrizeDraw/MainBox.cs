using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

using PrizeDraw.Entity;

namespace PrizeDraw
{
    public delegate void DlgGenerate(string msg);

    public partial class MainBox : Form
    {
        #region 变量
        private bool bGenerate = false;
 
        private static Random random = null;

        private int nCurrPersonId = 0;

        private MusicPlay mPlay = null;
        public string fMusicName1 = "";
        public string fMusicName2 = "";
        public string fMusicName3 = "";
        public bool bPlay1 = false;
        public bool bPlay2 = false;
        public bool bPlay3 = false;
        public string currMusic = "";
        public bool bCurrPlay = false;

        #endregion


        #region 初始化
        public MainBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            groupBox1.Visible = false;

        }

        private void Init()
        {
            #region 设置背景
            string strBgFile = "";
            if (File.Exists(Config.BasePath + @"\bg.bmp"))
            {
                strBgFile = Config.BasePath + @"\bg.bmp";
                this.BackgroundImage = Image.FromFile(strBgFile);
            }
            else if (File.Exists(Config.BasePath + @"\bg.jpg"))
            {
                strBgFile = Config.BasePath + @"\bg.jpg";
                this.BackgroundImage = Image.FromFile(strBgFile);
            }

            #endregion

            #region 图片宽高

            UpdatePicBoxPosition();
 
            #endregion

            UpdateTitle();

            #region 初始化音乐选择控件
            string[] arrFilesGenerate = Directory.GetFiles(Config.BasePath + "/Sounds/中奖音乐"); //中奖音乐
            string[] arrFilesBackground = Directory.GetFiles(Config.BasePath + "/Sounds/背景音乐"); //背景音乐
            string[] arrFilesPrizeList = Directory.GetFiles(Config.BasePath + "/Sounds/中奖名单音乐"); //中奖名单音乐

            foreach (string item in arrFilesGenerate)//中奖音乐
            {
                string fName = System.IO.Path.GetFileName(item);
                cmBoxMusicPrizeGenerate.Items.Add(fName);
            }
            cmBoxMusicPrizeGenerate.SelectedIndex = 0;

            foreach (string item in arrFilesBackground) //背景音乐
            {
                string fName = System.IO.Path.GetFileName(item);
                cmBoxMusicBackground.Items.Add(fName);
            }
            cmBoxMusicBackground.SelectedIndex = 0;

            foreach (string item in arrFilesPrizeList)//中奖名单音乐
            {
                string fName = System.IO.Path.GetFileName(item);
                cmBoxMusicPrizeBackground.Items.Add(fName);
            }
            cmBoxMusicPrizeBackground.SelectedIndex = 0;
            #endregion

            mPlay = new MusicPlay();
        }

        private void UpdatePicBoxPosition()
        {
            ImgPositionSet imgSet = Common.GlobalPrizeSystem.GetImgPositionSet();
            if (imgSet != null)
            {
                pictureBox1.Width = imgSet.Width;
                pictureBox1.Height = imgSet.Height;

                tBoxImgWidth.Text = imgSet.Width.ToString();
                tBoxImgHeight.Text = imgSet.Height.ToString();
                tBoxHOffset.Text = imgSet.Hoffset.ToString();
                tBoxVOffset.Text = imgSet.VoffSet.ToString();
            }

            int nOffset = 0;
            if (this.Height <= 768) nOffset = 50; else nOffset = 0;

            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2 + imgSet.Hoffset, this.Height / 2 - pictureBox1.Height / 2 + nOffset + imgSet.VoffSet);

            lblPrizeName.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 20, pictureBox1.Location.Y + pictureBox1.Height/4);
            lblPrizeGenerate.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 40, pictureBox1.Location.Y + pictureBox1.Height - (pictureBox1.Height / 4));
        }

        private void MainBox_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Common.Initialize())
                {
                    MessageBox.Show("系统初始化出错...");
                }
               

                Init();
                lblTitle1.BackColor = Color.Transparent;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region 抽奖

        #region 抽奖按钮
        private void btnPrizeGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupBox1.Visible == true)
                {
                    groupBox1.Visible = false;
                }

                if (!bGenerate)
                {
                    bGenerate = true;
                    btnGenerateStart.Text = "停 止";

                    #region 脱离UI线程独立运行抽奖子线程
                    Thread _thread = new Thread(new ThreadStart(GenerateThreadMethod));
                    _thread.IsBackground = true;
                    _thread.Start();
                    #endregion
                }
                else
                {
                    bGenerate = false;
                    btnGenerateStart.Text = "继 续";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region 抽奖子线程运行函数
        private void GenerateThreadMethod()
        {
            try
            {
                #region 获取音乐文件路径
                this.Invoke(new DlgGenerate(GetMusicSet),  new object[] {"" });
                #endregion

                #region 获取奖项设置，抽奖名单
                Dictionary<int, Rank> _mapRank = new Dictionary<int, Rank>(); //全部奖项
                _mapRank = Common.GlobalPrizeSystem.GetAllRankSet();
                if (_mapRank.Count <= 0)
                {
                    this.Invoke(new DlgGenerate(ShowMessage), new object[] { "奖项为空！"});
                    return;
                }

                Dictionary<int, Person> _mapPerson = new Dictionary<int, Person>(); //当前全部抽奖人员
                _mapPerson = Common.GlobalPrizeSystem.GetAllNotPrizePerson();
                if (_mapPerson.Count <= 0)
                {
                    this.Invoke(new DlgGenerate(ShowMessage), new object[] { "名单为空！" });
                    return;
                }
                #endregion

                #region 获取当前需要抽奖的奖项ID

                int[] _arryRankId = new int[_mapRank.Count];
                _mapRank.Keys.CopyTo(_arryRankId, 0);

                int nRankId = 0;
                bool bExist = false;
                for (int nCurr = _arryRankId.Length - 1; nCurr > -1; nCurr--) //从最后奖项遍历
                {
                    nRankId = _arryRankId[nCurr];
                    if (Common.GlobalPrizeSystem.AllowAddPrize(nRankId))
                    {
                        bExist = true;
                        break;
                    }
                }
                if (!bExist) //奖已抽完，退出
                {
                    this.Invoke(new DlgGenerate(ShowMessage), new object[] { "全部奖项已抽完！" });
                    return;
                }
                #endregion

                #region 显示当前奖项信息

                int nCurrTimes=0;
                bool bCurrHasPrize=false;
                nCurrTimes = _mapRank[nRankId].RankMax - (_mapRank[nRankId].RankMax - Common.GlobalPrizeSystem.GetListPersonByRankId(nRankId, out bCurrHasPrize).Count) + 1;
                this.Invoke(new DlgGenerate(UpdateLblRankName),
                    new object[] { Regex.Replace(_mapRank[nRankId].RankName,@"([\w])","$1 ") });
                   // new object[] { _mapRank[nRankId].RankName + " - " + _mapRank[nRankId].RankMax + "名  第" + nCurrTimes + "次抽奖" });

                this.Invoke(new DlgGenerate(UpdateLblRankInfo), new object[] { _mapRank[nRankId].RankPrize });

                #endregion

                #region 内定人员

                bool bSetFind = false; //当前是否有内定

                List<int> listJumpPersonId = new List<int>(); //以后中奖的人
                List<int> listSetPersonId = new List<int>();//当前要中奖的人

                Dictionary<int, List<int>> _tempInSet = new Dictionary<int, List<int>>();
                _tempInSet = Common.GlobalPrizeSystem.mapPrizeInSet;
                foreach (var data in _tempInSet) //遍历内定项
                {
                    if (data.Key < nRankId)
                    {
                        listJumpPersonId.AddRange(data.Value); //当前不能中奖的人，保存到以后去中奖
                    }
                    else if (data.Key == nRankId)
                    {
                        if (data.Value.Count > 0)
                        {
                            bSetFind = true;
                            listSetPersonId.AddRange(data.Value);
                           // Common.GlobalPrizeSystem.mapPrizeInSet[nKey].RemoveAt(0);
                        }
                    }
                }
                #endregion

                int[] arrPerson = new int[_mapPerson.Count];
                _mapPerson.Keys.CopyTo(arrPerson, 0);
                random = new Random();


                currMusic = fMusicName2;
                bCurrPlay = bPlay2;
                this.Invoke(new DlgGenerate(PlayMusic), new object[] {""});

                while (true)
                {

                    int nRdId = random.Next(0, arrPerson.Length);
                    int nPerson = arrPerson[nRdId];

                    //控件委托方式回到UI线程更新界面
                    this.Invoke(new DlgGenerate(GenerateInvokeMethod), new object[] { _mapPerson[nPerson].PersonPhoto});

                    if (!bGenerate)
                    {

                        if (bSetFind) //内定
                        {
                            if (!listSetPersonId.Contains(nPerson)) //当前不是内定人员时，跳到内定人
                            {
                                nPerson = Common.GlobalPrizeSystem.mapPrizeInSet[nRankId][0];
                                Common.GlobalPrizeSystem.mapPrizeInSet[nRankId].RemoveAt(0);
                                this.Invoke(new DlgGenerate(GenerateInvokeMethod), new object[] { _mapPerson[nPerson].PersonPhoto });
                            }

                        }
                        else //没有内定时，跳过内定名单
                        {
                            while (true)
                            {
                                if (!listJumpPersonId.Contains(nPerson))
                                {
                                    this.Invoke(new DlgGenerate(GenerateInvokeMethod), new object[] { _mapPerson[nPerson].PersonPhoto });
                                    break;
                                }
                                nRdId = random.Next(0, arrPerson.Length);
                                nPerson = arrPerson[nRdId];
                            }
                        }

                        if (Common.GlobalPrizeSystem.AddPrize(nRankId, nPerson))
                        {
                            currMusic = fMusicName1;
                            bCurrPlay = bPlay1;
                            this.Invoke(new DlgGenerate(PlayMusic), new object[] { "" });
                            this.nCurrPersonId = nPerson;
                        }
                        else
                        {
                            //this.Invoke(new DlgGenerate(ShowMessage), new object[] { "add prize error " });
                        }
                        break; //中奖，跳出
                    }
                    System.Threading.Thread.Sleep(50);
                }
            }
            catch (System.Exception ex)
            {
              this.Invoke(new DlgGenerate(ShowMessage), new object[] { ex.ToString()});
                //throw ex;
            }
        }
        #endregion

        #region 子线程中的控件委托函数
        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
        private void UpdateLblRankName(string msg)
        {
            lblPrizeName.Text = msg;
        }
        private void UpdateLblRankInfo(string msg)
        {
            lblRankInfo.Text = msg;
        }
        private void GenerateInvokeMethod(string msg)
        {
            lblPrizeGenerate.Text = System.IO.Path.GetFileNameWithoutExtension(msg);
            pictureBox1.Image = Image.FromFile(msg);
        }
        /// <summary>
        /// 获取音乐路径配置
        /// </summary>
        /// <param name="msg"></param>
        private void GetMusicSet(string msg)
        {
            fMusicName1 = Config.BasePath + @"Sounds\中奖音乐\" + cmBoxMusicPrizeGenerate.SelectedItem.ToString();
            bPlay1 = ckBoxMusicPrizeGenerate.Checked;

            fMusicName2 = Config.BasePath + @"Sounds\背景音乐\" + cmBoxMusicBackground.SelectedItem.ToString();
            bPlay2 = ckBoxMusicBackground.Checked;

            fMusicName3 = Config.BasePath + @"Sounds\中奖名单音乐\" + cmBoxMusicPrizeBackground.SelectedItem.ToString();
            bPlay3 = ckBoxMusicPrizeListBackGround.Checked;
        }
        /// <summary>
        /// 播放音乐，只能在UI主线程上播放
        /// </summary>
        /// <param name="none"></param>
        private void PlayMusic(string none)
        {
            //MessageBox.Show("currMusic = " + currMusic + " bCurrPlay = " + bCurrPlay);
            //Common.mBox.MusicPlay(Common.mBox.fMusicName3, Common.mBox.bPlay3);

            if (mPlay != null && currMusic == "")
            {
                //MessageBox.Show("关闭");
                mPlay.StopT();
            }
            else if (mPlay != null && currMusic != "" && (bCurrPlay == false))
            {
                //MessageBox.Show("关闭");
                mPlay.StopT();
            }
            else if (mPlay != null && currMusic != "" && (bCurrPlay == true))
            {
                mPlay = new MusicPlay();
                mPlay.FileName = currMusic;
                mPlay.play();
            }
            else
            {
                MessageBox.Show("调用音乐错误");
            }
            //MessageBox.Show("mPlay " + mPlay.FileName);
        }

        #endregion

        #endregion

        #region 菜单-显示

        private void mbtn_ChgTitle_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 菜单-文件
 
 
        #endregion

        #region 主窗口上下文菜单
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OTSM_btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 设置区域显示和隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OTSM_btn_SetForm_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
           
        }

        /// <summary>
        /// 取消当前中奖者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OTSM_btn_CancelCurrPrize_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult dRet = MessageBox.Show("确定要取消当前中奖名单？", "删除提示", buttons, MessageBoxIcon.Warning);
            if (dRet == DialogResult.OK || dRet == DialogResult.Yes)
            {
                Common.GlobalPrizeSystem.RemovePrizeByPerson(this.nCurrPersonId);
                this.nCurrPersonId = 0;
            }
        }
        #endregion



        #region 奖项，抽奖人员，获奖名单管理
        private void btnPrizeSet_Click(object sender, EventArgs e)
        {
            RankSetForm _rankSetForm = new RankSetForm();
            _rankSetForm.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                PersonSetForm _personSetForm = new PersonSetForm();
                _personSetForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPrizeManage_Click(object sender, EventArgs e)
        {
            PrizeSetForm _prizeSetForm = new PrizeSetForm();
            _prizeSetForm.ShowDialog();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult dRet = MessageBox.Show("所有数据将被清空，确定要执行？", "初始化提示", buttons, MessageBoxIcon.Warning);
            if (dRet == DialogResult.OK || dRet == DialogResult.Yes)
            {
                bool bRet = false;
                string strBakDir = Path.Combine(Config.BasePath, "dataBak");
                if (!Directory.Exists(strBakDir))
                {
                    Directory.CreateDirectory(strBakDir);
                }

                if (File.Exists(Config.PathRank))
                {
                    File.Move(Config.PathRank, Path.Combine(strBakDir, "rank.dat." + DateTime.Now.ToString("yyyyMMddHHmmss")));
                    bRet = true;
                }
                if (File.Exists(Config.PathPerson))
                {
                    File.Move(Config.PathPerson, Path.Combine(strBakDir, "person.dat." + DateTime.Now.ToString("yyyyMMddHHmmss")));
                    bRet = true;
                }
                if (File.Exists(Config.PathPrize))
                {
                    File.Move(Config.PathPrize, Path.Combine(strBakDir, "prize.dat." + DateTime.Now.ToString("yyyyMMddHHmmss")));
                    bRet = true;
                }
                if (bRet)
                {
                    Common.Initialize();
                    MessageBox.Show("系统已初始化。");
                }
                else
                {
                    MessageBox.Show("系统已是初始状态。");
                }
            }
        }
        #endregion

        #region 标题设置
        /// <summary>
        /// 调用标题设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTitleSet_Click(object sender, EventArgs e)
        {
            TitleSetForm _titleSetForm = new TitleSetForm();
            _titleSetForm.ShowDialog();
        }

        /// <summary>
        /// 更新标题
        /// </summary>
        public void UpdateTitle()
        {
            SystemSet _sysSet = Common.GlobalPrizeSystem.GetSystemSet();
            lblTitle1.Text = _sysSet.Title1;
            lblTitle2.Text = _sysSet.Title2;

            lblPrizeName.ForeColor = ColorTranslator.FromHtml(_sysSet.Clr3);
            lblPrizeGenerate.ForeColor = ColorTranslator.FromHtml(_sysSet.Clr4);

            lblTitle1.Location = new Point(this.Width / 2 - lblTitle1.Width / 2, lblTitle1.Location.Y);
            lblTitle2.Location = new Point(this.Width / 2 - lblTitle2.Width / 2, lblTitle2.Location.Y);
        }
        #endregion

        #region 主界面按钮
        private void btnGenerateQuit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult dRet = MessageBox.Show("软件将被恢复为未抽奖状态，确定要结束？", "结束提示", buttons, MessageBoxIcon.Warning);
            if (dRet == DialogResult.OK || dRet == DialogResult.Yes)
            {
                Common.GlobalPrizeSystem.RemovePrizeAll();
                lblPrizeGenerate.Text = "";
                lblPrizeName.Text = "";
                btnGenerateStart.Text = "开 始";
                pictureBox1.Image = null;
            }
        }

        #endregion

        #region 文字显示与关闭

        /// <summary>
        /// 主标题显示和隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckBoxDispTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxDispTitle.Checked)
            {
                lblTitle1.Visible = true;
                lblTitle2.Visible = true;
            }
            else
            {
                lblTitle1.Visible = false;
                lblTitle2.Visible = false;
            }

        }

        /// <summary>
        /// 奖项名称显示和隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckBoxPrizeName_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxPrizeName.Checked)
            {
                lblPrizeName.Visible = true;
            }
            else
            {
                lblPrizeName.Visible = false;
            }
        }

        /// <summary>
        /// 奖品信息显示和隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckBoxPrizeInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxPrizeInfo.Checked)
            {
                lblRankInfo.Visible = true;
            }
            else
            {
                lblRankInfo.Visible = false;
            }
        }

        /// <summary>
        /// 照片名称显示和隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckBoxPhotoName_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxPhotoName.Checked)
            {
                lblPrizeGenerate.Visible = true;
            }
            else
            {
                lblPrizeGenerate.Visible = false;
            }
        }
        #endregion

        #region 背景音乐管理

        #region 音乐下拉框
        private void cmBoxMusicPrizeGenerate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmBoxMusicBackground_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmBoxMusicPrizeBackground_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region 音乐选取或取消框
        private void ckBoxMusicPrizeGenerate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckBoxMusicBackground_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckBoxMusicPrizeListBackGround_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        public void MusicPlay(string m_fName,bool m_bPlay)
        {
            if (mPlay !=null && m_fName == "")
            {
                //MessageBox.Show("关闭");
                mPlay.StopT();
            }
            else if (mPlay != null && m_fName != "" && (m_bPlay == false))
            {
                //MessageBox.Show("关闭");
                mPlay.StopT();
            }
            else if (mPlay != null && m_fName != "" && (m_bPlay == true))
            {
                //MessageBox.Show("播放");
                mPlay = new MusicPlay();
                mPlay.FileName = m_fName;
                mPlay.play();
            }
            else
            {
                MessageBox.Show("调用音乐错误");
            }
            //MessageBox.Show("mPlay " + mPlay.FileName);
        }

        #region 试听
        /// <summary>
        /// 中奖音乐试听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = Config.BasePath + @"\Sounds\中奖音乐\" + cmBoxMusicPrizeGenerate.SelectedItem.ToString();
                if (mPlay == null)
                {
                    mPlay = new MusicPlay();
                }
                if (btnMusicGenerate.Text == "试听")
                {
                    btnMusicGenerate.Text = "停止";
                    MusicPlay(fName, true);
                }
                else
                {
                    btnMusicGenerate.Text = "试听";
                    mPlay.StopT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        /// <summary>
        /// 背景音乐试听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicBackground_Click(object sender, EventArgs e)
        {
            
            try
            {
                string fName = Config.BasePath + @"\Sounds\背景音乐\" + cmBoxMusicBackground.SelectedItem.ToString();
                if (mPlay == null)
                {
                    mPlay = new MusicPlay();
                }
                if (btnMusicBackground.Text == "试听")
                {
                    btnMusicBackground.Text = "停止";
                    MusicPlay(fName, true);
                }
                else
                {
                    btnMusicBackground.Text = "试听";
                    mPlay.StopT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 中奖名单音乐试听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicPrizeBackground_Click(object sender, EventArgs e)
        {
           

            try
            {
                string fName = Config.BasePath + @"\Sounds\中奖名单音乐\" + cmBoxMusicPrizeBackground.SelectedItem.ToString();
                if (mPlay == null)
                {
                    mPlay = new MusicPlay();
                }
                if (btnMusicPrizeBackground.Text == "试听")
                {
                    btnMusicPrizeBackground.Text = "停止";
                    MusicPlay(fName, true);
                }
                else
                {
                    btnMusicPrizeBackground.Text = "试听";
                    mPlay.StopT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        private void btnSetImg_Click(object sender, EventArgs e)
        {
            try
            {
                ImgPositionSet imgSet = new ImgPositionSet();
                imgSet.Height = Convert.ToInt32(tBoxImgHeight.Text);
                imgSet.Width = Convert.ToInt32(tBoxImgWidth.Text);
                imgSet.VoffSet = Convert.ToInt32(tBoxVOffset.Text);
                imgSet.Hoffset = Convert.ToInt32(tBoxHOffset.Text);

                Common.GlobalPrizeSystem.UpdateImgPositionSet(imgSet);
                UpdatePicBoxPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("只能输入数字！");
            }

        }

        #endregion

        private void btnChgClr1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = Color.Red;//初始化当前文本框中的字体颜色，当用户在ColorDialog对话框中点击\"取消\"按钮   
            colorDialog.ShowDialog();
            btn.BackColor = colorDialog.Color;

            SystemSet _old = Common.GlobalPrizeSystem.GetSystemSet();

            SystemSet _set = new SystemSet();
            _set.Title1 = _old.Title1;
            _set.Title2 = _old.Title2;

            _set.Clr3 = ColorTranslator.ToHtml(colorDialog.Color);
            _set.Clr4 = _old.Clr4;

            Common.GlobalPrizeSystem.UpdateSystemSet(_set);

            UpdateTitle();
        }

        private void btnChgClr2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = Color.Red;//初始化当前文本框中的字体颜色，当用户在ColorDialog对话框中点击\"取消\"按钮   
            colorDialog.ShowDialog();
            btn.BackColor = colorDialog.Color;

            SystemSet _old = Common.GlobalPrizeSystem.GetSystemSet();

            SystemSet _set = new SystemSet();
            _set.Title1 = _old.Title1;
            _set.Title2 = _old.Title2;

            _set.Clr3 = _old.Clr3;
            _set.Clr4 = ColorTranslator.ToHtml(colorDialog.Color);

            Common.GlobalPrizeSystem.UpdateSystemSet(_set);

            UpdateTitle();
        }



    }
}
