namespace InventoryPosSystem.View
{
    partial class frmProductView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductView));
            guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dgvid1 = new DataGridViewTextBoxColumn();
            dgvName1 = new DataGridViewTextBoxColumn();
            dgvcatID = new DataGridViewTextBoxColumn();
            dgvCategory = new DataGridViewTextBoxColumn();
            dgvbarcode = new DataGridViewTextBoxColumn();
            dgvcost = new DataGridViewTextBoxColumn();
            dgvSale = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2Separator1);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(1236, 171);
            guna2Panel1.Controls.SetChildIndex(label1, 0);
            guna2Panel1.Controls.SetChildIndex(label2, 0);
            guna2Panel1.Controls.SetChildIndex(Addbtn, 0);
            guna2Panel1.Controls.SetChildIndex(Searchtxt, 0);
            guna2Panel1.Controls.SetChildIndex(guna2Separator1, 0);
            // 
            // label1
            // 
            label1.Location = new Point(99, 96);
            label1.Size = new Size(137, 32);
            label1.Text = "Ürün Listesi";
            // 
            // Searchtxt
            // 
            Searchtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Searchtxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Searchtxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Searchtxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Searchtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Searchtxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Searchtxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Searchtxt.Location = new Point(99, 22);
            Searchtxt.PlaceholderText = "Buradan Ara";
            Searchtxt.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Searchtxt.Size = new Size(418, 50);
            Searchtxt.TextChanged += Searchtxt_TextChanged;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Addbtn.DialogResult = DialogResult.None;
            Addbtn.DisabledState.BorderColor = Color.DarkGray;
            Addbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Addbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Addbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Addbtn.Location = new Point(1017, 88);
            Addbtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Addbtn.Size = new Size(121, 40);
            Addbtn.Text = "Ekle";
            Addbtn.Click += Addbtn_Click;
            // 
            // label2
            // 
            label2.Location = new Point(292, 49);
            label2.Size = new Size(36, 23);
            label2.Text = "Ara";
            label2.Visible = false;
            // 
            // guna2DataGridView2
            // 
            guna2DataGridView2.AllowUserToAddRows = false;
            guna2DataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 76, 121);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView2.ColumnHeadersHeight = 50;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dgvid1, dgvName1, dgvcatID, dgvCategory, dgvbarcode, dgvcost, dgvSale, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(99, 193);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.ReadOnly = true;
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.RowTemplate.Height = 40;
            guna2DataGridView2.Size = new Size(1073, 418);
            guna2DataGridView2.TabIndex = 5;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(21, 76, 121);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView2.ThemeStyle.ReadOnly = true;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 40;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.CellClick += guna2DataGridView2_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 70F;
            dataGridViewTextBoxColumn1.HeaderText = "Sr #";
            dataGridViewTextBoxColumn1.MinimumWidth = 70;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvid1
            // 
            dgvid1.HeaderText = "id";
            dgvid1.MinimumWidth = 6;
            dgvid1.Name = "dgvid1";
            dgvid1.ReadOnly = true;
            // 
            // dgvName1
            // 
            dgvName1.FillWeight = 79.37956F;
            dgvName1.HeaderText = "İsim";
            dgvName1.MinimumWidth = 6;
            dgvName1.Name = "dgvName1";
            dgvName1.ReadOnly = true;
            // 
            // dgvcatID
            // 
            dgvcatID.HeaderText = "Kategori ID";
            dgvcatID.MinimumWidth = 6;
            dgvcatID.Name = "dgvcatID";
            dgvcatID.ReadOnly = true;
            // 
            // dgvCategory
            // 
            dgvCategory.HeaderText = "Kategori";
            dgvCategory.MinimumWidth = 6;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            // 
            // dgvbarcode
            // 
            dgvbarcode.FillWeight = 79.37956F;
            dgvbarcode.HeaderText = "Barkod";
            dgvbarcode.MinimumWidth = 6;
            dgvbarcode.Name = "dgvbarcode";
            dgvbarcode.ReadOnly = true;
            // 
            // dgvcost
            // 
            dgvcost.FillWeight = 79.37956F;
            dgvcost.HeaderText = "Alış Fiyatı";
            dgvcost.MinimumWidth = 6;
            dgvcost.Name = "dgvcost";
            dgvcost.ReadOnly = true;
            // 
            // dgvSale
            // 
            dgvSale.HeaderText = "Satış Fiyatı";
            dgvSale.MinimumWidth = 6;
            dgvSale.Name = "dgvSale";
            dgvSale.ReadOnly = true;
            // 
            // dgvEdit
            // 
            dgvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEdit.FillWeight = 50F;
            dgvEdit.HeaderText = "";
            dgvEdit.Image = (Image)resources.GetObject("dgvEdit.Image");
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEdit.MinimumWidth = 50;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Width = 50;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 50F;
            dgvDel.HeaderText = "";
            dgvDel.Image = (Image)resources.GetObject("dgvDel.Image");
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 50;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 50;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(99, 145);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1073, 23);
            guna2Separator1.TabIndex = 6;
            // 
            // frmProductView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 632);
            Controls.Add(guna2DataGridView2);
            Name = "frmProductView";
            Text = "frmProductView";
            Load += frmProductView_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2DataGridView2, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dgvid1;
        private DataGridViewTextBoxColumn dgvName1;
        private DataGridViewTextBoxColumn dgvcatID;
        private DataGridViewTextBoxColumn dgvCategory;
        private DataGridViewTextBoxColumn dgvbarcode;
        private DataGridViewTextBoxColumn dgvcost;
        private DataGridViewTextBoxColumn dgvSale;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}