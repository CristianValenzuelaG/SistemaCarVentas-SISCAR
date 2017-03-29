namespace SiSCar.Vista
{
    partial class frmComprador
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
            this.grbComprador = new System.Windows.Forms.GroupBox();
            this.btnBuscaPropie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCo = new System.Windows.Forms.Label();
            this.grbCarro = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnBuscarCar = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.grbComprador.SuspendLayout();
            this.grbCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbComprador
            // 
            this.grbComprador.Controls.Add(this.btnBuscaPropie);
            this.grbComprador.Controls.Add(this.label3);
            this.grbComprador.Controls.Add(this.txtCiudad);
            this.grbComprador.Controls.Add(this.txtDireccion);
            this.grbComprador.Controls.Add(this.label2);
            this.grbComprador.Controls.Add(this.txtNombre);
            this.grbComprador.Controls.Add(this.label1);
            this.grbComprador.Location = new System.Drawing.Point(12, 12);
            this.grbComprador.Name = "grbComprador";
            this.grbComprador.Size = new System.Drawing.Size(529, 186);
            this.grbComprador.TabIndex = 0;
            this.grbComprador.TabStop = false;
            this.grbComprador.Text = "Comprador";
            // 
            // btnBuscaPropie
            // 
            this.btnBuscaPropie.Location = new System.Drawing.Point(448, 25);
            this.btnBuscaPropie.Name = "btnBuscaPropie";
            this.btnBuscaPropie.Size = new System.Drawing.Size(75, 31);
            this.btnBuscaPropie.TabIndex = 6;
            this.btnBuscaPropie.Text = "Buscar";
            this.btnBuscaPropie.UseVisualStyleBackColor = true;
            this.btnBuscaPropie.Click += new System.EventHandler(this.btnBuscaPropie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(6, 149);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(312, 26);
            this.txtCiudad.TabIndex = 4;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(312, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Location = new System.Drawing.Point(562, 115);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(51, 20);
            this.lblCo.TabIndex = 7;
            this.lblCo.Text = "label7";
            this.lblCo.Visible = false;
            // 
            // grbCarro
            // 
            this.grbCarro.Controls.Add(this.textBox3);
            this.grbCarro.Controls.Add(this.label9);
            this.grbCarro.Controls.Add(this.textBox2);
            this.grbCarro.Controls.Add(this.label8);
            this.grbCarro.Controls.Add(this.textBox1);
            this.grbCarro.Controls.Add(this.label7);
            this.grbCarro.Controls.Add(this.label4);
            this.grbCarro.Controls.Add(this.txtColor);
            this.grbCarro.Controls.Add(this.btnBuscarCar);
            this.grbCarro.Controls.Add(this.txtModelo);
            this.grbCarro.Controls.Add(this.label6);
            this.grbCarro.Controls.Add(this.label5);
            this.grbCarro.Controls.Add(this.txtMarca);
            this.grbCarro.Location = new System.Drawing.Point(12, 204);
            this.grbCarro.Name = "grbCarro";
            this.grbCarro.Size = new System.Drawing.Size(529, 291);
            this.grbCarro.TabIndex = 1;
            this.grbCarro.TabStop = false;
            this.grbCarro.Text = "Carro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 259);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 26);
            this.textBox3.TabIndex = 19;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 26);
            this.textBox2.TabIndex = 17;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "IVA ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(6, 149);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(312, 26);
            this.txtColor.TabIndex = 11;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // btnBuscarCar
            // 
            this.btnBuscarCar.Location = new System.Drawing.Point(448, 25);
            this.btnBuscarCar.Name = "btnBuscarCar";
            this.btnBuscarCar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscarCar.TabIndex = 7;
            this.btnBuscarCar.Text = "Buscar";
            this.btnBuscarCar.UseVisualStyleBackColor = true;
            this.btnBuscarCar.Click += new System.EventHandler(this.btnBuscarCar_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(6, 97);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(312, 26);
            this.txtModelo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 45);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(312, 26);
            this.txtMarca.TabIndex = 8;
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(557, 289);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(51, 20);
            this.lblCa.TabIndex = 8;
            this.lblCa.Text = "label8";
            this.lblCa.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(380, 501);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 31);
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // frmComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 544);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbCarro);
            this.Controls.Add(this.grbComprador);
            this.Controls.Add(this.lblCa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmComprador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprador";
            this.grbComprador.ResumeLayout(false);
            this.grbComprador.PerformLayout();
            this.grbCarro.ResumeLayout(false);
            this.grbCarro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbComprador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCarro;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnBuscaPropie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnBuscarCar;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
    }
}