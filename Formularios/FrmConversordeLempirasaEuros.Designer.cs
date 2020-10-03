namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmConversordeLempirasaEuros
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLps = new System.Windows.Forms.TextBox();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEuros = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(69, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ingrese Valores";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ingrese la cantidad en Lempiras";
            // 
            // TxtLps
            // 
            this.TxtLps.Location = new System.Drawing.Point(260, 94);
            this.TxtLps.Name = "TxtLps";
            this.TxtLps.Size = new System.Drawing.Size(116, 26);
            this.TxtLps.TabIndex = 4;
            this.TxtLps.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Location = new System.Drawing.Point(15, 141);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(96, 34);
            this.BtnConvertir.TabIndex = 5;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "El Total en Euros es:";
            // 
            // TxtEuros
            // 
            this.TxtEuros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtEuros.Location = new System.Drawing.Point(163, 191);
            this.TxtEuros.Name = "TxtEuros";
            this.TxtEuros.ReadOnly = true;
            this.TxtEuros.Size = new System.Drawing.Size(116, 26);
            this.TxtEuros.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(163, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmConversordeLempirasaEuros
            // 
            this.ClientSize = new System.Drawing.Size(392, 271);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtEuros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.TxtLps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmConversordeLempirasaEuros";
            this.Text = "Conversor de Lempiras a Euros.";
            this.Load += new System.EventHandler(this.FrmConversordeLempirasaEuros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLps;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEuros;
        private System.Windows.Forms.Button button2;
    }
}