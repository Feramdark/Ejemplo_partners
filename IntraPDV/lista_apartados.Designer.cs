namespace IntraPDV
{
    partial class lista_apartados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableCuentas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.montoTotaltxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaAbonotxt = new System.Windows.Forms.TextBox();
            this.cajaPagotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.folioTexto = new System.Windows.Forms.Label();
            this.idClientLabel = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idApartLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAnticipo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cambioLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.restanteLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.abonoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pagoClienteLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listaProductosCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaPagos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelSumaPagos = new System.Windows.Forms.Label();
            this.labelMontoAbonado = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.entregarProducto = new System.Windows.Forms.Button();
            this.total_deuda = new System.Windows.Forms.Label();
            this.idproducto_label = new System.Windows.Forms.Label();
            this.cantidadProductolabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.idPtoApartadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableCuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPagos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableCuentas
            // 
            this.tableCuentas.AllowUserToAddRows = false;
            this.tableCuentas.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tableCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCuentas.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableCuentas.Location = new System.Drawing.Point(12, 395);
            this.tableCuentas.Name = "tableCuentas";
            this.tableCuentas.Size = new System.Drawing.Size(627, 218);
            this.tableCuentas.TabIndex = 0;
            this.tableCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetInfoClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(294, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Realizar Cobro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(454, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Restante $";
            // 
            // montoTotaltxt
            // 
            this.montoTotaltxt.AutoSize = true;
            this.montoTotaltxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTotaltxt.Location = new System.Drawing.Point(450, 115);
            this.montoTotaltxt.Name = "montoTotaltxt";
            this.montoTotaltxt.Size = new System.Drawing.Size(40, 19);
            this.montoTotaltxt.TabIndex = 6;
            this.montoTotaltxt.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pago";
            // 
            // cajaAbonotxt
            // 
            this.cajaAbonotxt.Location = new System.Drawing.Point(14, 220);
            this.cajaAbonotxt.Name = "cajaAbonotxt";
            this.cajaAbonotxt.Size = new System.Drawing.Size(160, 27);
            this.cajaAbonotxt.TabIndex = 8;
            this.cajaAbonotxt.TextChanged += new System.EventHandler(this.addQuantity);
            // 
            // cajaPagotxt
            // 
            this.cajaPagotxt.Location = new System.Drawing.Point(10, 156);
            this.cajaPagotxt.Name = "cajaPagotxt";
            this.cajaPagotxt.Size = new System.Drawing.Size(98, 27);
            this.cajaPagotxt.TabIndex = 9;
            this.cajaPagotxt.TextChanged += new System.EventHandler(this.addQuantity);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad a abonar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.folioTexto);
            this.groupBox1.Controls.Add(this.idClientLabel);
            this.groupBox1.Controls.Add(this.nameClient);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.idApartLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelAnticipo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cambioLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.restanteLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.abonoLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pagoClienteLabel);
            this.groupBox1.Controls.Add(this.cajaAbonotxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cajaPagotxt);
            this.groupBox1.Controls.Add(this.montoTotaltxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 328);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abonar a un Apartado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 19);
            this.label13.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Folio:";
            // 
            // folioTexto
            // 
            this.folioTexto.AutoSize = true;
            this.folioTexto.Location = new System.Drawing.Point(450, 23);
            this.folioTexto.Name = "folioTexto";
            this.folioTexto.Size = new System.Drawing.Size(36, 19);
            this.folioTexto.TabIndex = 26;
            this.folioTexto.Text = "000";
            // 
            // idClientLabel
            // 
            this.idClientLabel.AutoSize = true;
            this.idClientLabel.Location = new System.Drawing.Point(112, 97);
            this.idClientLabel.Name = "idClientLabel";
            this.idClientLabel.Size = new System.Drawing.Size(29, 19);
            this.idClientLabel.TabIndex = 25;
            this.idClientLabel.Text = ".....";
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Location = new System.Drawing.Point(8, 97);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(29, 19);
            this.nameClient.TabIndex = 24;
            this.nameClient.Text = ".....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nombre Cliente";
            // 
            // idApartLabel
            // 
            this.idApartLabel.AutoSize = true;
            this.idApartLabel.Location = new System.Drawing.Point(123, 31);
            this.idApartLabel.Name = "idApartLabel";
            this.idApartLabel.Size = new System.Drawing.Size(36, 19);
            this.idApartLabel.TabIndex = 20;
            this.idApartLabel.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Anticipo Inicial$";
            // 
            // labelAnticipo
            // 
            this.labelAnticipo.AutoSize = true;
            this.labelAnticipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnticipo.Location = new System.Drawing.Point(450, 57);
            this.labelAnticipo.Name = "labelAnticipo";
            this.labelAnticipo.Size = new System.Drawing.Size(40, 19);
            this.labelAnticipo.TabIndex = 16;
            this.labelAnticipo.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID Apartado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cambio $";
            // 
            // cambioLabel
            // 
            this.cambioLabel.AutoSize = true;
            this.cambioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioLabel.Location = new System.Drawing.Point(450, 208);
            this.cambioLabel.Name = "cambioLabel";
            this.cambioLabel.Size = new System.Drawing.Size(40, 19);
            this.cambioLabel.TabIndex = 18;
            this.cambioLabel.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Debe $";
            // 
            // restanteLabel
            // 
            this.restanteLabel.AutoSize = true;
            this.restanteLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restanteLabel.Location = new System.Drawing.Point(450, 239);
            this.restanteLabel.Name = "restanteLabel";
            this.restanteLabel.Size = new System.Drawing.Size(40, 19);
            this.restanteLabel.TabIndex = 16;
            this.restanteLabel.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Abono $";
            // 
            // abonoLabel
            // 
            this.abonoLabel.AutoSize = true;
            this.abonoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonoLabel.Location = new System.Drawing.Point(450, 177);
            this.abonoLabel.Name = "abonoLabel";
            this.abonoLabel.Size = new System.Drawing.Size(40, 19);
            this.abonoLabel.TabIndex = 14;
            this.abonoLabel.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pago $";
            // 
            // pagoClienteLabel
            // 
            this.pagoClienteLabel.AutoSize = true;
            this.pagoClienteLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoClienteLabel.Location = new System.Drawing.Point(450, 146);
            this.pagoClienteLabel.Name = "pagoClienteLabel";
            this.pagoClienteLabel.Size = new System.Drawing.Size(40, 19);
            this.pagoClienteLabel.TabIndex = 12;
            this.pagoClienteLabel.Text = "0.00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(905, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // listaProductosCliente
            // 
            this.listaProductosCliente.AllowUserToAddRows = false;
            this.listaProductosCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaProductosCliente.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProductosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.listaProductosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaProductosCliente.DefaultCellStyle = dataGridViewCellStyle10;
            this.listaProductosCliente.Location = new System.Drawing.Point(20, 26);
            this.listaProductosCliente.Name = "listaProductosCliente";
            this.listaProductosCliente.Size = new System.Drawing.Size(501, 218);
            this.listaProductosCliente.TabIndex = 13;
            this.listaProductosCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Getptos);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaPagos);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(664, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 207);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagos";
            // 
            // listaPagos
            // 
            this.listaPagos.AllowUserToAddRows = false;
            this.listaPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.listaPagos.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.listaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaPagos.DefaultCellStyle = dataGridViewCellStyle12;
            this.listaPagos.Location = new System.Drawing.Point(19, 25);
            this.listaPagos.Name = "listaPagos";
            this.listaPagos.Size = new System.Drawing.Size(502, 162);
            this.listaPagos.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listaProductosCliente);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(664, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 256);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(664, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Suma Pagos $";
            // 
            // labelSumaPagos
            // 
            this.labelSumaPagos.AutoSize = true;
            this.labelSumaPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaPagos.Location = new System.Drawing.Point(871, 259);
            this.labelSumaPagos.Name = "labelSumaPagos";
            this.labelSumaPagos.Size = new System.Drawing.Size(40, 19);
            this.labelSumaPagos.TabIndex = 19;
            this.labelSumaPagos.Text = "0.00";
            // 
            // labelMontoAbonado
            // 
            this.labelMontoAbonado.AutoSize = true;
            this.labelMontoAbonado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoAbonado.Location = new System.Drawing.Point(871, 285);
            this.labelMontoAbonado.Name = "labelMontoAbonado";
            this.labelMontoAbonado.Size = new System.Drawing.Size(40, 19);
            this.labelMontoAbonado.TabIndex = 21;
            this.labelMontoAbonado.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(664, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "Total Abonado $";
            // 
            // entregarProducto
            // 
            this.entregarProducto.BackColor = System.Drawing.Color.MediumAquamarine;
            this.entregarProducto.Enabled = false;
            this.entregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entregarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregarProducto.Location = new System.Drawing.Point(1040, 333);
            this.entregarProducto.Name = "entregarProducto";
            this.entregarProducto.Size = new System.Drawing.Size(145, 36);
            this.entregarProducto.TabIndex = 22;
            this.entregarProducto.Text = "Entregar Articulo";
            this.entregarProducto.UseVisualStyleBackColor = false;
            this.entregarProducto.Click += new System.EventHandler(this.button3_Click);
            // 
            // total_deuda
            // 
            this.total_deuda.AutoSize = true;
            this.total_deuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_deuda.Location = new System.Drawing.Point(664, 341);
            this.total_deuda.Name = "total_deuda";
            this.total_deuda.Size = new System.Drawing.Size(40, 19);
            this.total_deuda.TabIndex = 22;
            this.total_deuda.Text = "0.00";
            this.total_deuda.Visible = false;
            // 
            // idproducto_label
            // 
            this.idproducto_label.AutoSize = true;
            this.idproducto_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idproducto_label.Location = new System.Drawing.Point(828, 351);
            this.idproducto_label.Name = "idproducto_label";
            this.idproducto_label.Size = new System.Drawing.Size(40, 19);
            this.idproducto_label.TabIndex = 23;
            this.idproducto_label.Text = "0.00";
            // 
            // cantidadProductolabel
            // 
            this.cantidadProductolabel.AutoSize = true;
            this.cantidadProductolabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadProductolabel.Location = new System.Drawing.Point(874, 351);
            this.cantidadProductolabel.Name = "cantidadProductolabel";
            this.cantidadProductolabel.Size = new System.Drawing.Size(40, 19);
            this.cantidadProductolabel.TabIndex = 24;
            this.cantidadProductolabel.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "Cuentas";
            // 
            // idPtoApartadoLabel
            // 
            this.idPtoApartadoLabel.AutoSize = true;
            this.idPtoApartadoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPtoApartadoLabel.Location = new System.Drawing.Point(751, 351);
            this.idPtoApartadoLabel.Name = "idPtoApartadoLabel";
            this.idPtoApartadoLabel.Size = new System.Drawing.Size(40, 19);
            this.idPtoApartadoLabel.TabIndex = 26;
            this.idPtoApartadoLabel.Text = "0.00";
            // 
            // lista_apartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 641);
            this.Controls.Add(this.idPtoApartadoLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cantidadProductolabel);
            this.Controls.Add(this.idproducto_label);
            this.Controls.Add(this.total_deuda);
            this.Controls.Add(this.entregarProducto);
            this.Controls.Add(this.labelMontoAbonado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelSumaPagos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableCuentas);
            this.Name = "lista_apartados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Apartados";
            this.Load += new System.EventHandler(this.showAps);
            ((System.ComponentModel.ISupportInitialize)(this.tableCuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaPagos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableCuentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label montoTotaltxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaAbonotxt;
        private System.Windows.Forms.TextBox cajaPagotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label restanteLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label abonoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pagoClienteLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cambioLabel;
        private System.Windows.Forms.Label idApartLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label idClientLabel;
        private System.Windows.Forms.DataGridView listaProductosCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listaPagos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelAnticipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelSumaPagos;
        private System.Windows.Forms.Label labelMontoAbonado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button entregarProducto;
        private System.Windows.Forms.Label folioTexto;
        private System.Windows.Forms.Label total_deuda;
        private System.Windows.Forms.Label idproducto_label;
        private System.Windows.Forms.Label cantidadProductolabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label idPtoApartadoLabel;
    }
}