namespace InventoryPosSystem
{
    partial class SampleView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            Addbtn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(Searchtxt);
            guna2Panel1.Controls.Add(Addbtn);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1270, 175);
            guna2Panel1.TabIndex = 0;
            // 
            // Searchtxt
            // 
            Searchtxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Searchtxt.AutoRoundedCorners = true;
            Searchtxt.CustomizableEdges = customizableEdges1;
            Searchtxt.DefaultText = "";
            Searchtxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Searchtxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Searchtxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Searchtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Searchtxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Searchtxt.Font = new Font("Segoe UI", 9F);
            Searchtxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Searchtxt.IconLeft = (Image)resources.GetObject("Searchtxt.IconLeft");
            Searchtxt.IconLeftOffset = new Point(10, 0);
            Searchtxt.IconLeftSize = new Size(30, 30);
            Searchtxt.Location = new Point(853, 101);
            Searchtxt.Margin = new Padding(3, 4, 3, 4);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.PlaceholderText = "Search Here";
            Searchtxt.SelectedText = "";
            Searchtxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Searchtxt.Size = new Size(340, 50);
            Searchtxt.TabIndex = 3;
            Searchtxt.TextOffset = new Point(10, 0);
            Searchtxt.TextChanged += Searchtxt_TextChanged;
            // 
            // Addbtn
            // 
            Addbtn.Animated = true;
            Addbtn.AutoRoundedCorners = true;
            Addbtn.CustomizableEdges = customizableEdges3;
            Addbtn.DisabledState.BorderColor = Color.DarkGray;
            Addbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Addbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Addbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Addbtn.FillColor = Color.FromArgb(21, 76, 121);
            Addbtn.Font = new Font("Segoe UI", 9F);
            Addbtn.ForeColor = Color.White;
            Addbtn.Image = (Image)resources.GetObject("Addbtn.Image");
            Addbtn.Location = new Point(117, 95);
            Addbtn.Name = "Addbtn";
            Addbtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Addbtn.Size = new Size(131, 56);
            Addbtn.TabIndex = 2;
            Addbtn.Text = "Add New ";
            Addbtn.TextOffset = new Point(2, 0);
            Addbtn.Click += Addbtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(873, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(99, 48);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Sample Header";
            // 
            // SampleView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 711);
            Controls.Add(guna2Panel1);
            Name = "SampleView";
            Text = "SampleView";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Label label1;
        public Guna.UI2.WinForms.Guna2TextBox Searchtxt;
        public Guna.UI2.WinForms.Guna2Button Addbtn;
        public Label label2;
    }
}