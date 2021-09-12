
namespace ejericio1Parte2Guia2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.tbSneto = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.radBGerente = new System.Windows.Forms.RadioButton();
            this.radBSubgerente = new System.Windows.Forms.RadioButton();
            this.radBSecretaria = new System.Windows.Forms.RadioButton();
            this.btncalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario neto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(197, 40);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(125, 27);
            this.tbSalario.TabIndex = 10;
            // 
            // tbDescuento
            // 
            this.tbDescuento.Location = new System.Drawing.Point(197, 105);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.ReadOnly = true;
            this.tbDescuento.Size = new System.Drawing.Size(125, 27);
            this.tbDescuento.TabIndex = 11;
            // 
            // tbSneto
            // 
            this.tbSneto.Location = new System.Drawing.Point(197, 170);
            this.tbSneto.Name = "tbSneto";
            this.tbSneto.ReadOnly = true;
            this.tbSneto.Size = new System.Drawing.Size(125, 27);
            this.tbSneto.TabIndex = 12;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(189, 64);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(125, 27);
            this.tbnombre.TabIndex = 13;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(509, 65);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(125, 27);
            this.tbapellido.TabIndex = 14;
            // 
            // radBGerente
            // 
            this.radBGerente.AutoSize = true;
            this.radBGerente.Location = new System.Drawing.Point(479, 38);
            this.radBGerente.Name = "radBGerente";
            this.radBGerente.Size = new System.Drawing.Size(82, 24);
            this.radBGerente.TabIndex = 15;
            this.radBGerente.TabStop = true;
            this.radBGerente.Text = "Gerente";
            this.radBGerente.UseVisualStyleBackColor = true;
            this.radBGerente.CheckedChanged += new System.EventHandler(this.radBGerente_CheckedChanged);
            // 
            // radBSubgerente
            // 
            this.radBSubgerente.AutoSize = true;
            this.radBSubgerente.Location = new System.Drawing.Point(479, 103);
            this.radBSubgerente.Name = "radBSubgerente";
            this.radBSubgerente.Size = new System.Drawing.Size(106, 24);
            this.radBSubgerente.TabIndex = 16;
            this.radBSubgerente.TabStop = true;
            this.radBSubgerente.Text = "Subgerente";
            this.radBSubgerente.UseVisualStyleBackColor = true;
            this.radBSubgerente.CheckedChanged += new System.EventHandler(this.radBSubgerente_CheckedChanged);
            // 
            // radBSecretaria
            // 
            this.radBSecretaria.AutoSize = true;
            this.radBSecretaria.Location = new System.Drawing.Point(479, 166);
            this.radBSecretaria.Name = "radBSecretaria";
            this.radBSecretaria.Size = new System.Drawing.Size(100, 24);
            this.radBSecretaria.TabIndex = 17;
            this.radBSecretaria.TabStop = true;
            this.radBSecretaria.Text = "Secretaria ";
            this.radBSecretaria.UseVisualStyleBackColor = true;
            this.radBSecretaria.CheckedChanged += new System.EventHandler(this.radBSecretaria_CheckedChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(313, 221);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(94, 29);
            this.btncalcular.TabIndex = 18;
            this.btncalcular.Text = "Calcular ";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.radBSecretaria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radBSubgerente);
            this.groupBox1.Controls.Add(this.tbSalario);
            this.groupBox1.Controls.Add(this.radBGerente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDescuento);
            this.groupBox1.Controls.Add(this.tbSneto);
            this.groupBox1.Location = new System.Drawing.Point(41, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 288);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DESCUENTOS";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(595, 221);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(94, 29);
            this.btnsalir.TabIndex = 19;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ventana empleados ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.TextBox tbSneto;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.RadioButton radBGerente;
        private System.Windows.Forms.RadioButton radBSubgerente;
        private System.Windows.Forms.RadioButton radBSecretaria;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
    }
}

