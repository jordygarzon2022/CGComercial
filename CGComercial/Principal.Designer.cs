namespace CGComercial
{
    partial class InicialForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicialForm));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.ShowVideo = new System.Windows.Forms.PictureBox();
            this.pnlbanner = new System.Windows.Forms.Panel();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbximage4 = new System.Windows.Forms.PictureBox();
            this.pbxwomen = new System.Windows.Forms.PictureBox();
            this.pbximage3 = new System.Windows.Forms.PictureBox();
            this.pbxmen = new System.Windows.Forms.PictureBox();
            this.pbximage2 = new System.Windows.Forms.PictureBox();
            this.pbxzapato1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowVideo)).BeginInit();
            this.pnlbanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxwomen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxzapato1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCliente.Location = new System.Drawing.Point(484, 531);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(388, 75);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Tienda Virtual";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Transparent;
            this.btnadmin.BackgroundImage = global::CGComercial.Properties.Resources.iconperson;
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadmin.Location = new System.Drawing.Point(1229, 28);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(86, 78);
            this.btnadmin.TabIndex = 1;
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // ShowVideo
            // 
            this.ShowVideo.Image = global::CGComercial.Properties.Resources.video_zapatos;
            this.ShowVideo.Location = new System.Drawing.Point(468, 278);
            this.ShowVideo.Name = "ShowVideo";
            this.ShowVideo.Size = new System.Drawing.Size(419, 247);
            this.ShowVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowVideo.TabIndex = 2;
            this.ShowVideo.TabStop = false;
            // 
            // pnlbanner
            // 
            this.pnlbanner.BackColor = System.Drawing.Color.Transparent;
            this.pnlbanner.BackgroundImage = global::CGComercial.Properties.Resources.banner_principal;
            this.pnlbanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlbanner.Controls.Add(this.pbxlogo);
            this.pnlbanner.Controls.Add(this.lblTitle);
            this.pnlbanner.Controls.Add(this.pbximage4);
            this.pnlbanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbanner.Location = new System.Drawing.Point(0, 0);
            this.pnlbanner.Name = "pnlbanner";
            this.pnlbanner.Size = new System.Drawing.Size(1350, 262);
            this.pnlbanner.TabIndex = 3;
            // 
            // pbxlogo
            // 
            this.pbxlogo.BackgroundImage = global::CGComercial.Properties.Resources.LogoFront;
            this.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxlogo.Location = new System.Drawing.Point(36, 28);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(262, 217);
            this.pbxlogo.TabIndex = 1;
            this.pbxlogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(512, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calzado Geek";
            // 
            // pbximage4
            // 
            this.pbximage4.BackColor = System.Drawing.Color.Transparent;
            this.pbximage4.Image = global::CGComercial.Properties.Resources.REF4;
            this.pbximage4.Location = new System.Drawing.Point(937, 29);
            this.pbximage4.Name = "pbximage4";
            this.pbximage4.Size = new System.Drawing.Size(256, 216);
            this.pbximage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximage4.TabIndex = 5;
            this.pbximage4.TabStop = false;
            // 
            // pbxwomen
            // 
            this.pbxwomen.BackColor = System.Drawing.Color.Transparent;
            this.pbxwomen.Image = global::CGComercial.Properties.Resources.REF6;
            this.pbxwomen.Location = new System.Drawing.Point(25, 375);
            this.pbxwomen.Name = "pbxwomen";
            this.pbxwomen.Size = new System.Drawing.Size(273, 333);
            this.pbxwomen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxwomen.TabIndex = 4;
            this.pbxwomen.TabStop = false;
            // 
            // pbximage3
            // 
            this.pbximage3.BackColor = System.Drawing.Color.Transparent;
            this.pbximage3.Image = global::CGComercial.Properties.Resources.REF3;
            this.pbximage3.Location = new System.Drawing.Point(232, 251);
            this.pbximage3.Name = "pbximage3";
            this.pbximage3.Size = new System.Drawing.Size(242, 202);
            this.pbximage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximage3.TabIndex = 6;
            this.pbximage3.TabStop = false;
            // 
            // pbxmen
            // 
            this.pbxmen.BackColor = System.Drawing.Color.Transparent;
            this.pbxmen.Image = global::CGComercial.Properties.Resources.REF5;
            this.pbxmen.Location = new System.Drawing.Point(1176, 278);
            this.pbxmen.Name = "pbxmen";
            this.pbxmen.Size = new System.Drawing.Size(133, 289);
            this.pbxmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxmen.TabIndex = 7;
            this.pbxmen.TabStop = false;
            // 
            // pbximage2
            // 
            this.pbximage2.BackColor = System.Drawing.Color.Transparent;
            this.pbximage2.Image = global::CGComercial.Properties.Resources.REF2;
            this.pbximage2.Location = new System.Drawing.Point(914, 492);
            this.pbximage2.Name = "pbximage2";
            this.pbximage2.Size = new System.Drawing.Size(256, 216);
            this.pbximage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximage2.TabIndex = 8;
            this.pbximage2.TabStop = false;
            // 
            // pbxzapato1
            // 
            this.pbxzapato1.BackColor = System.Drawing.Color.Transparent;
            this.pbxzapato1.Image = global::CGComercial.Properties.Resources.REF1;
            this.pbxzapato1.Location = new System.Drawing.Point(914, 270);
            this.pbxzapato1.Name = "pbxzapato1";
            this.pbxzapato1.Size = new System.Drawing.Size(256, 216);
            this.pbxzapato1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxzapato1.TabIndex = 9;
            this.pbxzapato1.TabStop = false;
            // 
            // InicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CGComercial.Properties.Resources.TextureYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pbxzapato1);
            this.Controls.Add(this.pbximage2);
            this.Controls.Add(this.pbxmen);
            this.Controls.Add(this.ShowVideo);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.pnlbanner);
            this.Controls.Add(this.pbximage3);
            this.Controls.Add(this.pbxwomen);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "InicialForm";
            this.Text = "CGComercial Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ShowVideo)).EndInit();
            this.pnlbanner.ResumeLayout(false);
            this.pnlbanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxwomen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxzapato1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.PictureBox ShowVideo;
        private System.Windows.Forms.Panel pnlbanner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.PictureBox pbxwomen;
        private System.Windows.Forms.PictureBox pbximage4;
        private System.Windows.Forms.PictureBox pbximage3;
        private System.Windows.Forms.PictureBox pbxmen;
        private System.Windows.Forms.PictureBox pbximage2;
        private System.Windows.Forms.PictureBox pbxzapato1;
    }
}

