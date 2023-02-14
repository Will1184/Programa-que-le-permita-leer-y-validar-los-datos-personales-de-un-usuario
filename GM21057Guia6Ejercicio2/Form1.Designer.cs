namespace GM21057Guia6Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.maskedTextBoxFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelGeneracion = new System.Windows.Forms.Label();
            this.labelMarcoTemporal = new System.Windows.Forms.Label();
            this.labelPoblacion = new System.Windows.Forms.Label();
            this.labelCircustanciaHistorica = new System.Windows.Forms.Label();
            this.labelRasgo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo Electronico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.buttonBorrar);
            this.groupBox1.Controls.Add(this.buttonIngresar);
            this.groupBox1.Controls.Add(this.textBoxCorreo);
            this.groupBox1.Controls.Add(this.maskedTextBoxFechaNacimiento);
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefono);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese datos";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(451, 128);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 13;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(451, 48);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 12;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(451, 87);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 11;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(160, 84);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(242, 23);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // maskedTextBoxFechaNacimiento
            // 
            this.maskedTextBoxFechaNacimiento.Location = new System.Drawing.Point(160, 158);
            this.maskedTextBoxFechaNacimiento.Mask = "00/00/0000";
            this.maskedTextBoxFechaNacimiento.Name = "maskedTextBoxFechaNacimiento";
            this.maskedTextBoxFechaNacimiento.Size = new System.Drawing.Size(101, 23);
            this.maskedTextBoxFechaNacimiento.TabIndex = 9;
            this.maskedTextBoxFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(160, 120);
            this.maskedTextBoxTelefono.Mask = "+(999)0000-0000";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(101, 23);
            this.maskedTextBoxTelefono.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(160, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(242, 23);
            this.textBoxNombre.TabIndex = 5;
            // 
            // labelGeneracion
            // 
            this.labelGeneracion.AutoSize = true;
            this.labelGeneracion.Location = new System.Drawing.Point(6, 69);
            this.labelGeneracion.Name = "labelGeneracion";
            this.labelGeneracion.Size = new System.Drawing.Size(0, 15);
            this.labelGeneracion.TabIndex = 14;
            // 
            // labelMarcoTemporal
            // 
            this.labelMarcoTemporal.AutoSize = true;
            this.labelMarcoTemporal.Location = new System.Drawing.Point(119, 69);
            this.labelMarcoTemporal.Name = "labelMarcoTemporal";
            this.labelMarcoTemporal.Size = new System.Drawing.Size(0, 15);
            this.labelMarcoTemporal.TabIndex = 15;
            // 
            // labelPoblacion
            // 
            this.labelPoblacion.AutoSize = true;
            this.labelPoblacion.Location = new System.Drawing.Point(238, 69);
            this.labelPoblacion.Name = "labelPoblacion";
            this.labelPoblacion.Size = new System.Drawing.Size(0, 15);
            this.labelPoblacion.TabIndex = 16;
            // 
            // labelCircustanciaHistorica
            // 
            this.labelCircustanciaHistorica.AutoSize = true;
            this.labelCircustanciaHistorica.Location = new System.Drawing.Point(344, 69);
            this.labelCircustanciaHistorica.Name = "labelCircustanciaHistorica";
            this.labelCircustanciaHistorica.Size = new System.Drawing.Size(0, 15);
            this.labelCircustanciaHistorica.TabIndex = 17;
            // 
            // labelRasgo
            // 
            this.labelRasgo.AutoSize = true;
            this.labelRasgo.Location = new System.Drawing.Point(548, 69);
            this.labelRasgo.Name = "labelRasgo";
            this.labelRasgo.Size = new System.Drawing.Size(0, 15);
            this.labelRasgo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Rago Caracteristico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Circustancia Historica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Poblacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Marco Temporal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Generacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelGeneracion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelMarcoTemporal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelPoblacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelCircustanciaHistorica);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelRasgo);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taxonomia";
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 348);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBoxNombre;
        private Button buttonSalir;
        private Button buttonBorrar;
        private Button buttonIngresar;
        private TextBox textBoxCorreo;
        private MaskedTextBox maskedTextBoxFechaNacimiento;
        private MaskedTextBox maskedTextBoxTelefono;
        private Label labelGeneracion;
        private Label labelMarcoTemporal;
        private Label labelPoblacion;
        private Label labelCircustanciaHistorica;
        private Label labelRasgo;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private GroupBox groupBox2;
        private ErrorProvider errorIcon;
    }
}