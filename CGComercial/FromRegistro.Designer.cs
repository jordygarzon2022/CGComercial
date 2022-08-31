namespace CGComercial
{
    partial class FromRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromRegistro));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.tbxNumDoc = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.btncheck = new System.Windows.Forms.PictureBox();
            this.txtboxtelefono = new System.Windows.Forms.TextBox();
            this.txtboxpass = new System.Windows.Forms.TextBox();
            this.txtboxuser = new System.Windows.Forms.TextBox();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxadress = new System.Windows.Forms.TextBox();
            this.txtboxBarrio = new System.Windows.Forms.TextBox();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbboxDocumentType = new System.Windows.Forms.ComboBox();
            this.checkMasculino = new System.Windows.Forms.CheckBox();
            this.checkOtro = new System.Windows.Forms.CheckBox();
            this.checkfem = new System.Windows.Forms.CheckBox();
            this.datenacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxsecondlastname = new System.Windows.Forms.TextBox();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.txtboxsecondname = new System.Windows.Forms.TextBox();
            this.txtboxfistname = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblconfemail = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.lblbarrio = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblgen = new System.Windows.Forms.Label();
            this.lblTypeDocument = new System.Windows.Forms.Label();
            this.lblsecondlastname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblsecondname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtboxpass2 = new System.Windows.Forms.TextBox();
            this.pnlinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(418, 42);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(328, 50);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registrar usuarios";
            // 
            // tbxNumDoc
            // 
            this.tbxNumDoc.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNumDoc.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumDoc.Location = new System.Drawing.Point(479, 131);
            this.tbxNumDoc.Name = "tbxNumDoc";
            this.tbxNumDoc.Size = new System.Drawing.Size(200, 48);
            this.tbxNumDoc.TabIndex = 1;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(709, 131);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(138, 48);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // pnlinfo
            // 
            this.pnlinfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlinfo.Controls.Add(this.txtboxpass2);
            this.pnlinfo.Controls.Add(this.lblpass);
            this.pnlinfo.Controls.Add(this.btncheck);
            this.pnlinfo.Controls.Add(this.txtboxtelefono);
            this.pnlinfo.Controls.Add(this.txtboxpass);
            this.pnlinfo.Controls.Add(this.txtboxuser);
            this.pnlinfo.Controls.Add(this.txtboxemail);
            this.pnlinfo.Controls.Add(this.txtboxadress);
            this.pnlinfo.Controls.Add(this.txtboxBarrio);
            this.pnlinfo.Controls.Add(this.txtboxCity);
            this.pnlinfo.Controls.Add(this.label2);
            this.pnlinfo.Controls.Add(this.cmbboxDocumentType);
            this.pnlinfo.Controls.Add(this.checkMasculino);
            this.pnlinfo.Controls.Add(this.checkOtro);
            this.pnlinfo.Controls.Add(this.checkfem);
            this.pnlinfo.Controls.Add(this.datenacimiento);
            this.pnlinfo.Controls.Add(this.label1);
            this.pnlinfo.Controls.Add(this.txtboxsecondlastname);
            this.pnlinfo.Controls.Add(this.txtboxlastname);
            this.pnlinfo.Controls.Add(this.txtboxsecondname);
            this.pnlinfo.Controls.Add(this.txtboxfistname);
            this.pnlinfo.Controls.Add(this.lbluser);
            this.pnlinfo.Controls.Add(this.lblconfemail);
            this.pnlinfo.Controls.Add(this.lblemail);
            this.pnlinfo.Controls.Add(this.lbladress);
            this.pnlinfo.Controls.Add(this.lblbarrio);
            this.pnlinfo.Controls.Add(this.lblCity);
            this.pnlinfo.Controls.Add(this.lblgen);
            this.pnlinfo.Controls.Add(this.lblTypeDocument);
            this.pnlinfo.Controls.Add(this.lblsecondlastname);
            this.pnlinfo.Controls.Add(this.lbllastname);
            this.pnlinfo.Controls.Add(this.lblsecondname);
            this.pnlinfo.Controls.Add(this.lblfirstname);
            this.pnlinfo.Location = new System.Drawing.Point(12, 215);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(1326, 502);
            this.pnlinfo.TabIndex = 3;
            this.pnlinfo.Visible = false;
            // 
            // btncheck
            // 
            this.btncheck.BackgroundImage = global::CGComercial.Properties.Resources.checkbtn;
            this.btncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncheck.Location = new System.Drawing.Point(997, 353);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(145, 149);
            this.btncheck.TabIndex = 35;
            this.btncheck.TabStop = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtboxtelefono
            // 
            this.txtboxtelefono.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxtelefono.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxtelefono.Location = new System.Drawing.Point(268, 288);
            this.txtboxtelefono.Name = "txtboxtelefono";
            this.txtboxtelefono.Size = new System.Drawing.Size(294, 48);
            this.txtboxtelefono.TabIndex = 34;
            // 
            // txtboxpass
            // 
            this.txtboxpass.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxpass.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxpass.Location = new System.Drawing.Point(658, 362);
            this.txtboxpass.Name = "txtboxpass";
            this.txtboxpass.Size = new System.Drawing.Size(270, 48);
            this.txtboxpass.TabIndex = 33;
            // 
            // txtboxuser
            // 
            this.txtboxuser.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxuser.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxuser.Location = new System.Drawing.Point(139, 400);
            this.txtboxuser.Name = "txtboxuser";
            this.txtboxuser.Size = new System.Drawing.Size(200, 48);
            this.txtboxuser.TabIndex = 32;
            // 
            // txtboxemail
            // 
            this.txtboxemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxemail.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxemail.Location = new System.Drawing.Point(607, 288);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(661, 48);
            this.txtboxemail.TabIndex = 31;
            // 
            // txtboxadress
            // 
            this.txtboxadress.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxadress.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxadress.Location = new System.Drawing.Point(775, 170);
            this.txtboxadress.Name = "txtboxadress";
            this.txtboxadress.Size = new System.Drawing.Size(493, 48);
            this.txtboxadress.TabIndex = 30;
            // 
            // txtboxBarrio
            // 
            this.txtboxBarrio.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxBarrio.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBarrio.Location = new System.Drawing.Point(21, 288);
            this.txtboxBarrio.Name = "txtboxBarrio";
            this.txtboxBarrio.Size = new System.Drawing.Size(200, 48);
            this.txtboxBarrio.TabIndex = 29;
            // 
            // txtboxCity
            // 
            this.txtboxCity.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxCity.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCity.Location = new System.Drawing.Point(549, 170);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(200, 48);
            this.txtboxCity.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contraseña";
            // 
            // cmbboxDocumentType
            // 
            this.cmbboxDocumentType.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxDocumentType.FormattingEnabled = true;
            this.cmbboxDocumentType.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PS",
            "PPT"});
            this.cmbboxDocumentType.Location = new System.Drawing.Point(1084, 56);
            this.cmbboxDocumentType.Name = "cmbboxDocumentType";
            this.cmbboxDocumentType.Size = new System.Drawing.Size(121, 53);
            this.cmbboxDocumentType.TabIndex = 26;
            // 
            // checkMasculino
            // 
            this.checkMasculino.AutoSize = true;
            this.checkMasculino.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMasculino.Location = new System.Drawing.Point(21, 224);
            this.checkMasculino.Name = "checkMasculino";
            this.checkMasculino.Size = new System.Drawing.Size(101, 27);
            this.checkMasculino.TabIndex = 25;
            this.checkMasculino.Text = "Masculino";
            this.checkMasculino.UseVisualStyleBackColor = true;
            // 
            // checkOtro
            // 
            this.checkOtro.AutoSize = true;
            this.checkOtro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOtro.Location = new System.Drawing.Point(21, 191);
            this.checkOtro.Name = "checkOtro";
            this.checkOtro.Size = new System.Drawing.Size(65, 27);
            this.checkOtro.TabIndex = 24;
            this.checkOtro.Text = "Otro";
            this.checkOtro.UseVisualStyleBackColor = true;
            // 
            // checkfem
            // 
            this.checkfem.AutoSize = true;
            this.checkfem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkfem.Location = new System.Drawing.Point(21, 158);
            this.checkfem.Name = "checkfem";
            this.checkfem.Size = new System.Drawing.Size(95, 27);
            this.checkfem.TabIndex = 23;
            this.checkfem.Text = "Femenino";
            this.checkfem.UseVisualStyleBackColor = true;
            // 
            // datenacimiento
            // 
            this.datenacimiento.CalendarFont = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datenacimiento.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datenacimiento.Location = new System.Drawing.Point(244, 168);
            this.datenacimiento.Name = "datenacimiento";
            this.datenacimiento.Size = new System.Drawing.Size(264, 52);
            this.datenacimiento.TabIndex = 22;
            this.datenacimiento.Value = new System.DateTime(2022, 8, 28, 18, 11, 50, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // txtboxsecondlastname
            // 
            this.txtboxsecondlastname.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxsecondlastname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxsecondlastname.Location = new System.Drawing.Point(747, 56);
            this.txtboxsecondlastname.Name = "txtboxsecondlastname";
            this.txtboxsecondlastname.Size = new System.Drawing.Size(200, 48);
            this.txtboxsecondlastname.TabIndex = 19;
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxlastname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxlastname.Location = new System.Drawing.Point(522, 56);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(200, 48);
            this.txtboxlastname.TabIndex = 18;
            // 
            // txtboxsecondname
            // 
            this.txtboxsecondname.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxsecondname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxsecondname.Location = new System.Drawing.Point(279, 56);
            this.txtboxsecondname.Name = "txtboxsecondname";
            this.txtboxsecondname.Size = new System.Drawing.Size(200, 48);
            this.txtboxsecondname.TabIndex = 17;
            // 
            // txtboxfistname
            // 
            this.txtboxfistname.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxfistname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxfistname.Location = new System.Drawing.Point(21, 56);
            this.txtboxfistname.Name = "txtboxfistname";
            this.txtboxfistname.Size = new System.Drawing.Size(200, 48);
            this.txtboxfistname.TabIndex = 5;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(14, 403);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(119, 40);
            this.lbluser.TabIndex = 16;
            this.lbluser.Text = "Usuario";
            // 
            // lblconfemail
            // 
            this.lblconfemail.AutoSize = true;
            this.lblconfemail.BackColor = System.Drawing.Color.Transparent;
            this.lblconfemail.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfemail.Location = new System.Drawing.Point(363, 245);
            this.lblconfemail.Name = "lblconfemail";
            this.lblconfemail.Size = new System.Drawing.Size(137, 40);
            this.lblconfemail.TabIndex = 15;
            this.lblconfemail.Text = "Telefono";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(893, 245);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(89, 40);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "Email";
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.BackColor = System.Drawing.Color.Transparent;
            this.lbladress.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladress.Location = new System.Drawing.Point(956, 124);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(144, 40);
            this.lbladress.TabIndex = 13;
            this.lbladress.Text = "Dirección";
            // 
            // lblbarrio
            // 
            this.lblbarrio.AutoSize = true;
            this.lblbarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblbarrio.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarrio.Location = new System.Drawing.Point(74, 245);
            this.lblbarrio.Name = "lblbarrio";
            this.lblbarrio.Size = new System.Drawing.Size(101, 40);
            this.lblbarrio.TabIndex = 12;
            this.lblbarrio.Text = "Barrio";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(600, 124);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(106, 40);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "Ciudad";
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.BackColor = System.Drawing.Color.Transparent;
            this.lblgen.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgen.Location = new System.Drawing.Point(74, 124);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(113, 40);
            this.lblgen.TabIndex = 10;
            this.lblgen.Text = "Género";
            // 
            // lblTypeDocument
            // 
            this.lblTypeDocument.AutoSize = true;
            this.lblTypeDocument.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeDocument.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDocument.Location = new System.Drawing.Point(1010, 13);
            this.lblTypeDocument.Name = "lblTypeDocument";
            this.lblTypeDocument.Size = new System.Drawing.Size(272, 40);
            this.lblTypeDocument.TabIndex = 9;
            this.lblTypeDocument.Text = "Tipo de documento";
            // 
            // lblsecondlastname
            // 
            this.lblsecondlastname.AutoSize = true;
            this.lblsecondlastname.BackColor = System.Drawing.Color.Transparent;
            this.lblsecondlastname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecondlastname.Location = new System.Drawing.Point(740, 13);
            this.lblsecondlastname.Name = "lblsecondlastname";
            this.lblsecondlastname.Size = new System.Drawing.Size(242, 40);
            this.lblsecondlastname.TabIndex = 8;
            this.lblsecondlastname.Text = "Segundo apellido";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.BackColor = System.Drawing.Color.Transparent;
            this.lbllastname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(515, 13);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(219, 40);
            this.lbllastname.TabIndex = 7;
            this.lbllastname.Text = "Primer apellido";
            // 
            // lblsecondname
            // 
            this.lblsecondname.AutoSize = true;
            this.lblsecondname.BackColor = System.Drawing.Color.Transparent;
            this.lblsecondname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecondname.Location = new System.Drawing.Point(261, 13);
            this.lblsecondname.Name = "lblsecondname";
            this.lblsecondname.Size = new System.Drawing.Size(239, 40);
            this.lblsecondname.TabIndex = 6;
            this.lblsecondname.Text = "Segundo nombre";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstname.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(14, 13);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(216, 40);
            this.lblfirstname.TabIndex = 5;
            this.lblfirstname.Text = "Primer nombre";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDoc.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoc.Location = new System.Drawing.Point(125, 134);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(319, 40);
            this.lblNumDoc.TabIndex = 4;
            this.lblNumDoc.Text = "Numero de documento";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(395, 441);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(262, 40);
            this.lblpass.TabIndex = 36;
            this.lblpass.Text = "Repita contraseña";
            // 
            // txtboxpass2
            // 
            this.txtboxpass2.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxpass2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxpass2.Location = new System.Drawing.Point(663, 441);
            this.txtboxpass2.Name = "txtboxpass2";
            this.txtboxpass2.Size = new System.Drawing.Size(265, 48);
            this.txtboxpass2.TabIndex = 37;
            // 
            // FromRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CGComercial.Properties.Resources.TexturaMultiColor;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.pnlinfo);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.tbxNumDoc);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FromRegistro";
            this.Text = "FromRegistro";
            this.pnlinfo.ResumeLayout(false);
            this.pnlinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox tbxNumDoc;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Panel pnlinfo;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.TextBox txtboxfistname;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblconfemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.Label lblbarrio;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.Label lblTypeDocument;
        private System.Windows.Forms.Label lblsecondlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblsecondname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtboxsecondname;
        private System.Windows.Forms.TextBox txtboxsecondlastname;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.ComboBox cmbboxDocumentType;
        private System.Windows.Forms.CheckBox checkMasculino;
        private System.Windows.Forms.CheckBox checkOtro;
        private System.Windows.Forms.CheckBox checkfem;
        private System.Windows.Forms.DateTimePicker datenacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxadress;
        private System.Windows.Forms.TextBox txtboxBarrio;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxtelefono;
        private System.Windows.Forms.TextBox txtboxpass;
        private System.Windows.Forms.TextBox txtboxuser;
        private System.Windows.Forms.PictureBox btncheck;
        private System.Windows.Forms.TextBox txtboxpass2;
        private System.Windows.Forms.Label lblpass;
    }
}