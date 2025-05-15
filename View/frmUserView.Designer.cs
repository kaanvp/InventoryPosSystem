namespace InventoryPosSystem.View
{
    partial class frmUserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserView));
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvSr = new DataGridViewTextBoxColumn();
            dgvid = new DataGridViewTextBoxColumn();
            dgvname = new DataGridViewTextBoxColumn();
            dgvuserName = new DataGridViewTextBoxColumn();
            dgvpass = new DataGridViewTextBoxColumn();
            dgvphone = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2Separator1);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(1311, 175);
            guna2Panel1.Controls.SetChildIndex(label1, 0);
            guna2Panel1.Controls.SetChildIndex(label2, 0);
            guna2Panel1.Controls.SetChildIndex(Addbtn, 0);
            guna2Panel1.Controls.SetChildIndex(Searchtxt, 0);
            guna2Panel1.Controls.SetChildIndex(guna2Separator1, 0);
            // 
            // label1
            // 
            label1.Location = new Point(99, 102);
            label1.Size = new Size(174, 32);
            label1.Text = "Kullanıcı Ekranı";
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
            Searchtxt.Location = new Point(99, 37);
            Searchtxt.PlaceholderText = "Burdan Ara";
            Searchtxt.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Searchtxt.Size = new Size(394, 50);
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Addbtn.DialogResult = DialogResult.None;
            Addbtn.DisabledState.BorderColor = Color.DarkGray;
            Addbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Addbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Addbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Addbtn.Location = new Point(1134, 102);
            Addbtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Addbtn.Size = new Size(131, 41);
            Addbtn.Text = "Ekle";
            Addbtn.Click += Addbtn_Click;
            // 
            // label2
            // 
            label2.Location = new Point(388, 64);
            label2.Size = new Size(60, 23);
            label2.Text = "Arama";
            label2.Visible = false;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Parent = this;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 76, 121);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 50;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvSr, dgvid, dgvname, dgvuserName, dgvpass, dgvphone, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(99, 198);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.Size = new Size(1166, 627);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(21, 76, 121);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            // 
            // dgvSr
            // 
            dgvSr.FillWeight = 70F;
            dgvSr.HeaderText = "Sr #";
            dgvSr.MinimumWidth = 70;
            dgvSr.Name = "dgvSr";
            dgvSr.ReadOnly = true;
            // 
            // dgvid
            // 
            dgvid.HeaderText = "id";
            dgvid.MinimumWidth = 6;
            dgvid.Name = "dgvid";
            dgvid.ReadOnly = true;
            // 
            // dgvname
            // 
            dgvname.FillWeight = 79.37956F;
            dgvname.HeaderText = "İsim";
            dgvname.MinimumWidth = 6;
            dgvname.Name = "dgvname";
            dgvname.ReadOnly = true;
            // 
            // dgvuserName
            // 
            dgvuserName.FillWeight = 79.37956F;
            dgvuserName.HeaderText = "Kullanıcı Adı";
            dgvuserName.MinimumWidth = 6;
            dgvuserName.Name = "dgvuserName";
            dgvuserName.ReadOnly = true;
            // 
            // dgvpass
            // 
            dgvpass.FillWeight = 79.37956F;
            dgvpass.HeaderText = "Şifre";
            dgvpass.MinimumWidth = 6;
            dgvpass.Name = "dgvpass";
            dgvpass.ReadOnly = true;
            // 
            // dgvphone
            // 
            dgvphone.FillWeight = 79.37956F;
            dgvphone.HeaderText = "Telefon";
            dgvphone.MinimumWidth = 6;
            dgvphone.Name = "dgvphone";
            dgvphone.ReadOnly = true;
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
            guna2Separator1.Location = new Point(99, 149);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1166, 23);
            guna2Separator1.TabIndex = 5;
            // 
            // frmUserView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 869);
            Controls.Add(guna2DataGridView1);
            Name = "frmUserView";
            Text = "frmUserView";
            Load += frmUserView_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2DataGridView1, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn dgvSr;
        private DataGridViewTextBoxColumn dgvid;
        private DataGridViewTextBoxColumn dgvname;
        private DataGridViewTextBoxColumn dgvuserName;
        private DataGridViewTextBoxColumn dgvpass;
        private DataGridViewTextBoxColumn dgvphone;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}