namespace IntraPDV
{
    partial class Cobro
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
            this.CantidadPago = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.TotalVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DarCambio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CantidadPago
            // 
            this.CantidadPago.Location = new System.Drawing.Point(139, 50);
            this.CantidadPago.Name = "CantidadPago";
            this.CantidadPago.Size = new System.Drawing.Size(102, 20);
            this.CantidadPago.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cobrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pago con:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(59, 111);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(34, 13);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Total ";
            // 
            // TotalVenta
            // 
            this.TotalVenta.AutoSize = true;
            this.TotalVenta.Location = new System.Drawing.Point(228, 111);
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Size = new System.Drawing.Size(13, 13);
            this.TotalVenta.TabIndex = 4;
            this.TotalVenta.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cambio";
            // 
            // DarCambio
            // 
            this.DarCambio.AutoSize = true;
            this.DarCambio.Location = new System.Drawing.Point(228, 216);
            this.DarCambio.Name = "DarCambio";
            this.DarCambio.Size = new System.Drawing.Size(13, 13);
            this.DarCambio.TabIndex = 6;
            this.DarCambio.Text = "0";
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 363);
            this.Controls.Add(this.DarCambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalVenta);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CantidadPago);
            this.Name = "Cobro";
            this.Text = "Cobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CantidadPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label TotalVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DarCambio;
    }
}