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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableApartados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.montoTotaltxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaAbonotxt = new System.Windows.Forms.TextBox();
            this.cajaPagotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idClientLabel = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idApartLabel = new System.Windows.Forms.Label();
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
            this.labelAnticipo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelSumaPagos = new System.Windows.Forms.Label();
            this.labelMontoAbonado = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableApartados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPagos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableApartados
            // 
            this.tableApartados.AllowUserToAddRows = false;
            this.tableApartados.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableApartados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableApartados.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableApartados.Location = new System.Drawing.Point(12, 416);
            this.tableApartados.Name = "tableApartados";
            this.tableApartados.Size = new System.Drawing.Size(580, 197);
            this.tableApartados.TabIndex = 0;
            this.tableApartados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetInfoClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(244, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(394, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Restante $";
            // 
            // montoTotaltxt
            // 
            this.montoTotaltxt.AutoSize = true;
            this.montoTotaltxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTotaltxt.Location = new System.Drawing.Point(390, 64);
            this.montoTotaltxt.Name = "montoTotaltxt";
            this.montoTotaltxt.Size = new System.Drawing.Size(40, 19);
            this.montoTotaltxt.TabIndex = 6;
            this.montoTotaltxt.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pago";
            // 
            // cajaAbonotxt
            // 
            this.cajaAbonotxt.Location = new System.Drawing.Point(19, 239);
            this.cajaAbonotxt.Name = "cajaAbonotxt";
            this.cajaAbonotxt.Size = new System.Drawing.Size(160, 27);
            this.cajaAbonotxt.TabIndex = 8;
            this.cajaAbonotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.operationKeyPress);
            // 
            // cajaPagotxt
            // 
            this.cajaPagotxt.Location = new System.Drawing.Point(19, 180);
            this.cajaPagotxt.Name = "cajaPagotxt";
            this.cajaPagotxt.Size = new System.Drawing.Size(98, 27);
            this.cajaPagotxt.TabIndex = 9;
            this.cajaPagotxt.TextChanged += new System.EventHandler(this.addQuantity);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad a abonar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idClientLabel);
            this.groupBox1.Controls.Add(this.nameClient);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.idApartLabel);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 310);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abonar a un Apartado";
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
            this.label2.Location = new System.Drawing.Point(240, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cambio $";
            // 
            // cambioLabel
            // 
            this.cambioLabel.AutoSize = true;
            this.cambioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioLabel.Location = new System.Drawing.Point(390, 157);
            this.cambioLabel.Name = "cambioLabel";
            this.cambioLabel.Size = new System.Drawing.Size(40, 19);
            this.cambioLabel.TabIndex = 18;
            this.cambioLabel.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Debe $";
            // 
            // restanteLabel
            // 
            this.restanteLabel.AutoSize = true;
            this.restanteLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restanteLabel.Location = new System.Drawing.Point(390, 188);
            this.restanteLabel.Name = "restanteLabel";
            this.restanteLabel.Size = new System.Drawing.Size(40, 19);
            this.restanteLabel.TabIndex = 16;
            this.restanteLabel.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Abono $";
            // 
            // abonoLabel
            // 
            this.abonoLabel.AutoSize = true;
            this.abonoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonoLabel.Location = new System.Drawing.Point(390, 126);
            this.abonoLabel.Name = "abonoLabel";
            this.abonoLabel.Size = new System.Drawing.Size(40, 19);
            this.abonoLabel.TabIndex = 14;
            this.abonoLabel.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pago $";
            // 
            // pagoClienteLabel
            // 
            this.pagoClienteLabel.AutoSize = true;
            this.pagoClienteLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoClienteLabel.Location = new System.Drawing.Point(390, 95);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProductosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaProductosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaProductosCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaProductosCliente.Location = new System.Drawing.Point(17, 39);
            this.listaProductosCliente.Name = "listaProductosCliente";
            this.listaProductosCliente.Size = new System.Drawing.Size(501, 181);
            this.listaProductosCliente.TabIndex = 13;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaPagos.DefaultCellStyle = dataGridViewCellStyle6;
            this.listaPagos.Location = new System.Drawing.Point(19, 25);
            this.listaPagos.Name = "listaPagos";
            this.listaPagos.Size = new System.Drawing.Size(502, 162);
            this.listaPagos.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listaProductosCliente);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(664, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 236);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // labelAnticipo
            // 
            this.labelAnticipo.AutoSize = true;
            this.labelAnticipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnticipo.Location = new System.Drawing.Point(1091, 295);
            this.labelAnticipo.Name = "labelAnticipo";
            this.labelAnticipo.Size = new System.Drawing.Size(40, 19);
            this.labelAnticipo.TabIndex = 16;
            this.labelAnticipo.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(884, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Anticipo $";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(884, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Suma Pagos $";
            // 
            // labelSumaPagos
            // 
            this.labelSumaPagos.AutoSize = true;
            this.labelSumaPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaPagos.Location = new System.Drawing.Point(1091, 273);
            this.labelSumaPagos.Name = "labelSumaPagos";
            this.labelSumaPagos.Size = new System.Drawing.Size(40, 19);
            this.labelSumaPagos.TabIndex = 19;
            this.labelSumaPagos.Text = "0.00";
            // 
            // labelMontoAbonado
            // 
            this.labelMontoAbonado.AutoSize = true;
            this.labelMontoAbonado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoAbonado.Location = new System.Drawing.Point(1091, 317);
            this.labelMontoAbonado.Name = "labelMontoAbonado";
            this.labelMontoAbonado.Size = new System.Drawing.Size(40, 19);
            this.labelMontoAbonado.TabIndex = 21;
            this.labelMontoAbonado.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(884, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "Total Abonado $";
            // 
            // lista_apartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 641);
            this.Controls.Add(this.labelMontoAbonado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelSumaPagos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelAnticipo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableApartados);
            this.Name = "lista_apartados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lista_apartados";
            this.Load += new System.EventHandler(this.showAps);
            ((System.ComponentModel.ISupportInitialize)(this.tableApartados)).EndInit();
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

        private System.Windows.Forms.DataGridView tableApartados;
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
    }
}