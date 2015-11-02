using System.Drawing;
namespace PrizeDraw
{
    partial class MainBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBox));
            this.btnGenerateStart = new System.Windows.Forms.Button();
            this.lblPrizeName = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblRankInfo = new System.Windows.Forms.Label();
            this.lblPrizeGenerate = new System.Windows.Forms.Label();
            this.btnGenerateQuit = new System.Windows.Forms.Button();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OTSM_btn_SetForm = new System.Windows.Forms.ToolStripMenuItem();
            this.OTSM_btn_CancelCurrPrize = new System.Windows.Forms.ToolStripMenuItem();
            this.OTSM_btn_None = new System.Windows.Forms.ToolStripSeparator();
            this.OTSM_btn_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrizeManage = new System.Windows.Forms.Button();
            this.btnPrizeSet = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxHOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetImg = new System.Windows.Forms.Button();
            this.tBoxImgWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxImgHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxVOffset = new System.Windows.Forms.TextBox();
            this.lblImgHeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTitleSet = new System.Windows.Forms.Button();
            this.ckBoxPhotoName = new System.Windows.Forms.CheckBox();
            this.ckBoxPrizeName = new System.Windows.Forms.CheckBox();
            this.ckBoxPrizeInfo = new System.Windows.Forms.CheckBox();
            this.ckBoxDispTitle = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMusicPrizeBackground = new System.Windows.Forms.Button();
            this.btnMusicBackground = new System.Windows.Forms.Button();
            this.btnMusicGenerate = new System.Windows.Forms.Button();
            this.cmBoxMusicPrizeBackground = new System.Windows.Forms.ComboBox();
            this.cmBoxMusicBackground = new System.Windows.Forms.ComboBox();
            this.cmBoxMusicPrizeGenerate = new System.Windows.Forms.ComboBox();
            this.ckBoxMusicBackground = new System.Windows.Forms.CheckBox();
            this.ckBoxMusicPrizeListBackGround = new System.Windows.Forms.CheckBox();
            this.ckBoxMusicPrizeGenerate = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChgClr1 = new System.Windows.Forms.Button();
            this.btnChgClr2 = new System.Windows.Forms.Button();
            this.cMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateStart
            // 
            this.btnGenerateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateStart.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerateStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateStart.Location = new System.Drawing.Point(640, 560);
            this.btnGenerateStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateStart.Name = "btnGenerateStart";
            this.btnGenerateStart.Size = new System.Drawing.Size(86, 38);
            this.btnGenerateStart.TabIndex = 4;
            this.btnGenerateStart.Text = "开 始";
            this.btnGenerateStart.UseVisualStyleBackColor = false;
            this.btnGenerateStart.Click += new System.EventHandler(this.btnPrizeGenerate_Click);
            // 
            // lblPrizeName
            // 
            this.lblPrizeName.AutoSize = true;
            this.lblPrizeName.BackColor = System.Drawing.Color.Transparent;
            this.lblPrizeName.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrizeName.ForeColor = System.Drawing.Color.Red;
            this.lblPrizeName.Location = new System.Drawing.Point(674, 228);
            this.lblPrizeName.Name = "lblPrizeName";
            this.lblPrizeName.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblPrizeName.Size = new System.Drawing.Size(142, 66);
            this.lblPrizeName.TabIndex = 6;
            this.lblPrizeName.Text = "奖项";
            this.lblPrizeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Red;
            this.lblTitle1.Location = new System.Drawing.Point(171, 56);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(192, 56);
            this.lblTitle1.TabIndex = 10;
            this.lblTitle1.Text = "主标题";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Red;
            this.lblTitle2.Location = new System.Drawing.Point(245, 133);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(164, 48);
            this.lblTitle2.TabIndex = 11;
            this.lblTitle2.Text = "副标题";
            // 
            // lblRankInfo
            // 
            this.lblRankInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblRankInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRankInfo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRankInfo.Location = new System.Drawing.Point(252, 592);
            this.lblRankInfo.Name = "lblRankInfo";
            this.lblRankInfo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblRankInfo.Size = new System.Drawing.Size(497, 38);
            this.lblRankInfo.TabIndex = 12;
            this.lblRankInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRankInfo.Visible = false;
            // 
            // lblPrizeGenerate
            // 
            this.lblPrizeGenerate.AutoSize = true;
            this.lblPrizeGenerate.BackColor = System.Drawing.Color.Transparent;
            this.lblPrizeGenerate.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrizeGenerate.ForeColor = System.Drawing.Color.Red;
            this.lblPrizeGenerate.Location = new System.Drawing.Point(674, 411);
            this.lblPrizeGenerate.Name = "lblPrizeGenerate";
            this.lblPrizeGenerate.Size = new System.Drawing.Size(79, 33);
            this.lblPrizeGenerate.TabIndex = 13;
            this.lblPrizeGenerate.Text = "姓名";
            this.lblPrizeGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateQuit
            // 
            this.btnGenerateQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateQuit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateQuit.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerateQuit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateQuit.Location = new System.Drawing.Point(730, 560);
            this.btnGenerateQuit.Name = "btnGenerateQuit";
            this.btnGenerateQuit.Size = new System.Drawing.Size(86, 38);
            this.btnGenerateQuit.TabIndex = 14;
            this.btnGenerateQuit.Text = "结 束";
            this.btnGenerateQuit.UseVisualStyleBackColor = false;
            this.btnGenerateQuit.Click += new System.EventHandler(this.btnGenerateQuit_Click);
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OTSM_btn_SetForm,
            this.OTSM_btn_CancelCurrPrize,
            this.OTSM_btn_None,
            this.OTSM_btn_Quit});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(176, 76);
            // 
            // OTSM_btn_SetForm
            // 
            this.OTSM_btn_SetForm.Name = "OTSM_btn_SetForm";
            this.OTSM_btn_SetForm.Size = new System.Drawing.Size(175, 22);
            this.OTSM_btn_SetForm.Text = "软件选项(&O)";
            this.OTSM_btn_SetForm.Click += new System.EventHandler(this.OTSM_btn_SetForm_Click);
            // 
            // OTSM_btn_CancelCurrPrize
            // 
            this.OTSM_btn_CancelCurrPrize.Name = "OTSM_btn_CancelCurrPrize";
            this.OTSM_btn_CancelCurrPrize.Size = new System.Drawing.Size(175, 22);
            this.OTSM_btn_CancelCurrPrize.Text = "取消当前中奖者(&Z)";
            this.OTSM_btn_CancelCurrPrize.Click += new System.EventHandler(this.OTSM_btn_CancelCurrPrize_Click);
            // 
            // OTSM_btn_None
            // 
            this.OTSM_btn_None.Name = "OTSM_btn_None";
            this.OTSM_btn_None.Size = new System.Drawing.Size(172, 6);
            // 
            // OTSM_btn_Quit
            // 
            this.OTSM_btn_Quit.Name = "OTSM_btn_Quit";
            this.OTSM_btn_Quit.Size = new System.Drawing.Size(175, 22);
            this.OTSM_btn_Quit.Text = "退出(&X)";
            this.OTSM_btn_Quit.Click += new System.EventHandler(this.OTSM_btn_Quit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 652);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(5, 18);
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 632);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrizeManage);
            this.tabPage1.Controls.Add(this.btnPrizeSet);
            this.tabPage1.Controls.Add(this.btnInit);
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(232, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系统";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrizeManage
            // 
            this.btnPrizeManage.Location = new System.Drawing.Point(18, 106);
            this.btnPrizeManage.Name = "btnPrizeManage";
            this.btnPrizeManage.Size = new System.Drawing.Size(186, 23);
            this.btnPrizeManage.TabIndex = 4;
            this.btnPrizeManage.Text = "获奖名单管理";
            this.btnPrizeManage.UseVisualStyleBackColor = true;
            this.btnPrizeManage.Click += new System.EventHandler(this.btnPrizeManage_Click);
            // 
            // btnPrizeSet
            // 
            this.btnPrizeSet.Location = new System.Drawing.Point(18, 64);
            this.btnPrizeSet.Name = "btnPrizeSet";
            this.btnPrizeSet.Size = new System.Drawing.Size(186, 23);
            this.btnPrizeSet.TabIndex = 3;
            this.btnPrizeSet.Text = "奖项设置";
            this.btnPrizeSet.UseVisualStyleBackColor = true;
            this.btnPrizeSet.Click += new System.EventHandler(this.btnPrizeSet_Click);
            // 
            // btnInit
            // 
            this.btnInit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInit.Location = new System.Drawing.Point(3, 580);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(226, 23);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "恢复默认";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(18, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(186, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "导入照片信息";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnTitleSet);
            this.tabPage2.Controls.Add(this.ckBoxPhotoName);
            this.tabPage2.Controls.Add(this.ckBoxPrizeName);
            this.tabPage2.Controls.Add(this.ckBoxPrizeInfo);
            this.tabPage2.Controls.Add(this.ckBoxDispTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(232, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxHOffset);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSetImg);
            this.groupBox2.Controls.Add(this.tBoxImgWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tBoxImgHeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tBoxVOffset);
            this.groupBox2.Controls.Add(this.lblImgHeight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(16, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 152);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "照片大小位置";
            // 
            // tBoxHOffset
            // 
            this.tBoxHOffset.Location = new System.Drawing.Point(66, 82);
            this.tBoxHOffset.Name = "tBoxHOffset";
            this.tBoxHOffset.Size = new System.Drawing.Size(36, 21);
            this.tBoxHOffset.TabIndex = 8;
            this.tBoxHOffset.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "位置偏移";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "照片大小";
            // 
            // btnSetImg
            // 
            this.btnSetImg.Location = new System.Drawing.Point(120, 118);
            this.btnSetImg.Name = "btnSetImg";
            this.btnSetImg.Size = new System.Drawing.Size(38, 23);
            this.btnSetImg.TabIndex = 14;
            this.btnSetImg.Text = "确定";
            this.btnSetImg.UseVisualStyleBackColor = true;
            this.btnSetImg.Click += new System.EventHandler(this.btnSetImg_Click);
            // 
            // tBoxImgWidth
            // 
            this.tBoxImgWidth.Location = new System.Drawing.Point(66, 37);
            this.tBoxImgWidth.Name = "tBoxImgWidth";
            this.tBoxImgWidth.Size = new System.Drawing.Size(36, 21);
            this.tBoxImgWidth.TabIndex = 8;
            this.tBoxImgWidth.Text = "400";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // tBoxImgHeight
            // 
            this.tBoxImgHeight.Location = new System.Drawing.Point(120, 37);
            this.tBoxImgHeight.Name = "tBoxImgHeight";
            this.tBoxImgHeight.Size = new System.Drawing.Size(41, 21);
            this.tBoxImgHeight.TabIndex = 10;
            this.tBoxImgHeight.Text = "400";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "重直";
            // 
            // tBoxVOffset
            // 
            this.tBoxVOffset.Location = new System.Drawing.Point(120, 82);
            this.tBoxVOffset.Name = "tBoxVOffset";
            this.tBoxVOffset.Size = new System.Drawing.Size(41, 21);
            this.tBoxVOffset.TabIndex = 10;
            this.tBoxVOffset.Text = "0";
            // 
            // lblImgHeight
            // 
            this.lblImgHeight.AutoSize = true;
            this.lblImgHeight.Location = new System.Drawing.Point(134, 22);
            this.lblImgHeight.Name = "lblImgHeight";
            this.lblImgHeight.Size = new System.Drawing.Size(17, 12);
            this.lblImgHeight.TabIndex = 12;
            this.lblImgHeight.Text = "高";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "宽";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "水平";
            // 
            // btnTitleSet
            // 
            this.btnTitleSet.Location = new System.Drawing.Point(16, 17);
            this.btnTitleSet.Name = "btnTitleSet";
            this.btnTitleSet.Size = new System.Drawing.Size(196, 23);
            this.btnTitleSet.TabIndex = 7;
            this.btnTitleSet.Text = "修改标题文字";
            this.btnTitleSet.UseVisualStyleBackColor = true;
            this.btnTitleSet.Click += new System.EventHandler(this.btnTitleSet_Click);
            // 
            // ckBoxPhotoName
            // 
            this.ckBoxPhotoName.AutoSize = true;
            this.ckBoxPhotoName.Checked = true;
            this.ckBoxPhotoName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxPhotoName.Location = new System.Drawing.Point(16, 148);
            this.ckBoxPhotoName.Name = "ckBoxPhotoName";
            this.ckBoxPhotoName.Size = new System.Drawing.Size(108, 16);
            this.ckBoxPhotoName.TabIndex = 5;
            this.ckBoxPhotoName.Text = "显示照片文件名";
            this.ckBoxPhotoName.UseVisualStyleBackColor = true;
            this.ckBoxPhotoName.CheckedChanged += new System.EventHandler(this.ckBoxPhotoName_CheckedChanged);
            // 
            // ckBoxPrizeName
            // 
            this.ckBoxPrizeName.AutoSize = true;
            this.ckBoxPrizeName.Checked = true;
            this.ckBoxPrizeName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxPrizeName.Location = new System.Drawing.Point(16, 82);
            this.ckBoxPrizeName.Name = "ckBoxPrizeName";
            this.ckBoxPrizeName.Size = new System.Drawing.Size(120, 16);
            this.ckBoxPrizeName.TabIndex = 6;
            this.ckBoxPrizeName.Text = "显示当前奖项内容";
            this.ckBoxPrizeName.UseVisualStyleBackColor = true;
            this.ckBoxPrizeName.CheckedChanged += new System.EventHandler(this.ckBoxPrizeName_CheckedChanged);
            // 
            // ckBoxPrizeInfo
            // 
            this.ckBoxPrizeInfo.AutoSize = true;
            this.ckBoxPrizeInfo.Location = new System.Drawing.Point(16, 115);
            this.ckBoxPrizeInfo.Name = "ckBoxPrizeInfo";
            this.ckBoxPrizeInfo.Size = new System.Drawing.Size(120, 16);
            this.ckBoxPrizeInfo.TabIndex = 4;
            this.ckBoxPrizeInfo.Text = "显示当前奖项提示";
            this.ckBoxPrizeInfo.UseVisualStyleBackColor = true;
            this.ckBoxPrizeInfo.CheckedChanged += new System.EventHandler(this.ckBoxPrizeInfo_CheckedChanged);
            // 
            // ckBoxDispTitle
            // 
            this.ckBoxDispTitle.AutoSize = true;
            this.ckBoxDispTitle.Checked = true;
            this.ckBoxDispTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxDispTitle.Location = new System.Drawing.Point(16, 49);
            this.ckBoxDispTitle.Name = "ckBoxDispTitle";
            this.ckBoxDispTitle.Size = new System.Drawing.Size(72, 16);
            this.ckBoxDispTitle.TabIndex = 3;
            this.ckBoxDispTitle.Text = "显示标题";
            this.ckBoxDispTitle.UseVisualStyleBackColor = true;
            this.ckBoxDispTitle.CheckedChanged += new System.EventHandler(this.ckBoxDispTitle_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMusicPrizeBackground);
            this.tabPage3.Controls.Add(this.btnMusicBackground);
            this.tabPage3.Controls.Add(this.btnMusicGenerate);
            this.tabPage3.Controls.Add(this.cmBoxMusicPrizeBackground);
            this.tabPage3.Controls.Add(this.cmBoxMusicBackground);
            this.tabPage3.Controls.Add(this.cmBoxMusicPrizeGenerate);
            this.tabPage3.Controls.Add(this.ckBoxMusicBackground);
            this.tabPage3.Controls.Add(this.ckBoxMusicPrizeListBackGround);
            this.tabPage3.Controls.Add(this.ckBoxMusicPrizeGenerate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 606);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "音乐";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMusicPrizeBackground
            // 
            this.btnMusicPrizeBackground.Location = new System.Drawing.Point(186, 169);
            this.btnMusicPrizeBackground.Name = "btnMusicPrizeBackground";
            this.btnMusicPrizeBackground.Size = new System.Drawing.Size(43, 23);
            this.btnMusicPrizeBackground.TabIndex = 13;
            this.btnMusicPrizeBackground.Text = "试听";
            this.btnMusicPrizeBackground.UseVisualStyleBackColor = true;
            this.btnMusicPrizeBackground.Click += new System.EventHandler(this.btnMusicPrizeBackground_Click);
            // 
            // btnMusicBackground
            // 
            this.btnMusicBackground.Location = new System.Drawing.Point(186, 104);
            this.btnMusicBackground.Name = "btnMusicBackground";
            this.btnMusicBackground.Size = new System.Drawing.Size(43, 23);
            this.btnMusicBackground.TabIndex = 12;
            this.btnMusicBackground.Text = "试听";
            this.btnMusicBackground.UseVisualStyleBackColor = true;
            this.btnMusicBackground.Click += new System.EventHandler(this.btnMusicBackground_Click);
            // 
            // btnMusicGenerate
            // 
            this.btnMusicGenerate.Location = new System.Drawing.Point(186, 39);
            this.btnMusicGenerate.Name = "btnMusicGenerate";
            this.btnMusicGenerate.Size = new System.Drawing.Size(43, 23);
            this.btnMusicGenerate.TabIndex = 11;
            this.btnMusicGenerate.Text = "试听";
            this.btnMusicGenerate.UseVisualStyleBackColor = true;
            this.btnMusicGenerate.Click += new System.EventHandler(this.btnMusicGenerate_Click);
            // 
            // cmBoxMusicPrizeBackground
            // 
            this.cmBoxMusicPrizeBackground.FormattingEnabled = true;
            this.cmBoxMusicPrizeBackground.Location = new System.Drawing.Point(17, 172);
            this.cmBoxMusicPrizeBackground.Name = "cmBoxMusicPrizeBackground";
            this.cmBoxMusicPrizeBackground.Size = new System.Drawing.Size(163, 20);
            this.cmBoxMusicPrizeBackground.TabIndex = 10;
            this.cmBoxMusicPrizeBackground.SelectedIndexChanged += new System.EventHandler(this.cmBoxMusicPrizeBackground_SelectedIndexChanged);
            // 
            // cmBoxMusicBackground
            // 
            this.cmBoxMusicBackground.FormattingEnabled = true;
            this.cmBoxMusicBackground.Location = new System.Drawing.Point(17, 107);
            this.cmBoxMusicBackground.Name = "cmBoxMusicBackground";
            this.cmBoxMusicBackground.Size = new System.Drawing.Size(163, 20);
            this.cmBoxMusicBackground.TabIndex = 10;
            this.cmBoxMusicBackground.SelectedIndexChanged += new System.EventHandler(this.cmBoxMusicBackground_SelectedIndexChanged);
            // 
            // cmBoxMusicPrizeGenerate
            // 
            this.cmBoxMusicPrizeGenerate.FormattingEnabled = true;
            this.cmBoxMusicPrizeGenerate.Location = new System.Drawing.Point(17, 42);
            this.cmBoxMusicPrizeGenerate.Name = "cmBoxMusicPrizeGenerate";
            this.cmBoxMusicPrizeGenerate.Size = new System.Drawing.Size(163, 20);
            this.cmBoxMusicPrizeGenerate.TabIndex = 10;
            this.cmBoxMusicPrizeGenerate.SelectedIndexChanged += new System.EventHandler(this.cmBoxMusicPrizeGenerate_SelectedIndexChanged);
            // 
            // ckBoxMusicBackground
            // 
            this.ckBoxMusicBackground.AutoSize = true;
            this.ckBoxMusicBackground.Checked = true;
            this.ckBoxMusicBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxMusicBackground.Location = new System.Drawing.Point(17, 85);
            this.ckBoxMusicBackground.Name = "ckBoxMusicBackground";
            this.ckBoxMusicBackground.Size = new System.Drawing.Size(72, 16);
            this.ckBoxMusicBackground.TabIndex = 9;
            this.ckBoxMusicBackground.Text = "背景音乐";
            this.ckBoxMusicBackground.UseVisualStyleBackColor = true;
            this.ckBoxMusicBackground.CheckedChanged += new System.EventHandler(this.ckBoxMusicBackground_CheckedChanged);
            // 
            // ckBoxMusicPrizeListBackGround
            // 
            this.ckBoxMusicPrizeListBackGround.AutoSize = true;
            this.ckBoxMusicPrizeListBackGround.Checked = true;
            this.ckBoxMusicPrizeListBackGround.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxMusicPrizeListBackGround.Location = new System.Drawing.Point(17, 150);
            this.ckBoxMusicPrizeListBackGround.Name = "ckBoxMusicPrizeListBackGround";
            this.ckBoxMusicPrizeListBackGround.Size = new System.Drawing.Size(120, 16);
            this.ckBoxMusicPrizeListBackGround.TabIndex = 8;
            this.ckBoxMusicPrizeListBackGround.Text = "中奖名单背景音乐";
            this.ckBoxMusicPrizeListBackGround.UseVisualStyleBackColor = true;
            this.ckBoxMusicPrizeListBackGround.CheckedChanged += new System.EventHandler(this.ckBoxMusicPrizeListBackGround_CheckedChanged);
            // 
            // ckBoxMusicPrizeGenerate
            // 
            this.ckBoxMusicPrizeGenerate.AutoSize = true;
            this.ckBoxMusicPrizeGenerate.Checked = true;
            this.ckBoxMusicPrizeGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxMusicPrizeGenerate.Location = new System.Drawing.Point(17, 20);
            this.ckBoxMusicPrizeGenerate.Name = "ckBoxMusicPrizeGenerate";
            this.ckBoxMusicPrizeGenerate.Size = new System.Drawing.Size(72, 16);
            this.ckBoxMusicPrizeGenerate.TabIndex = 7;
            this.ckBoxMusicPrizeGenerate.Text = "中奖音乐";
            this.ckBoxMusicPrizeGenerate.UseVisualStyleBackColor = true;
            this.ckBoxMusicPrizeGenerate.CheckedChanged += new System.EventHandler(this.ckBoxMusicPrizeGenerate_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(232, 606);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "帮助";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "作者：thetaZhou";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "电话：13162046678";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(171, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChgClr2);
            this.groupBox3.Controls.Add(this.btnChgClr1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(16, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 105);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文字颜色设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "奖项名颜色";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "照片名颜色";
            // 
            // btnChgClr1
            // 
            this.btnChgClr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChgClr1.Location = new System.Drawing.Point(82, 27);
            this.btnChgClr1.Name = "btnChgClr1";
            this.btnChgClr1.Size = new System.Drawing.Size(38, 23);
            this.btnChgClr1.TabIndex = 15;
            this.btnChgClr1.UseVisualStyleBackColor = false;
            this.btnChgClr1.Click += new System.EventHandler(this.btnChgClr1_Click);
            // 
            // btnChgClr2
            // 
            this.btnChgClr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChgClr2.Location = new System.Drawing.Point(81, 64);
            this.btnChgClr2.Name = "btnChgClr2";
            this.btnChgClr2.Size = new System.Drawing.Size(38, 23);
            this.btnChgClr2.TabIndex = 15;
            this.btnChgClr2.UseVisualStyleBackColor = false;
            this.btnChgClr2.Click += new System.EventHandler(this.btnChgClr2_Click);
            // 
            // MainBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 652);
            this.ContextMenuStrip = this.cMenu;
            this.Controls.Add(this.lblPrizeGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateQuit);
            this.Controls.Add(this.btnGenerateStart);
            this.Controls.Add(this.lblRankInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblPrizeName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainBox_Load);
            this.cMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateStart;
        private System.Windows.Forms.Label lblPrizeName;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblRankInfo;
        private System.Windows.Forms.Label lblPrizeGenerate;
        private System.Windows.Forms.Button btnGenerateQuit;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem OTSM_btn_SetForm;
        private System.Windows.Forms.ToolStripMenuItem OTSM_btn_CancelCurrPrize;
        private System.Windows.Forms.ToolStripSeparator OTSM_btn_None;
        private System.Windows.Forms.ToolStripMenuItem OTSM_btn_Quit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPrizeManage;
        private System.Windows.Forms.Button btnPrizeSet;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSetImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImgHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxImgHeight;
        private System.Windows.Forms.TextBox tBoxImgWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTitleSet;
        private System.Windows.Forms.CheckBox ckBoxPhotoName;
        private System.Windows.Forms.CheckBox ckBoxPrizeName;
        private System.Windows.Forms.CheckBox ckBoxPrizeInfo;
        private System.Windows.Forms.CheckBox ckBoxDispTitle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMusicPrizeBackground;
        private System.Windows.Forms.Button btnMusicBackground;
        private System.Windows.Forms.Button btnMusicGenerate;
        private System.Windows.Forms.ComboBox cmBoxMusicPrizeBackground;
        private System.Windows.Forms.ComboBox cmBoxMusicBackground;
        private System.Windows.Forms.ComboBox cmBoxMusicPrizeGenerate;
        private System.Windows.Forms.CheckBox ckBoxMusicBackground;
        private System.Windows.Forms.CheckBox ckBoxMusicPrizeListBackGround;
        private System.Windows.Forms.CheckBox ckBoxMusicPrizeGenerate;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBoxHOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxVOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChgClr2;
        private System.Windows.Forms.Button btnChgClr1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}