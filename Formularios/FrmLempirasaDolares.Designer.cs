namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmLempirasaDolares
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
            this.TxtLempiras = new System.Windows.Forms.TextBox();
            this.BtnConversor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDolares = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.Location = new System.Drawing.Point(280, 209);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese Valores a Convertir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese la Cantidad en Lempiras ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtLempiras
            // 
            this.TxtLempiras.Location = new System.Drawing.Point(267, 59);
            this.TxtLempiras.Name = "TxtLempiras";
            this.TxtLempiras.Size = new System.Drawing.Size(104, 26);
            this.TxtLempiras.TabIndex = 5;
            // 
            // BtnConversor
            // 
            this.BtnConversor.Location = new System.Drawing.Point(16, 99);
            this.BtnConversor.Name = "BtnConversor";
            this.BtnConversor.Size = new System.Drawing.Size(95, 31);
            this.BtnConversor.TabIndex = 6;
            this.BtnConversor.Text = "Conversor";
            this.BtnConversor.UseVisualStyleBackColor = true;
            this.BtnConversor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "El Total en Dolares es:";
            // 
            // TxtDolares
            // 
            this.TxtDolares.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtDolares.Location = new System.Drawing.Point(176, 167);
            this.TxtDolares.Name = "TxtDolares";
            this.TxtDolares.ReadOnly = true;
            this.TxtDolares.Size = new System.Drawing.Size(104, 26);
            this.TxtDolares.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(176, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmLempirasaDolares
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(382, 257);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDolares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnConversor);
            this.Controls.Add(this.TxtLempiras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLempirasaDolares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Lempiras a Dolares.";
            this.Load += new System.EventHandler(this.FrmLempirasaDolares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLempiras;
        private System.Windows.Forms.Button BtnConversor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDolares;
        private System.Windows.Forms.Button button1;
    }
}