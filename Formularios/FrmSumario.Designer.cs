namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmSumario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrimerValor = new System.Windows.Forms.TextBox();
            this.TxtSegundoValor = new System.Windows.Forms.TextBox();
            this.TxtTercerValor = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.Location = new System.Drawing.Point(272, 264);
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
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESAR LOS DATOS DE LA SUMA ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese Primer Valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese Segundo Valor";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese Tercer Valor";
            // 
            // TxtPrimerValor
            // 
            this.TxtPrimerValor.Location = new System.Drawing.Point(229, 55);
            this.TxtPrimerValor.Name = "TxtPrimerValor";
            this.TxtPrimerValor.Size = new System.Drawing.Size(120, 26);
            this.TxtPrimerValor.TabIndex = 7;
            this.TxtPrimerValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtSegundoValor
            // 
            this.TxtSegundoValor.Location = new System.Drawing.Point(229, 91);
            this.TxtSegundoValor.Name = "TxtSegundoValor";
            this.TxtSegundoValor.Size = new System.Drawing.Size(120, 26);
            this.TxtSegundoValor.TabIndex = 8;
            this.TxtSegundoValor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtTercerValor
            // 
            this.TxtTercerValor.Location = new System.Drawing.Point(229, 127);
            this.TxtTercerValor.Name = "TxtTercerValor";
            this.TxtTercerValor.Size = new System.Drawing.Size(120, 26);
            this.TxtTercerValor.TabIndex = 9;
            this.TxtTercerValor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(15, 162);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(99, 27);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado.";
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtResultado.Location = new System.Drawing.Point(95, 229);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(120, 26);
            this.TxtResultado.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(168, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSumario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(375, 312);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtTercerValor);
            this.Controls.Add(this.TxtSegundoValor);
            this.Controls.Add(this.TxtPrimerValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSumario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular la Suma de Tres Numeros.";
            this.Load += new System.EventHandler(this.FrmSumario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrimerValor;
        private System.Windows.Forms.TextBox TxtSegundoValor;
        private System.Windows.Forms.TextBox TxtTercerValor;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button button1;
    }
}