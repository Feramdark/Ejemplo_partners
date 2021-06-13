namespace IntraPDV
{
    partial class Interfaz_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apagar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeApartadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesApartadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeConexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionPosCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RealizarCobro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IdUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPagar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Importe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextCambio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.horaRecibida = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.apagar);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 35);
            this.panel1.TabIndex = 3;
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.White;
            this.apagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar.Image = ((System.Drawing.Image)(resources.GetObject("apagar.Image")));
            this.apagar.Location = new System.Drawing.Point(1246, 0);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(39, 35);
            this.apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apagar.TabIndex = 12;
            this.apagar.TabStop = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.Color.White;
            this.minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1202, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(38, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 4;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.sistemaDeApartadoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.devolucionPosCompraToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checarInventarioToolStripMenuItem,
            this.actualizarInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // checarInventarioToolStripMenuItem
            // 
            this.checarInventarioToolStripMenuItem.Name = "checarInventarioToolStripMenuItem";
            this.checarInventarioToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.checarInventarioToolStripMenuItem.Text = "Añadir Inventario. ";
            this.checarInventarioToolStripMenuItem.Click += new System.EventHandler(this.checarInventarioToolStripMenuItem_Click);
            // 
            // actualizarInventarioToolStripMenuItem
            // 
            this.actualizarInventarioToolStripMenuItem.Name = "actualizarInventarioToolStripMenuItem";
            this.actualizarInventarioToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.actualizarInventarioToolStripMenuItem.Text = "Actualizar Inventario";
            this.actualizarInventarioToolStripMenuItem.Click += new System.EventHandler(this.actualizarInventarioToolStripMenuItem_Click);
            // 
            // sistemaDeApartadoToolStripMenuItem
            // 
            this.sistemaDeApartadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.detallesApartadoToolStripMenuItem});
            this.sistemaDeApartadoToolStripMenuItem.Name = "sistemaDeApartadoToolStripMenuItem";
            this.sistemaDeApartadoToolStripMenuItem.Size = new System.Drawing.Size(203, 29);
            this.sistemaDeApartadoToolStripMenuItem.Text = "Sistema de Apartado";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.agregarClienteToolStripMenuItem.Text = "Realizar Apartado";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // detallesApartadoToolStripMenuItem
            // 
            this.detallesApartadoToolStripMenuItem.Name = "detallesApartadoToolStripMenuItem";
            this.detallesApartadoToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.detallesApartadoToolStripMenuItem.Text = "Lista Apartados";
            this.detallesApartadoToolStripMenuItem.Click += new System.EventHandler(this.detallesApartadoToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeConexiónToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.configuraciónToolStripMenuItem.Text = "Informe de Venta";
            // 
            // cambioDeConexiónToolStripMenuItem
            // 
            this.cambioDeConexiónToolStripMenuItem.Name = "cambioDeConexiónToolStripMenuItem";
            this.cambioDeConexiónToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.cambioDeConexiónToolStripMenuItem.Text = "Venta diaria";
            this.cambioDeConexiónToolStripMenuItem.Click += new System.EventHandler(this.cambioDeConexiónToolStripMenuItem_Click);
            // 
            // devolucionPosCompraToolStripMenuItem
            // 
            this.devolucionPosCompraToolStripMenuItem.Name = "devolucionPosCompraToolStripMenuItem";
            this.devolucionPosCompraToolStripMenuItem.Size = new System.Drawing.Size(237, 29);
            this.devolucionPosCompraToolStripMenuItem.Text = "Devolucion Post-Compra";
            this.devolucionPosCompraToolStripMenuItem.Click += new System.EventHandler(this.devolucionPosCompraToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(154, 29);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // RealizarCobro
            // 
            this.RealizarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RealizarCobro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealizarCobro.Location = new System.Drawing.Point(1090, 528);
            this.RealizarCobro.Name = "RealizarCobro";
            this.RealizarCobro.Size = new System.Drawing.Size(173, 47);
            this.RealizarCobro.TabIndex = 3;
            this.RealizarCobro.Tag = "cobrar";
            this.RealizarCobro.Text = "Realizar Venta";
            this.RealizarCobro.UseVisualStyleBackColor = true;
            this.RealizarCobro.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(163, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 406);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.BackColor = System.Drawing.Color.White;
            this.CodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodigoBarras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoBarras.Location = new System.Drawing.Point(163, 78);
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.Size = new System.Drawing.Size(203, 27);
            this.CodigoBarras.TabIndex = 1;
            this.CodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoBarras_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Producto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(955, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSize = true;
            this.IdUsuario.Location = new System.Drawing.Point(438, 89);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(42, 13);
            this.IdUsuario.TabIndex = 8;
            this.IdUsuario.Text = "VictorR";
            this.IdUsuario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "TOTAL";
            // 
            // TotalPagar
            // 
            this.TotalPagar.AutoSize = true;
            this.TotalPagar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagar.Location = new System.Drawing.Point(949, 569);
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Size = new System.Drawing.Size(68, 32);
            this.TotalPagar.TabIndex = 10;
            this.TotalPagar.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 708);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 19);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "IMPORTE";
            // 
            // Importe
            // 
            this.Importe.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Importe.Location = new System.Drawing.Point(883, 608);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(134, 41);
            this.Importe.TabIndex = 2;
            this.Importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dar_cambio);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(712, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "CAMBIO";
            // 
            // TextCambio
            // 
            this.TextCambio.AutoSize = true;
            this.TextCambio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCambio.Location = new System.Drawing.Point(949, 662);
            this.TextCambio.Name = "TextCambio";
            this.TextCambio.Size = new System.Drawing.Size(68, 32);
            this.TextCambio.TabIndex = 15;
            this.TextCambio.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(877, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(951, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // horaRecibida
            // 
            this.horaRecibida.AutoSize = true;
            this.horaRecibida.Location = new System.Drawing.Point(27, 146);
            this.horaRecibida.Name = "horaRecibida";
            this.horaRecibida.Size = new System.Drawing.Size(0, 13);
            this.horaRecibida.TabIndex = 18;
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(1090, 595);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(173, 33);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Tag = "cobrar";
            this.btncancelar.Text = "Cancelar Venta";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-52, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-25, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(161, 523);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1090, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quitar producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // folio
            // 
            this.folio.AutoSize = true;
            this.folio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folio.Location = new System.Drawing.Point(518, 665);
            this.folio.Name = "folio";
            this.folio.Size = new System.Drawing.Size(21, 23);
            this.folio.TabIndex = 27;
            this.folio.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 665);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ticket#";
            // 
            // Interfaz_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 727);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.folio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CodigoBarras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.horaRecibida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TotalPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.IdUsuario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RealizarCobro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interfaz_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntraPDV";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox apagar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeConexiónToolStripMenuItem;
        private System.Windows.Forms.Button RealizarCobro;
        private System.Windows.Forms.TextBox CodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label IdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPagar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Importe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TextCambio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label horaRecibida;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem devolucionPosCompraToolStripMenuItem;
        private System.Windows.Forms.Label folio;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeApartadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarInventarioToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesApartadoToolStripMenuItem;
    }
}