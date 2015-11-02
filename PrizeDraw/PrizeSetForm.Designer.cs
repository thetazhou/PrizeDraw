namespace PrizeDraw
{
    partial class PrizeSetForm
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
            this.dgvPrizeSet = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrizeSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrizeSet
            // 
            this.dgvPrizeSet.AllowUserToAddRows = false;
            this.dgvPrizeSet.AllowUserToDeleteRows = false;
            this.dgvPrizeSet.AllowUserToResizeRows = false;
            this.dgvPrizeSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrizeSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankName,
            this.PersonName,
            this.RankId,
            this.PersonId});
            this.dgvPrizeSet.Location = new System.Drawing.Point(12, 12);
            this.dgvPrizeSet.Name = "dgvPrizeSet";
            this.dgvPrizeSet.ReadOnly = true;
            this.dgvPrizeSet.RowTemplate.Height = 23;
            this.dgvPrizeSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrizeSet.Size = new System.Drawing.Size(270, 437);
            this.dgvPrizeSet.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 455);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除该行";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关 闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RankName
            // 
            this.RankName.HeaderText = "奖项";
            this.RankName.Name = "RankName";
            this.RankName.ReadOnly = true;
            this.RankName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "姓名";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RankId
            // 
            this.RankId.HeaderText = "RankId";
            this.RankId.Name = "RankId";
            this.RankId.ReadOnly = true;
            this.RankId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RankId.Visible = false;
            // 
            // PersonId
            // 
            this.PersonId.HeaderText = "PersonId";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonId.Visible = false;
            // 
            // PrizeSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 486);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvPrizeSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrizeSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获奖名单";
            this.Load += new System.EventHandler(this.PrizeSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrizeSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrizeSet;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
    }
}