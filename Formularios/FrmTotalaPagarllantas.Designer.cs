namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    partial class FrmTotalaPagarllantas
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
            this.LblLlantera = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtImpto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalISV = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.Location = new System.Drawing.Point(278, 310);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 36);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblLlantera
            // 
            this.LblLlantera.BackColor = System.Drawing.Color.Teal;
            this.LblLlantera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblLlantera.Location = new System.Drawing.Point(89, 9);
            this.LblLlantera.Name = "LblLlantera";
            this.LblLlantera.Size = new System.Drawing.Size(189, 31);
            this.LblLlantera.TabIndex = 3;
            this.LblLlantera.Text = "Facturacion Por LLantas";
            this.LblLlantera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(12, 74);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(236, 20);
            this.C.TabIndex = 4;
            this.C.Text = "Ingrese Cantidad del Producto";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(263, 74);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(100, 26);
            this.TxtProducto.TabIndex = 5;
            this.TxtProducto.TextChanged += new System.EventHandler(this.TxtProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese Precio del Producto";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(263, 110);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 26);
            this.TxtPrecio.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Impuesto del Producto";
            // 
            // TxtImpto
            // 
            this.TxtImpto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtImpto.Location = new System.Drawing.Point(263, 146);
            this.TxtImpto.Name = "TxtImpto";
            this.TxtImpto.ReadOnly = true;
            this.TxtImpto.Size = new System.Drawing.Size(100, 26);
            this.TxtImpto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total a Pagar sin ISV";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtTotal.Location = new System.Drawing.Point(172, 226);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 26);
            this.TxtTotal.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total a Pagar + ISV";
            // 
            // TxtTotalISV
            // 
            this.TxtTotalISV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtTotalISV.Location = new System.Drawing.Point(172, 257);
            this.TxtTotalISV.Name = "TxtTotalISV";
            this.TxtTotalISV.ReadOnly = true;
            this.TxtTotalISV.Size = new System.Drawing.Size(100, 26);
            this.TxtTotalISV.TabIndex = 15;
            this.TxtTotalISV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(181, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmTotalaPagarllantas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(381, 358);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtTotalISV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtImpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.C);
            this.Controls.Add(this.LblLlantera);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTotalaPagarllantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total a pagar por la Compra de Llantas.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblLlantera;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtImpto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalISV;
        private System.Windows.Forms.Button button2;
    }
}