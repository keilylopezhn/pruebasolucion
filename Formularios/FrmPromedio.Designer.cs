namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmPromedio
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrimerCal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSegundaCal = new System.Windows.Forms.TextBox();
            this.TxtTercerCal = new System.Windows.Forms.TextBox();
            this.TxtCuartaCal = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.Location = new System.Drawing.Point(244, 288);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 36);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar Primer Calificacion.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtPrimerCal
            // 
            this.TxtPrimerCal.Location = new System.Drawing.Point(254, 66);
            this.TxtPrimerCal.Name = "TxtPrimerCal";
            this.TxtPrimerCal.Size = new System.Drawing.Size(102, 26);
            this.TxtPrimerCal.TabIndex = 5;
            this.TxtPrimerCal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresar Segunda  Calificacion.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingresar Tercer Calificacion.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingresar Cuarta Calificacion.";
            // 
            // TxtSegundaCal
            // 
            this.TxtSegundaCal.Location = new System.Drawing.Point(254, 98);
            this.TxtSegundaCal.Name = "TxtSegundaCal";
            this.TxtSegundaCal.Size = new System.Drawing.Size(102, 26);
            this.TxtSegundaCal.TabIndex = 9;
            this.TxtSegundaCal.TextChanged += new System.EventHandler(this.FrmSegundaCal_TextChanged);
            // 
            // TxtTercerCal
            // 
            this.TxtTercerCal.Location = new System.Drawing.Point(254, 132);
            this.TxtTercerCal.Name = "TxtTercerCal";
            this.TxtTercerCal.Size = new System.Drawing.Size(102, 26);
            this.TxtTercerCal.TabIndex = 10;
            // 
            // TxtCuartaCal
            // 
            this.TxtCuartaCal.Location = new System.Drawing.Point(254, 164);
            this.TxtCuartaCal.Name = "TxtCuartaCal";
            this.TxtCuartaCal.Size = new System.Drawing.Size(102, 26);
            this.TxtCuartaCal.TabIndex = 11;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(16, 195);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 38);
            this.BtnCalcular.TabIndex = 12;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Promedio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtPromedio.Location = new System.Drawing.Point(113, 252);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.ReadOnly = true;
            this.TxtPromedio.Size = new System.Drawing.Size(123, 26);
            this.TxtPromedio.TabIndex = 14;
            this.TxtPromedio.TextChanged += new System.EventHandler(this.TxtPromedio_TextChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(135, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPromedio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(368, 336);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPromedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtCuartaCal);
            this.Controls.Add(this.TxtTercerCal);
            this.Controls.Add(this.TxtSegundaCal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPrimerCal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPromedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular el Promedio de 4 Calificaciones de un Estudiante.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrimerCal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSegundaCal;
        private System.Windows.Forms.TextBox TxtTercerCal;
        private System.Windows.Forms.TextBox TxtCuartaCal;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Button button1;
    }
}