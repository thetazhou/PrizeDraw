namespace PrizeDraw
{
    partial class TitleSetForm
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
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.txtBoxTitle1 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(19, 23);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(53, 12);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "主标题：";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(21, 66);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(53, 12);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "副标题：";
            // 
            // txtBoxTitle1
            // 
            this.txtBoxTitle1.Location = new System.Drawing.Point(66, 20);
            this.txtBoxTitle1.Name = "txtBoxTitle1";
            this.txtBoxTitle1.Size = new System.Drawing.Size(242, 21);
            this.txtBoxTitle1.TabIndex = 2;
            // 
            // txtBoxTitle2
            // 
            this.txtBoxTitle2.Location = new System.Drawing.Point(66, 63);
            this.txtBoxTitle2.Name = "txtBoxTitle2";
            this.txtBoxTitle2.Size = new System.Drawing.Size(242, 21);
            this.txtBoxTitle2.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(78, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.txtBoxTitle1);
            this.gBox.Controls.Add(this.lblTitle1);
            this.gBox.Controls.Add(this.txtBoxTitle2);
            this.gBox.Controls.Add(this.lblTitle2);
            this.gBox.Location = new System.Drawing.Point(12, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(329, 100);
            this.gBox.TabIndex = 4;
            this.gBox.TabStop = false;
            // 
            // TitleSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TitleSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "标题设置";
            this.Load += new System.EventHandler(this.TitleSetForm_Load);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtBoxTitle1;
        private System.Windows.Forms.TextBox txtBoxTitle2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gBox;
    }
}