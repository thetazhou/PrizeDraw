namespace PrizeDraw
{
    partial class PersonSetForm
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
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AllowUserToResizeRows = false;
            this.dgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.PersonName,
            this.PersonPhoto});
            this.dgvPerson.Location = new System.Drawing.Point(12, 12);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowTemplate.Height = 23;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(323, 415);
            this.dgvPerson.TabIndex = 0;
            // 
            // PersonId
            // 
            this.PersonId.HeaderText = "Id";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonId.Width = 60;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "姓名";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonName.Width = 190;
            // 
            // PersonPhoto
            // 
            this.PersonPhoto.HeaderText = "照片名";
            this.PersonPhoto.Name = "PersonPhoto";
            this.PersonPhoto.ReadOnly = true;
            this.PersonPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonPhoto.Visible = false;
            this.PersonPhoto.Width = 190;
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(12, 441);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(75, 23);
            this.btnDelRow.TabIndex = 1;
            this.btnDelRow.Text = "删除该行";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 441);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关 闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(178, 441);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "导 入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(12, 425);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(323, 10);
            this.pgBar.TabIndex = 3;
            // 
            // PersonSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 476);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelRow);
            this.Controls.Add(this.dgvPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖名单管理";
            this.Load += new System.EventHandler(this.PersonSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonPhoto;
        private System.Windows.Forms.ProgressBar pgBar;
    }
}