namespace InventoryPosSystem.Model
{
    partial class frmCategoryAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(440, 125);
            // 
            // Sampletxt
            // 
            Sampletxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Sampletxt.Size = new Size(217, 38);
            Sampletxt.Text = "Kategori Ekleme";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 348);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(440, 125);
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Parent = this;
            // 
            // Nametxt
            // 
            Nametxt.AutoRoundedCorners = true;
            Nametxt.CustomizableEdges = customizableEdges3;
            Nametxt.DefaultText = "";
            Nametxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Nametxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Nametxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Nametxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Nametxt.FocusedState.BorderColor = Color.FromArgb(21, 76, 121);
            Nametxt.Font = new Font("Segoe UI", 9F);
            Nametxt.ForeColor = Color.FromArgb(64, 64, 64);
            Nametxt.HoverState.BorderColor = Color.FromArgb(21, 76, 121);
            Nametxt.Location = new Point(40, 196);
            Nametxt.Margin = new Padding(3, 4, 3, 4);
            Nametxt.Name = "Nametxt";
            Nametxt.PlaceholderText = "";
            Nametxt.SelectedText = "";
            Nametxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Nametxt.Size = new Size(286, 60);
            Nametxt.TabIndex = 0;
            Nametxt.Tag = "v";
            Nametxt.TextOffset = new Point(10, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 169);
            label1.Name = "label1";
            label1.Size = new Size(41, 23);
            label1.TabIndex = 7;
            label1.Text = "İsim";
            // 
            // frmCategoryAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 473);
            Controls.Add(Nametxt);
            Controls.Add(label1);
            Name = "frmCategoryAdd";
            Text = "frmCategoryAdd";
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(Nametxt, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox Nametxt;
        private Label label1;
    }
}