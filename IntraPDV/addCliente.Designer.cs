namespace IntraPDV
{
    partial class addCliente
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
            this.clname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupDelete = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.client_List = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.delete_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // clname
            // 
            this.clname.Location = new System.Drawing.Point(116, 45);
            this.clname.Name = "clname";
            this.clname.Size = new System.Drawing.Size(271, 27);
            this.clname.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clname);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agrega un cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 10);
            this.panel2.TabIndex = 13;
            // 
            // groupDelete
            // 
            this.groupDelete.Controls.Add(this.label3);
            this.groupDelete.Controls.Add(this.client_List);
            this.groupDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDelete.Location = new System.Drawing.Point(12, 25);
            this.groupDelete.Name = "groupDelete";
            this.groupDelete.Size = new System.Drawing.Size(387, 193);
            this.groupDelete.TabIndex = 15;
            this.groupDelete.TabStop = false;
            this.groupDelete.Text = "Eliminar cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clientes Guardados";
            // 
            // client_List
            // 
            this.client_List.FormattingEnabled = true;
            this.client_List.Location = new System.Drawing.Point(15, 59);
            this.client_List.Name = "client_List";
            this.client_List.Size = new System.Drawing.Size(351, 27);
            this.client_List.TabIndex = 0;
            this.client_List.Click += new System.EventHandler(this.consultaClientes);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.BackColor = System.Drawing.Color.White;
            this.cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.Location = new System.Drawing.Point(334, 224);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(99, 32);
            this.cancel_Btn.TabIndex = 16;
            this.cancel_Btn.Text = "Cancelar";
            this.cancel_Btn.UseVisualStyleBackColor = false;
            // 
            // delete_Btn
            // 
            this.delete_Btn.BackColor = System.Drawing.Color.IndianRed;
            this.delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Btn.ForeColor = System.Drawing.Color.White;
            this.delete_Btn.Location = new System.Drawing.Point(208, 224);
            this.delete_Btn.Name = "delete_Btn";
            this.delete_Btn.Size = new System.Drawing.Size(110, 32);
            this.delete_Btn.TabIndex = 17;
            this.delete_Btn.Text = "Eliminar";
            this.delete_Btn.UseVisualStyleBackColor = false;
            this.delete_Btn.Click += new System.EventHandler(this.delete_Btn_Click);
            // 
            // addCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 290);
            this.Controls.Add(this.delete_Btn);
            this.Controls.Add(this.groupDelete);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupDelete.ResumeLayout(false);
            this.groupDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox clname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox client_List;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox groupDelete;
        public System.Windows.Forms.Button cancel_Btn;
        public System.Windows.Forms.Button delete_Btn;
    }
}