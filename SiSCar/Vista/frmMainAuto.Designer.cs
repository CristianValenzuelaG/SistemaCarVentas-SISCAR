namespace SiSCar.Vista
{
    partial class frmMainAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.pkAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbSatus = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(816, 26);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // grDatos
            // 
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkAuto,
            this.aMarca,
            this.aModelo,
            this.aAño,
            this.aNSerie,
            this.aNacionalidad,
            this.aComentario});
            this.grDatos.Location = new System.Drawing.Point(12, 64);
            this.grDatos.Name = "grDatos";
            this.grDatos.Size = new System.Drawing.Size(816, 211);
            this.grDatos.TabIndex = 10;
            this.grDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellDoubleClick);
            // 
            // pkAuto
            // 
            this.pkAuto.DataPropertyName = "pkAuto";
            this.pkAuto.HeaderText = "Auto";
            this.pkAuto.Name = "pkAuto";
            // 
            // aMarca
            // 
            this.aMarca.DataPropertyName = "aMarca";
            this.aMarca.HeaderText = "Marca";
            this.aMarca.Name = "aMarca";
            // 
            // aModelo
            // 
            this.aModelo.DataPropertyName = "aModelo";
            this.aModelo.HeaderText = "Modelo";
            this.aModelo.Name = "aModelo";
            // 
            // aAño
            // 
            this.aAño.DataPropertyName = "aAño";
            this.aAño.HeaderText = "Año";
            this.aAño.Name = "aAño";
            // 
            // aNSerie
            // 
            this.aNSerie.DataPropertyName = "aNSerie";
            this.aNSerie.HeaderText = "#Serie";
            this.aNSerie.Name = "aNSerie";
            // 
            // aNacionalidad
            // 
            this.aNacionalidad.DataPropertyName = "aNacionalidad";
            this.aNacionalidad.HeaderText = "Nacionalidad";
            this.aNacionalidad.Name = "aNacionalidad";
            this.aNacionalidad.Width = 120;
            // 
            // aComentario
            // 
            this.aComentario.DataPropertyName = "aComentario";
            this.aComentario.HeaderText = "Comentario";
            this.aComentario.Name = "aComentario";
            this.aComentario.Width = 150;
            // 
            // ckbSatus
            // 
            this.ckbSatus.AutoSize = true;
            this.ckbSatus.Checked = true;
            this.ckbSatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSatus.Location = new System.Drawing.Point(753, 281);
            this.ckbSatus.Name = "ckbSatus";
            this.ckbSatus.Size = new System.Drawing.Size(75, 24);
            this.ckbSatus.TabIndex = 14;
            this.ckbSatus.Text = "Status";
            this.ckbSatus.UseVisualStyleBackColor = true;
            this.ckbSatus.CheckedChanged += new System.EventHandler(this.ckbSatus_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(753, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 312);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMainAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 354);
            this.Controls.Add(this.ckbSatus);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainAuto";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.frmMainAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.CheckBox ckbSatus;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn aModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn aComentario;
    }
}