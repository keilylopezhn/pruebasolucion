namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmSalarioenBaseaHorasExtras
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
            this.TxtSalarioBase = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtHe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPhe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSalarioExtra = new System.Windows.Forms.TextBox();
            this.TxtSalarioNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.Location = new System.Drawing.Point(311, 317);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(118, 38);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtSalarioBase
            // 
            this.TxtSalarioBase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtSalarioBase.Location = new System.Drawing.Point(289, 243);
            this.TxtSalarioBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalarioBase.Name = "TxtSalarioBase";
            this.TxtSalarioBase.ReadOnly = true;
            this.TxtSalarioBase.Size = new System.Drawing.Size(118, 26);
            this.TxtSalarioBase.TabIndex = 18;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(289, 110);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(118, 26);
            this.TxtPrecio.TabIndex = 17;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(289, 74);
            this.TxtDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(118, 26);
            this.TxtDias.TabIndex = 16;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(13, 198);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(131, 40);
            this.BtnCalcular.TabIndex = 15;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "El Salario Neto es:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese Precio por Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese los Dias Trabajados";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese Valores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ingrese Candidad de Horas Extra";
            // 
            // TxtHe
            // 
            this.TxtHe.Location = new System.Drawing.Point(289, 146);
            this.TxtHe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHe.Name = "TxtHe";
            this.TxtHe.Size = new System.Drawing.Size(118, 26);
            this.TxtHe.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ingrese Precio  por Hora Extra";
            // 
            // TxtPhe
            // 
            this.TxtPhe.Location = new System.Drawing.Point(289, 182);
            this.TxtPhe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPhe.Name = "TxtPhe";
            this.TxtPhe.Size = new System.Drawing.Size(118, 26);
            this.TxtPhe.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "El Salario Base por dia es:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "El Salario por Horas Extras es:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 25;
            // 
            // TxtSalarioExtra
            // 
            this.TxtSalarioExtra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtSalarioExtra.Location = new System.Drawing.Point(289, 279);
            this.TxtSalarioExtra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalarioExtra.Name = "TxtSalarioExtra";
            this.TxtSalarioExtra.ReadOnly = true;
            this.TxtSalarioExtra.Size = new System.Drawing.Size(118, 26);
            this.TxtSalarioExtra.TabIndex = 26;
            this.TxtSalarioExtra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtSalarioNeto
            // 
            this.TxtSalarioNeto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtSalarioNeto.Location = new System.Drawing.Point(162, 317);
            this.TxtSalarioNeto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalarioNeto.Name = "TxtSalarioNeto";
            this.TxtSalarioNeto.ReadOnly = true;
            this.TxtSalarioNeto.Size = new System.Drawing.Size(118, 26);
            this.TxtSalarioNeto.TabIndex = 27;
            // 
            // FrmSalarioenBaseaHorasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 361);
            this.Controls.Add(this.TxtSalarioNeto);
            this.Controls.Add(this.TxtSalarioExtra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPhe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSalarioBase);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSalarioenBaseaHorasExtras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de Salarios en base a Dias Trabajados y Horas Extras.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtSalarioBase;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtHe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSalarioExtra;
        private System.Windows.Forms.TextBox TxtSalarioNeto;
    }
}