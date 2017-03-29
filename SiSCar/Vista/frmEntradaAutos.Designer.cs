namespace SiSCar.Vista
{
    partial class frmEntradaAutos
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
            this.grbPropietario = new System.Windows.Forms.GroupBox();
            this.txtFotopro = new System.Windows.Forms.TextBox();
            this.picPropie = new System.Windows.Forms.PictureBox();
            this.btnBuscarPro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnFotoPropie = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.grbAuto = new System.Windows.Forms.GroupBox();
            this.btnf2 = new System.Windows.Forms.Button();
            this.btnf3 = new System.Windows.Forms.Button();
            this.txtFoto3 = new System.Windows.Forms.TextBox();
            this.txtfoto2 = new System.Windows.Forms.TextBox();
            this.txtFoto1 = new System.Windows.Forms.TextBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btnFotoAuto = new System.Windows.Forms.Button();
            this.picAuto2 = new System.Windows.Forms.PictureBox();
            this.picAuto3 = new System.Windows.Forms.PictureBox();
            this.picAuto1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNacionalida = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPropie)).BeginInit();
            this.grbAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPropietario
            // 
            this.grbPropietario.Controls.Add(this.txtFotopro);
            this.grbPropietario.Controls.Add(this.picPropie);
            this.grbPropietario.Controls.Add(this.btnBuscarPro);
            this.grbPropietario.Controls.Add(this.label5);
            this.grbPropietario.Controls.Add(this.txtIne);
            this.grbPropietario.Controls.Add(this.label4);
            this.grbPropietario.Controls.Add(this.txtEmail);
            this.grbPropietario.Controls.Add(this.txtDireccion);
            this.grbPropietario.Controls.Add(this.label3);
            this.grbPropietario.Controls.Add(this.txtTelefono);
            this.grbPropietario.Controls.Add(this.label2);
            this.grbPropietario.Controls.Add(this.label1);
            this.grbPropietario.Controls.Add(this.txtNombre);
            this.grbPropietario.Controls.Add(this.btnFotoPropie);
            this.grbPropietario.Location = new System.Drawing.Point(12, 12);
            this.grbPropietario.Name = "grbPropietario";
            this.grbPropietario.Size = new System.Drawing.Size(909, 219);
            this.grbPropietario.TabIndex = 0;
            this.grbPropietario.TabStop = false;
            this.grbPropietario.Text = "Propietario";
            // 
            // txtFotopro
            // 
            this.txtFotopro.Enabled = false;
            this.txtFotopro.Location = new System.Drawing.Point(681, 152);
            this.txtFotopro.Name = "txtFotopro";
            this.txtFotopro.Size = new System.Drawing.Size(100, 26);
            this.txtFotopro.TabIndex = 34;
            this.txtFotopro.TextChanged += new System.EventHandler(this.txtFotopro_TextChanged);
            // 
            // picPropie
            // 
            this.picPropie.Location = new System.Drawing.Point(681, 20);
            this.picPropie.Name = "picPropie";
            this.picPropie.Size = new System.Drawing.Size(108, 126);
            this.picPropie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPropie.TabIndex = 12;
            this.picPropie.TabStop = false;
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.Location = new System.Drawing.Point(828, 25);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarPro.TabIndex = 11;
            this.btnBuscarPro.Text = "Buscar";
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.btnBuscarPro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "INE";
            // 
            // txtIne
            // 
            this.txtIne.Location = new System.Drawing.Point(6, 149);
            this.txtIne.Name = "txtIne";
            this.txtIne.Size = new System.Drawing.Size(276, 26);
            this.txtIne.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(288, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(288, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 26);
            this.txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(6, 97);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(276, 26);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnFotoPropie
            // 
            this.btnFotoPropie.Location = new System.Drawing.Point(701, 185);
            this.btnFotoPropie.Name = "btnFotoPropie";
            this.btnFotoPropie.Size = new System.Drawing.Size(75, 34);
            this.btnFotoPropie.TabIndex = 0;
            this.btnFotoPropie.Text = "F";
            this.btnFotoPropie.UseVisualStyleBackColor = true;
            this.btnFotoPropie.Click += new System.EventHandler(this.btnFotoPropie_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(944, 161);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 20);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "if";
            // 
            // grbAuto
            // 
            this.grbAuto.Controls.Add(this.btnf2);
            this.grbAuto.Controls.Add(this.btnf3);
            this.grbAuto.Controls.Add(this.txtFoto3);
            this.grbAuto.Controls.Add(this.txtfoto2);
            this.grbAuto.Controls.Add(this.txtFoto1);
            this.grbAuto.Controls.Add(this.cmbAño);
            this.grbAuto.Controls.Add(this.btnFotoAuto);
            this.grbAuto.Controls.Add(this.picAuto2);
            this.grbAuto.Controls.Add(this.picAuto3);
            this.grbAuto.Controls.Add(this.picAuto1);
            this.grbAuto.Controls.Add(this.label14);
            this.grbAuto.Controls.Add(this.txtObserva);
            this.grbAuto.Controls.Add(this.label13);
            this.grbAuto.Controls.Add(this.txtNacionalida);
            this.grbAuto.Controls.Add(this.label12);
            this.grbAuto.Controls.Add(this.txtColor);
            this.grbAuto.Controls.Add(this.label11);
            this.grbAuto.Controls.Add(this.txtPrecio);
            this.grbAuto.Controls.Add(this.label10);
            this.grbAuto.Controls.Add(this.txtNPlaca);
            this.grbAuto.Controls.Add(this.label7);
            this.grbAuto.Controls.Add(this.label6);
            this.grbAuto.Controls.Add(this.txtNSerie);
            this.grbAuto.Controls.Add(this.label8);
            this.grbAuto.Controls.Add(this.txtMarca);
            this.grbAuto.Controls.Add(this.txtModelo);
            this.grbAuto.Controls.Add(this.label9);
            this.grbAuto.Location = new System.Drawing.Point(12, 237);
            this.grbAuto.Name = "grbAuto";
            this.grbAuto.Size = new System.Drawing.Size(909, 303);
            this.grbAuto.TabIndex = 1;
            this.grbAuto.TabStop = false;
            this.grbAuto.Text = "Auto";
            // 
            // btnf2
            // 
            this.btnf2.Location = new System.Drawing.Point(681, 189);
            this.btnf2.Name = "btnf2";
            this.btnf2.Size = new System.Drawing.Size(75, 34);
            this.btnf2.TabIndex = 37;
            this.btnf2.Text = "F";
            this.btnf2.UseVisualStyleBackColor = true;
            this.btnf2.Click += new System.EventHandler(this.btnf2_Click);
            // 
            // btnf3
            // 
            this.btnf3.Location = new System.Drawing.Point(795, 189);
            this.btnf3.Name = "btnf3";
            this.btnf3.Size = new System.Drawing.Size(75, 34);
            this.btnf3.TabIndex = 36;
            this.btnf3.Text = "F";
            this.btnf3.UseVisualStyleBackColor = true;
            this.btnf3.Click += new System.EventHandler(this.btnf3_Click);
            // 
            // txtFoto3
            // 
            this.txtFoto3.Enabled = false;
            this.txtFoto3.Location = new System.Drawing.Point(795, 157);
            this.txtFoto3.Name = "txtFoto3";
            this.txtFoto3.Size = new System.Drawing.Size(100, 26);
            this.txtFoto3.TabIndex = 35;
            this.txtFoto3.TextChanged += new System.EventHandler(this.txtFoto3_TextChanged);
            // 
            // txtfoto2
            // 
            this.txtfoto2.Enabled = false;
            this.txtfoto2.Location = new System.Drawing.Point(681, 157);
            this.txtfoto2.Name = "txtfoto2";
            this.txtfoto2.Size = new System.Drawing.Size(100, 26);
            this.txtfoto2.TabIndex = 34;
            this.txtfoto2.TextChanged += new System.EventHandler(this.txtfoto2_TextChanged);
            // 
            // txtFoto1
            // 
            this.txtFoto1.Enabled = false;
            this.txtFoto1.Location = new System.Drawing.Point(570, 157);
            this.txtFoto1.Name = "txtFoto1";
            this.txtFoto1.Size = new System.Drawing.Size(100, 26);
            this.txtFoto1.TabIndex = 33;
            this.txtFoto1.TextChanged += new System.EventHandler(this.txtFoto1_TextChanged);
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Items.AddRange(new object[] {
            "1990",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbAño.Location = new System.Drawing.Point(6, 95);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(276, 28);
            this.cmbAño.TabIndex = 32;
            // 
            // btnFotoAuto
            // 
            this.btnFotoAuto.Location = new System.Drawing.Point(570, 189);
            this.btnFotoAuto.Name = "btnFotoAuto";
            this.btnFotoAuto.Size = new System.Drawing.Size(75, 34);
            this.btnFotoAuto.TabIndex = 13;
            this.btnFotoAuto.Text = "F";
            this.btnFotoAuto.UseVisualStyleBackColor = true;
            this.btnFotoAuto.Click += new System.EventHandler(this.btnFotoAuto_Click);
            // 
            // picAuto2
            // 
            this.picAuto2.Location = new System.Drawing.Point(681, 25);
            this.picAuto2.Name = "picAuto2";
            this.picAuto2.Size = new System.Drawing.Size(108, 126);
            this.picAuto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAuto2.TabIndex = 31;
            this.picAuto2.TabStop = false;
            // 
            // picAuto3
            // 
            this.picAuto3.Location = new System.Drawing.Point(795, 25);
            this.picAuto3.Name = "picAuto3";
            this.picAuto3.Size = new System.Drawing.Size(108, 126);
            this.picAuto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAuto3.TabIndex = 30;
            this.picAuto3.TabStop = false;
            // 
            // picAuto1
            // 
            this.picAuto1.Location = new System.Drawing.Point(567, 25);
            this.picAuto1.Name = "picAuto1";
            this.picAuto1.Size = new System.Drawing.Size(108, 126);
            this.picAuto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAuto1.TabIndex = 13;
            this.picAuto1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Observacion";
            // 
            // txtObserva
            // 
            this.txtObserva.Location = new System.Drawing.Point(6, 253);
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.Size = new System.Drawing.Size(558, 44);
            this.txtObserva.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Nacionalidad";
            // 
            // txtNacionalida
            // 
            this.txtNacionalida.Location = new System.Drawing.Point(288, 201);
            this.txtNacionalida.Name = "txtNacionalida";
            this.txtNacionalida.Size = new System.Drawing.Size(276, 26);
            this.txtNacionalida.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(6, 201);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(276, 26);
            this.txtColor.TabIndex = 24;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(288, 149);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(276, 26);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Numero Placa";
            // 
            // txtNPlaca
            // 
            this.txtNPlaca.Location = new System.Drawing.Point(288, 97);
            this.txtNPlaca.Name = "txtNPlaca";
            this.txtNPlaca.Size = new System.Drawing.Size(276, 26);
            this.txtNPlaca.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Numero Serie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Marca";
            // 
            // txtNSerie
            // 
            this.txtNSerie.Location = new System.Drawing.Point(6, 149);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(276, 26);
            this.txtNSerie.TabIndex = 18;
            this.txtNSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSerie_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Año";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 45);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(276, 26);
            this.txtMarca.TabIndex = 13;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(288, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(276, 26);
            this.txtModelo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Modelo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(840, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 32);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(753, 547);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 32);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEntradaAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 591);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbAuto);
            this.Controls.Add(this.grbPropietario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEntradaAutos";
            this.Text = "Entrada Auto";
            this.grbPropietario.ResumeLayout(false);
            this.grbPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPropie)).EndInit();
            this.grbAuto.ResumeLayout(false);
            this.grbAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPropietario;
        private System.Windows.Forms.PictureBox picPropie;
        private System.Windows.Forms.Button btnBuscarPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnFotoPropie;
        private System.Windows.Forms.GroupBox grbAuto;
        private System.Windows.Forms.Button btnFotoAuto;
        private System.Windows.Forms.PictureBox picAuto2;
        private System.Windows.Forms.PictureBox picAuto3;
        private System.Windows.Forms.PictureBox picAuto1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObserva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNacionalida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.TextBox txtFoto3;
        private System.Windows.Forms.TextBox txtfoto2;
        private System.Windows.Forms.TextBox txtFoto1;
        private System.Windows.Forms.TextBox txtFotopro;
        private System.Windows.Forms.Button btnf2;
        private System.Windows.Forms.Button btnf3;
        private System.Windows.Forms.Label lblID;
    }
}