namespace InventoryPosSystem
{
    partial class frmPrintcs
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2ControlBox3);
            guna2Panel1.Controls.Add(btnMax);
            guna2Panel1.Controls.Add(guna2ControlBox1);
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.Size = new Size(1253, 66);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges13;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.HoverState.FillColor = Color.Crimson;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1185, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 0;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            btnMax.CustomizableEdges = customizableEdges11;
            btnMax.FillColor = Color.FromArgb(139, 152, 166);
            btnMax.HoverState.FillColor = Color.Crimson;
            btnMax.IconColor = Color.White;
            btnMax.Location = new Point(1123, 12);
            btnMax.Name = "btnMax";
            btnMax.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMax.Size = new Size(56, 36);
            btnMax.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox3.CustomizableEdges = customizableEdges9;
            guna2ControlBox3.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox3.HoverState.FillColor = Color.Crimson;
            guna2ControlBox3.IconColor = Color.White;
            guna2ControlBox3.Location = new Point(1061, 12);
            guna2ControlBox3.Name = "guna2ControlBox3";
            guna2ControlBox3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ControlBox3.Size = new Size(56, 36);
            guna2ControlBox3.TabIndex = 2;
            // 
            // frmPrintcs
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 627);
            Controls.Add(guna2Panel1);
            Name = "frmPrintcs";
            Text = "frmPrintcs";
            Load += frmPrintcs_Load;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}