namespace IntraPDV
{
    partial class venta_diaria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venta_diaria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.PictureBox();
            this.imprimir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.dataGridTotal = new System.Windows.Forms.DataGridView();
            this.totalEnTexto = new System.Windows.Forms.Label();
            this.testT = new System.Windows.Forms.Label();
            this.totalApartados = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelAnticipo = new System.Windows.Forms.Label();
            this.pagosDiarios = new System.Windows.Forms.DataGridView();
            this.labelPagos = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.labelAnticipos = new System.Windows.Forms.Label();
            this.totalDiario = new System.Windows.Forms.Label();
            this.labelPagoText = new System.Windows.Forms.Label();
            this.texto3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalApartados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosDiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1229, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar Fecha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 39);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la  fecha a consultar";
            // 
            // BackMenu
            // 
            this.BackMenu.Image = ((System.Drawing.Image)(resources.GetObject("BackMenu.Image")));
            this.BackMenu.Location = new System.Drawing.Point(0, -2);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(47, 42);
            this.BackMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackMenu.TabIndex = 3;
            this.BackMenu.TabStop = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // imprimir
            // 
            this.imprimir.BackColor = System.Drawing.Color.PaleGreen;
            this.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.Location = new System.Drawing.Point(387, 627);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(204, 40);
            this.imprimir.TabIndex = 5;
            this.imprimir.Text = "Imprimir reporte.";
            this.imprimir.UseVisualStyleBackColor = false;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(420, 33);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(706, 599);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(133, 23);
            this.test.TabIndex = 9;
            this.test.Text = "TOTAL VENTA:";
            // 
            // dataGridTotal
            // 
            this.dataGridTotal.AllowUserToAddRows = false;
            this.dataGridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTotal.Location = new System.Drawing.Point(992, 45);
            this.dataGridTotal.Name = "dataGridTotal";
            this.dataGridTotal.Size = new System.Drawing.Size(230, 47);
            this.dataGridTotal.TabIndex = 10;
            this.dataGridTotal.Visible = false;
            // 
            // totalEnTexto
            // 
            this.totalEnTexto.AutoSize = true;
            this.totalEnTexto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnTexto.Location = new System.Drawing.Point(870, 599);
            this.totalEnTexto.Name = "totalEnTexto";
            this.totalEnTexto.Size = new System.Drawing.Size(21, 23);
            this.totalEnTexto.TabIndex = 11;
            this.totalEnTexto.Text = "0";
            // 
            // testT
            // 
            this.testT.AutoSize = true;
            this.testT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testT.Location = new System.Drawing.Point(1019, 644);
            this.testT.Name = "testT";
            this.testT.Size = new System.Drawing.Size(106, 23);
            this.testT.TabIndex = 12;
            this.testT.Text = "TOTAL DIA:";
            // 
            // totalApartados
            // 
            this.totalApartados.AllowUserToAddRows = false;
            this.totalApartados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.totalApartados.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalApartados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.totalApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.totalApartados.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalApartados.GridColor = System.Drawing.Color.Black;
            this.totalApartados.Location = new System.Drawing.Point(12, 111);
            this.totalApartados.Name = "totalApartados";
            this.totalApartados.Size = new System.Drawing.Size(647, 392);
            this.totalApartados.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Wheat;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(229, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ver pagos.";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAnticipo
            // 
            this.labelAnticipo.AutoSize = true;
            this.labelAnticipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnticipo.Location = new System.Drawing.Point(12, 85);
            this.labelAnticipo.Name = "labelAnticipo";
            this.labelAnticipo.Size = new System.Drawing.Size(96, 23);
            this.labelAnticipo.TabIndex = 15;
            this.labelAnticipo.Text = "Anticipos";
            this.labelAnticipo.Visible = false;
            // 
            // pagosDiarios
            // 
            this.pagosDiarios.AllowUserToAddRows = false;
            this.pagosDiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.pagosDiarios.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pagosDiarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.pagosDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pagosDiarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.pagosDiarios.GridColor = System.Drawing.Color.Black;
            this.pagosDiarios.Location = new System.Drawing.Point(665, 111);
            this.pagosDiarios.Name = "pagosDiarios";
            this.pagosDiarios.Size = new System.Drawing.Size(576, 392);
            this.pagosDiarios.TabIndex = 16;
            // 
            // labelPagos
            // 
            this.labelPagos.AutoSize = true;
            this.labelPagos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagos.Location = new System.Drawing.Point(661, 81);
            this.labelPagos.Name = "labelPagos";
            this.labelPagos.Size = new System.Drawing.Size(67, 23);
            this.labelPagos.TabIndex = 17;
            this.labelPagos.Text = "Pagos";
            this.labelPagos.Visible = false;
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(706, 635);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(150, 23);
            this.texto1.TabIndex = 18;
            this.texto1.Text = "Total Anticipos:";
            // 
            // labelAnticipos
            // 
            this.labelAnticipos.AutoSize = true;
            this.labelAnticipos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnticipos.Location = new System.Drawing.Point(870, 635);
            this.labelAnticipos.Name = "labelAnticipos";
            this.labelAnticipos.Size = new System.Drawing.Size(21, 23);
            this.labelAnticipos.TabIndex = 19;
            this.labelAnticipos.Text = "0";
            // 
            // totalDiario
            // 
            this.totalDiario.AutoSize = true;
            this.totalDiario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDiario.Location = new System.Drawing.Point(1147, 644);
            this.totalDiario.Name = "totalDiario";
            this.totalDiario.Size = new System.Drawing.Size(48, 23);
            this.totalDiario.TabIndex = 20;
            this.totalDiario.Text = "0.00";
            // 
            // labelPagoText
            // 
            this.labelPagoText.AutoSize = true;
            this.labelPagoText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagoText.Location = new System.Drawing.Point(870, 676);
            this.labelPagoText.Name = "labelPagoText";
            this.labelPagoText.Size = new System.Drawing.Size(21, 23);
            this.labelPagoText.TabIndex = 22;
            this.labelPagoText.Text = "0";
            // 
            // texto3
            // 
            this.texto3.AutoSize = true;
            this.texto3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto3.Location = new System.Drawing.Point(706, 676);
            this.texto3.Name = "texto3";
            this.texto3.Size = new System.Drawing.Size(121, 23);
            this.texto3.TabIndex = 21;
            this.texto3.Text = "Total Pagos:";
            // 
            // venta_diaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 717);
            this.Controls.Add(this.labelPagoText);
            this.Controls.Add(this.texto3);
            this.Controls.Add(this.totalDiario);
            this.Controls.Add(this.labelAnticipos);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.labelPagos);
            this.Controls.Add(this.pagosDiarios);
            this.Controls.Add(this.labelAnticipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalApartados);
            this.Controls.Add(this.testT);
            this.Controls.Add(this.totalEnTexto);
            this.Controls.Add(this.dataGridTotal);
            this.Controls.Add(this.test);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "venta_diaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "venta_diaria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalApartados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosDiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BackMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.DataGridView dataGridTotal;
        private System.Windows.Forms.Label totalEnTexto;
        private System.Windows.Forms.Label testT;
        private System.Windows.Forms.DataGridView totalApartados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelAnticipo;
        private System.Windows.Forms.DataGridView pagosDiarios;
        private System.Windows.Forms.Label labelPagos;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Label labelAnticipos;
        private System.Windows.Forms.Label totalDiario;
        private System.Windows.Forms.Label labelPagoText;
        private System.Windows.Forms.Label texto3;
    }
}