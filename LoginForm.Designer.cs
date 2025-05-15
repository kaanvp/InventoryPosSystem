namespace InventoryPosSystem
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            Passtxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label3 = new Label();
            Usertxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ımageList1 = new ImageList(components);
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(39, 24);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(512, 512);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(736, 136);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 1;
            label1.Text = "Hoşgeldiniz";
            // 
            // Passtxt
            // 
            Passtxt.AutoRoundedCorners = true;
            Passtxt.CustomizableEdges = customizableEdges3;
            Passtxt.DefaultText = "";
            Passtxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Passtxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Passtxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Passtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Passtxt.FocusedState.BorderColor = Color.FromArgb(21, 76, 121);
            Passtxt.Font = new Font("Segoe UI", 9F);
            Passtxt.HoverState.BorderColor = Color.FromArgb(21, 76, 121);
            Passtxt.IconRight = (Image)resources.GetObject("Passtxt.IconRight");
            Passtxt.IconRightSize = new Size(28, 28);
            Passtxt.Location = new Point(677, 349);
            Passtxt.Margin = new Padding(3, 4, 3, 4);
            Passtxt.Name = "Passtxt";
            Passtxt.PasswordChar = '*';
            Passtxt.PlaceholderText = "";
            Passtxt.SelectedText = "";
            Passtxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Passtxt.Size = new Size(286, 60);
            Passtxt.TabIndex = 1;
            Passtxt.TextOffset = new Point(10, 0);
            Passtxt.IconRightClick += guna2TextBox1_IconRightClick;
            Passtxt.KeyDown += Passtxt_KeyDown;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(21, 76, 121);
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(736, 437);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(165, 58);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Giriş";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 322);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 212);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 6;
            label3.Text = "Kullanıcı Adı";
            label3.Click += label3_Click;
            // 
            // Usertxt
            // 
            Usertxt.AutoRoundedCorners = true;
            Usertxt.CustomizableEdges = customizableEdges7;
            Usertxt.DefaultText = "";
            Usertxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Usertxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Usertxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Usertxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Usertxt.FocusedState.BorderColor = Color.FromArgb(21, 76, 121);
            Usertxt.Font = new Font("Segoe UI", 9F);
            Usertxt.HoverState.BorderColor = Color.FromArgb(21, 76, 121);
            Usertxt.Location = new Point(677, 239);
            Usertxt.Margin = new Padding(3, 4, 3, 4);
            Usertxt.Name = "Usertxt";
            Usertxt.PlaceholderText = "";
            Usertxt.SelectedText = "";
            Usertxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Usertxt.Size = new Size(286, 60);
            Usertxt.TabIndex = 0;
            Usertxt.TextOffset = new Point(10, 0);
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(754, 24);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(100, 109);
            guna2CirclePictureBox1.TabIndex = 7;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(576, 37);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(42, 476);
            guna2vSeparator1.TabIndex = 8;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cEye.png");
            ımageList1.Images.SetKeyName(1, "Invisible.png");
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Text = null;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomClick = true;
            guna2ControlBox1.CustomizableEdges = customizableEdges10;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.HoverState.FillColor = Color.Crimson;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1130, 6);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 9;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 243, 248);
            ClientSize = new Size(1194, 566);
            Controls.Add(guna2ControlBox1);
            Controls.Add(guna2vSeparator1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label3);
            Controls.Add(Usertxt);
            Controls.Add(label2);
            Controls.Add(guna2Button1);
            Controls.Add(Passtxt);
            Controls.Add(label1);
            Controls.Add(guna2PictureBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(71, 69, 94);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Passtxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Usertxt;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private ImageList ımageList1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}