namespace IntraPDV
{
    partial class interfazApartado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoBarras = new System.Windows.Forms.TextBox();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.guardarInformacion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idClienteDelete = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabla_clientes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cambioLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cajaAnticipotxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalSumapts = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idClientetxt = new System.Windows.Forms.Label();
            this.nombreClientetxt = new System.Windows.Forms.Label();
            this.cantidadRestante = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.importe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folio = new System.Windows.Forms.Label();
            this.horaActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_clientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo de Producto:";
            // 
            // codigoBarras
            // 
            this.codigoBarras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBarras.Location = new System.Drawing.Point(16, 45);
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.Size = new System.Drawing.Size(138, 27);
            this.codigoBarras.TabIndex = 1;
            this.codigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar);
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaProductos.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle18;
            this.tablaProductos.Location = new System.Drawing.Point(12, 285);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.Size = new System.Drawing.Size(864, 252);
            this.tablaProductos.TabIndex = 6;
            this.tablaProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cambios);
            // 
            // guardarInformacion
            // 
            this.guardarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarInformacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarInformacion.Location = new System.Drawing.Point(676, 543);
            this.guardarInformacion.Name = "guardarInformacion";
            this.guardarInformacion.Size = new System.Drawing.Size(100, 31);
            this.guardarInformacion.TabIndex = 4;
            this.guardarInformacion.Text = "Guardar";
            this.guardarInformacion.UseVisualStyleBackColor = true;
            this.guardarInformacion.Click += new System.EventHandler(this.guardarInformacion_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(783, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 15);
            this.panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idClienteDelete);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tabla_clientes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(557, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 276);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // idClienteDelete
            // 
            this.idClienteDelete.AutoSize = true;
            this.idClienteDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteDelete.Location = new System.Drawing.Point(126, 40);
            this.idClienteDelete.Name = "idClienteDelete";
            this.idClienteDelete.Size = new System.Drawing.Size(36, 19);
            this.idClienteDelete.TabIndex = 33;
            this.idClienteDelete.Text = "000";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::IntraPDV.Properties.Resources.añadirCliente1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(226, 30);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3);
            this.button3.Size = new System.Drawing.Size(63, 39);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::IntraPDV.Properties.Resources.añadirCliente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 33);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(66, 39);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabla_clientes
            // 
            this.tabla_clientes.AllowUserToAddRows = false;
            this.tabla_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tabla_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_clientes.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.tabla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_clientes.DefaultCellStyle = dataGridViewCellStyle20;
            this.tabla_clientes.Location = new System.Drawing.Point(6, 100);
            this.tabla_clientes.Name = "tabla_clientes";
            this.tabla_clientes.Size = new System.Drawing.Size(308, 170);
            this.tabla_clientes.TabIndex = 19;
            this.tabla_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Clientsclick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Agregar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lista de productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.cambioLabel);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.cajaAnticipotxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.totalSumapts);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.idClientetxt);
            this.groupBox2.Controls.Add(this.nombreClientetxt);
            this.groupBox2.Controls.Add(this.cantidadRestante);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.importe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 203);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(420, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 36);
            this.button4.TabIndex = 40;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(307, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 36);
            this.button5.TabIndex = 39;
            this.button5.Text = "Continuar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cambioLabel
            // 
            this.cambioLabel.AutoSize = true;
            this.cambioLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioLabel.Location = new System.Drawing.Point(415, 38);
            this.cambioLabel.Name = "cambioLabel";
            this.cambioLabel.Size = new System.Drawing.Size(48, 23);
            this.cambioLabel.TabIndex = 38;
            this.cambioLabel.Text = "0.00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(319, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 19);
            this.label.TabIndex = 37;
            this.label.Text = "Cambio $:";
            // 
            // cajaAnticipotxt
            // 
            this.cajaAnticipotxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaAnticipotxt.Location = new System.Drawing.Point(93, 107);
            this.cajaAnticipotxt.Name = "cajaAnticipotxt";
            this.cajaAnticipotxt.Size = new System.Drawing.Size(106, 26);
            this.cajaAnticipotxt.TabIndex = 35;
            this.cajaAnticipotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.operation_press);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Anticipo:";
            // 
            // totalSumapts
            // 
            this.totalSumapts.AutoSize = true;
            this.totalSumapts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSumapts.Location = new System.Drawing.Point(415, 94);
            this.totalSumapts.Name = "totalSumapts";
            this.totalSumapts.Size = new System.Drawing.Size(48, 23);
            this.totalSumapts.TabIndex = 34;
            this.totalSumapts.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total $:";
            // 
            // idClientetxt
            // 
            this.idClientetxt.AutoSize = true;
            this.idClientetxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClientetxt.Location = new System.Drawing.Point(209, 25);
            this.idClientetxt.Name = "idClientetxt";
            this.idClientetxt.Size = new System.Drawing.Size(36, 19);
            this.idClientetxt.TabIndex = 32;
            this.idClientetxt.Text = "000";
            // 
            // nombreClientetxt
            // 
            this.nombreClientetxt.AutoSize = true;
            this.nombreClientetxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClientetxt.Location = new System.Drawing.Point(102, 26);
            this.nombreClientetxt.Name = "nombreClientetxt";
            this.nombreClientetxt.Size = new System.Drawing.Size(25, 19);
            this.nombreClientetxt.TabIndex = 31;
            this.nombreClientetxt.Text = "....";
            // 
            // cantidadRestante
            // 
            this.cantidadRestante.AutoSize = true;
            this.cantidadRestante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadRestante.Location = new System.Drawing.Point(415, 66);
            this.cantidadRestante.Name = "cantidadRestante";
            this.cantidadRestante.Size = new System.Drawing.Size(48, 23);
            this.cantidadRestante.TabIndex = 30;
            this.cantidadRestante.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Resta $:";
            // 
            // importe
            // 
            this.importe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importe.Location = new System.Drawing.Point(93, 67);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(106, 26);
            this.importe.TabIndex = 27;
            this.importe.TextChanged += new System.EventHandler(this.addInfo_txtChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Apartar a:";
            // 
            // folio
            // 
            this.folio.AutoSize = true;
            this.folio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folio.Location = new System.Drawing.Point(293, 53);
            this.folio.Name = "folio";
            this.folio.Size = new System.Drawing.Size(0, 19);
            this.folio.TabIndex = 33;
            // 
            // horaActual
            // 
            this.horaActual.AutoSize = true;
            this.horaActual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaActual.Location = new System.Drawing.Point(428, 53);
            this.horaActual.Name = "horaActual";
            this.horaActual.Size = new System.Drawing.Size(0, 19);
            this.horaActual.TabIndex = 34;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // interfazApartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 592);
            this.Controls.Add(this.horaActual);
            this.Controls.Add(this.folio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guardarInformacion);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.codigoBarras);
            this.Controls.Add(this.label2);
            this.Name = "interfazApartado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Apartado";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_clientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoBarras;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Button guardarInformacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabla_clientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cambioLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox cajaAnticipotxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalSumapts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label idClientetxt;
        private System.Windows.Forms.Label nombreClientetxt;
        private System.Windows.Forms.Label cantidadRestante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox importe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label folio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label idClienteDelete;
        private System.Windows.Forms.Label horaActual;
        private System.Windows.Forms.Timer timer1;
    }
}