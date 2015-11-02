namespace PrizeDraw
{
    partial class RankSetForm
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
            this.dgvRankSet = new System.Windows.Forms.DataGridView();
            this.btnUpdateRanSet = new System.Windows.Forms.Button();
            this.btnCancelRankSet = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.RankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankPrize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRankSet
            // 
            this.dgvRankSet.AllowUserToDeleteRows = false;
            this.dgvRankSet.AllowUserToResizeRows = false;
            this.dgvRankSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRankSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankId,
            this.RankName,
            this.RankMax,
            this.RankPrize});
            this.dgvRankSet.Location = new System.Drawing.Point(12, 12);
            this.dgvRankSet.MultiSelect = false;
            this.dgvRankSet.Name = "dgvRankSet";
            this.dgvRankSet.RowTemplate.Height = 23;
            this.dgvRankSet.Size = new System.Drawing.Size(393, 206);
            this.dgvRankSet.TabIndex = 0;
            // 
            // btnUpdateRanSet
            // 
            this.btnUpdateRanSet.Location = new System.Drawing.Point(249, 233);
            this.btnUpdateRanSet.Name = "btnUpdateRanSet";
            this.btnUpdateRanSet.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRanSet.TabIndex = 1;
            this.btnUpdateRanSet.Text = "保 存";
            this.btnUpdateRanSet.UseVisualStyleBackColor = true;
            this.btnUpdateRanSet.Click += new System.EventHandler(this.btnUpdateRanSet_Click);
            // 
            // btnCancelRankSet
            // 
            this.btnCancelRankSet.Location = new System.Drawing.Point(330, 233);
            this.btnCancelRankSet.Name = "btnCancelRankSet";
            this.btnCancelRankSet.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRankSet.TabIndex = 2;
            this.btnCancelRankSet.Text = "取 消";
            this.btnCancelRankSet.UseVisualStyleBackColor = true;
            this.btnCancelRankSet.Click += new System.EventHandler(this.btnCancelRankSet_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(102, 238);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(29, 12);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Test";
            this.lblMsg.Visible = false;
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(12, 233);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(75, 23);
            this.btnDelRow.TabIndex = 5;
            this.btnDelRow.Text = "删除该行";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // RankId
            // 
            this.RankId.HeaderText = "序号";
            this.RankId.Name = "RankId";
            this.RankId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RankId.Visible = false;
            // 
            // RankName
            // 
            this.RankName.HeaderText = "奖项名称";
            this.RankName.MaxInputLength = 30;
            this.RankName.Name = "RankName";
            this.RankName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RankMax
            // 
            this.RankMax.HeaderText = "人数上限";
            this.RankMax.MaxInputLength = 4;
            this.RankMax.Name = "RankMax";
            this.RankMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RankMax.Width = 90;
            // 
            // RankPrize
            // 
            this.RankPrize.HeaderText = "奖品";
            this.RankPrize.MaxInputLength = 100;
            this.RankPrize.Name = "RankPrize";
            this.RankPrize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RankPrize.Width = 160;
            // 
            // RankSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 272);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCancelRankSet);
            this.Controls.Add(this.btnUpdateRanSet);
            this.Controls.Add(this.btnDelRow);
            this.Controls.Add(this.dgvRankSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RankSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奖项设置";
            this.Load += new System.EventHandler(this.RankSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRankSet;
        private System.Windows.Forms.Button btnUpdateRanSet;
        private System.Windows.Forms.Button btnCancelRankSet;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankPrize;
    }
}