namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmConversordeMillasaMetros
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
            this.TxtMillas = new System.Windows.Forms.TextBox();
            this.BtmConvertir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.Location = new System.Drawing.Point(265, 209);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 36);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar Valores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese las Millas a Convertir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtMillas
            // 
            this.TxtMillas.Location = new System.Drawing.Point(235, 77);
            this.TxtMillas.Name = "TxtMillas";
            this.TxtMillas.Size = new System.Drawing.Size(105, 26);
            this.TxtMillas.TabIndex = 5;
            this.TxtMillas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtmConvertir
            // 
            this.BtmConvertir.Location = new System.Drawing.Point(16, 111);
            this.BtmConvertir.Name = "BtmConvertir";
            this.BtmConvertir.Size = new System.Drawing.Size(110, 33);
            this.BtmConvertir.TabIndex = 6;
            this.BtmConvertir.Text = "Convertir";
            this.BtmConvertir.UseVisualStyleBackColor = true;
            this.BtmConvertir.Click += new System.EventHandler(this.BtmConvertir_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "El Total de Metros es:";
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtResultado.Location = new System.Drawing.Point(178, 164);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(106, 26);
            this.TxtResultado.TabIndex = 8;
            this.TxtResultado.TextChanged += new System.EventHandler(this.TxtResultado_TextChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(168, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConversordeMillasaMetros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(368, 257);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtmConvertir);
            this.Controls.Add(this.TxtMillas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmConversordeMillasaMetros";
            this.Text = "Conversor de Millas a Metros.";
            this.Load += new System.EventHandler(this.FrmConversordeMillasaMetros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMillas;
        private System.Windows.Forms.Button BtmConvertir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button button1;
    }
}