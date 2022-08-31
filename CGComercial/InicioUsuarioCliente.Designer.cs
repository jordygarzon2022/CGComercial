namespace CGComercial
{
    partial class InicioUsuarioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioUsuarioCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPagos = new System.Windows.Forms.PictureBox();
            this.btnpedido = new System.Windows.Forms.PictureBox();
            this.btnhombres = new System.Windows.Forms.PictureBox();
            this.btnmujeres = new System.Windows.Forms.PictureBox();
            this.btnUsuarioCliente = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmujeres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarioCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CGComercial.Properties.Resources.banner_principal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnUsuarioCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1366, 768);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 264);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(491, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calzado Geek";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnPagos);
            this.panel2.Controls.Add(this.btnpedido);
            this.panel2.Controls.Add(this.btnhombres);
            this.panel2.Controls.Add(this.btnmujeres);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 465);
            this.panel2.TabIndex = 1;
            // 
            // btnPagos
            // 
            this.btnPagos.BackgroundImage = global::CGComercial.Properties.Resources.cashbtn;
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagos.Location = new System.Drawing.Point(21, 318);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(249, 80);
            this.btnPagos.TabIndex = 5;
            this.btnPagos.TabStop = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnpedido
            // 
            this.btnpedido.BackgroundImage = global::CGComercial.Properties.Resources.carrirtopedido;
            this.btnpedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpedido.Location = new System.Drawing.Point(21, 222);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(249, 80);
            this.btnpedido.TabIndex = 4;
            this.btnpedido.TabStop = false;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // btnhombres
            // 
            this.btnhombres.BackgroundImage = global::CGComercial.Properties.Resources.btnhombre__1_;
            this.btnhombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhombres.Location = new System.Drawing.Point(21, 120);
            this.btnhombres.Name = "btnhombres";
            this.btnhombres.Size = new System.Drawing.Size(249, 80);
            this.btnhombres.TabIndex = 3;
            this.btnhombres.TabStop = false;
            this.btnhombres.Click += new System.EventHandler(this.btnhombres_Click);
            // 
            // btnmujeres
            // 
            this.btnmujeres.BackgroundImage = global::CGComercial.Properties.Resources.btnmujer__1_;
            this.btnmujeres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmujeres.Location = new System.Drawing.Point(21, 18);
            this.btnmujeres.Name = "btnmujeres";
            this.btnmujeres.Size = new System.Drawing.Size(249, 80);
            this.btnmujeres.TabIndex = 2;
            this.btnmujeres.TabStop = false;
            this.btnmujeres.Click += new System.EventHandler(this.btnmujeres_Click);
            // 
            // btnUsuarioCliente
            // 
            this.btnUsuarioCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarioCliente.BackgroundImage = global::CGComercial.Properties.Resources.iconperson1;
            this.btnUsuarioCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarioCliente.Location = new System.Drawing.Point(1259, 27);
            this.btnUsuarioCliente.Name = "btnUsuarioCliente";
            this.btnUsuarioCliente.Size = new System.Drawing.Size(68, 71);
            this.btnUsuarioCliente.TabIndex = 2;
            this.btnUsuarioCliente.TabStop = false;
            this.btnUsuarioCliente.Click += new System.EventHandler(this.btnUsuarioCliente_Click);
            // 
            // InicioUsuarioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CGComercial.Properties.Resources.TextureYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "InicioUsuarioCliente";
            this.Text = "Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmujeres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarioCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnPagos;
        private System.Windows.Forms.PictureBox btnpedido;
        private System.Windows.Forms.PictureBox btnhombres;
        private System.Windows.Forms.PictureBox btnmujeres;
        private System.Windows.Forms.PictureBox btnUsuarioCliente;
    }
}