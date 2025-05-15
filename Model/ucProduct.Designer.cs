namespace InventoryPosSystem.Model
{
    partial class ucProduct
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Pictxt = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            Pricelbl = new Label();
            Nametxt = new Label();
            ((System.ComponentModel.ISupportInitialize)Pictxt).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Pictxt
            // 
            Pictxt.BackColor = Color.Transparent;
            Pictxt.CustomizableEdges = customizableEdges3;
            Pictxt.Image = Properties.Resources.Shopping_Bag;
            Pictxt.ImageRotate = 0F;
            Pictxt.Location = new Point(63, -7);
            Pictxt.Name = "Pictxt";
            Pictxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Pictxt.Size = new Size(101, 93);
            Pictxt.SizeMode = PictureBoxSizeMode.Zoom;
            Pictxt.TabIndex = 1;
            Pictxt.TabStop = false;
            Pictxt.UseTransparentBackground = true;
            Pictxt.Click += Pictxt_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(Pricelbl);
            guna2ShadowPanel1.Controls.Add(Nametxt);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(16, 28);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(192, 216);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // Pricelbl
            // 
            Pricelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Pricelbl.Location = new Point(0, 153);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(192, 38);
            Pricelbl.TabIndex = 1;
            Pricelbl.Text = "200";
            Pricelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Nametxt
            // 
            Nametxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Nametxt.Location = new Point(1, 96);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(192, 38);
            Nametxt.TabIndex = 0;
            Nametxt.Text = "Ürün Adı";
            Nametxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucProduct
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(Pictxt);
            Controls.Add(guna2ShadowPanel1);
            Name = "ucProduct";
            Size = new Size(227, 260);
            ((System.ComponentModel.ISupportInitialize)Pictxt).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox Pictxt;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label Pricelbl;
        private Label Nametxt;
    }
}
