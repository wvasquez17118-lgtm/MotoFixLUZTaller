namespace MotoFixLUZ
{
    partial class IngresoTallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoTallerForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            cmbEstadoIngresoTaller = new ComboBox();
            lblEstado = new Label();
            btnGuardarIngresoTaller = new Button();
            btnBuscarMoto = new Button();
            txtMotoPlacaBuscador = new TextBox();
            label7 = new Label();
            txtPlaca = new TextBox();
            label6 = new Label();
            txtCilindrada = new TextBox();
            label5 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtKilometrajeIngreso = new TextBox();
            txtNombreCliente = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            txtCelularCliente = new TextBox();
            label10 = new Label();
            txtCorreoCliente = new TextBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox6 = new GroupBox();
            txtDescripcionDelMecanico = new TextBox();
            label14 = new Label();
            groupBox5 = new GroupBox();
            txtDescripcionTrabajoDetallaCliente = new TextBox();
            label13 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 50);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1845, 13);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "TOTAL: 20";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 0;
            label1.Text = "Registrar moto =>  ingreso al taller ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1173, 525);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(cmbEstadoIngresoTaller);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(btnGuardarIngresoTaller);
            groupBox1.Controls.Add(btnBuscarMoto);
            groupBox1.Controls.Add(txtMotoPlacaBuscador);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCilindrada);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 519);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de la moto";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModelo.Enabled = false;
            txtModelo.Location = new Point(10, 235);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(372, 27);
            txtModelo.TabIndex = 30;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMarca.Enabled = false;
            txtMarca.Location = new Point(10, 174);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(372, 27);
            txtMarca.TabIndex = 29;
            // 
            // cmbEstadoIngresoTaller
            // 
            cmbEstadoIngresoTaller.FormattingEnabled = true;
            cmbEstadoIngresoTaller.Location = new Point(10, 414);
            cmbEstadoIngresoTaller.Name = "cmbEstadoIngresoTaller";
            cmbEstadoIngresoTaller.Size = new Size(372, 28);
            cmbEstadoIngresoTaller.TabIndex = 28;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(10, 387);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(152, 20);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "Estado ingreso taller";
            // 
            // btnGuardarIngresoTaller
            // 
            btnGuardarIngresoTaller.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarIngresoTaller.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarIngresoTaller.Image = Properties.Resources.icon_save;
            btnGuardarIngresoTaller.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarIngresoTaller.Location = new Point(6, 448);
            btnGuardarIngresoTaller.Name = "btnGuardarIngresoTaller";
            btnGuardarIngresoTaller.Size = new Size(372, 62);
            btnGuardarIngresoTaller.TabIndex = 24;
            btnGuardarIngresoTaller.Text = "GUARDAR INGRESO A TALLER";
            btnGuardarIngresoTaller.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarIngresoTaller.UseVisualStyleBackColor = true;
            btnGuardarIngresoTaller.Click += btnGuardarIngresoTaller_Click;
            // 
            // btnBuscarMoto
            // 
            btnBuscarMoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarMoto.Image = Properties.Resources.icon_search;
            btnBuscarMoto.Location = new Point(345, 39);
            btnBuscarMoto.Name = "btnBuscarMoto";
            btnBuscarMoto.Size = new Size(43, 36);
            btnBuscarMoto.TabIndex = 23;
            btnBuscarMoto.UseVisualStyleBackColor = true;
            btnBuscarMoto.Click += btnBuscarMoto_Click;
            // 
            // txtMotoPlacaBuscador
            // 
            txtMotoPlacaBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMotoPlacaBuscador.CharacterCasing = CharacterCasing.Upper;
            txtMotoPlacaBuscador.Location = new Point(10, 39);
            txtMotoPlacaBuscador.Multiline = true;
            txtMotoPlacaBuscador.Name = "txtMotoPlacaBuscador";
            txtMotoPlacaBuscador.Size = new Size(329, 32);
            txtMotoPlacaBuscador.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 88);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 21;
            label7.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPlaca.CharacterCasing = CharacterCasing.Upper;
            txtPlaca.Enabled = false;
            txtPlaca.Location = new Point(9, 111);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(372, 27);
            txtPlaca.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 322);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 19;
            label6.Text = "Cilindrada";
            // 
            // txtCilindrada
            // 
            txtCilindrada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCilindrada.Enabled = false;
            txtCilindrada.Location = new Point(6, 346);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(372, 27);
            txtCilindrada.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 265);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 17;
            label5.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtColor.Enabled = false;
            txtColor.Location = new Point(9, 288);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(372, 27);
            txtColor.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 208);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 15;
            label4.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 147);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 13;
            label3.Text = "Marca";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(403, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(767, 519);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(761, 144);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtKilometrajeIngreso);
            groupBox2.Controls.Add(txtNombreCliente);
            groupBox2.Controls.Add(label9);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 138);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 19);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 23;
            label8.Text = "Kilometraje ingreso";
            // 
            // txtKilometrajeIngreso
            // 
            txtKilometrajeIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKilometrajeIngreso.Location = new Point(11, 42);
            txtKilometrajeIngreso.Name = "txtKilometrajeIngreso";
            txtKilometrajeIngreso.Size = new Size(353, 27);
            txtKilometrajeIngreso.TabIndex = 22;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCliente.Location = new Point(11, 105);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(353, 27);
            txtNombreCliente.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 82);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 25;
            label9.Text = "Nombre cliente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCelularCliente);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtCorreoCliente);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(383, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 138);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 82);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 29;
            label11.Text = "Celular cliente";
            // 
            // txtCelularCliente
            // 
            txtCelularCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCelularCliente.Location = new Point(6, 105);
            txtCelularCliente.Name = "txtCelularCliente";
            txtCelularCliente.Size = new Size(353, 27);
            txtCelularCliente.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 27;
            label10.Text = "Correo cliente";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreoCliente.Location = new Point(6, 42);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(353, 27);
            txtCorreoCliente.TabIndex = 26;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 153);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(761, 363);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(groupBox6, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(755, 337);
            tableLayoutPanel4.TabIndex = 31;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtDescripcionDelMecanico);
            groupBox6.Controls.Add(label14);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(3, 171);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(749, 163);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // txtDescripcionDelMecanico
            // 
            txtDescripcionDelMecanico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcionDelMecanico.Location = new Point(8, 46);
            txtDescripcionDelMecanico.Multiline = true;
            txtDescripcionDelMecanico.Name = "txtDescripcionDelMecanico";
            txtDescripcionDelMecanico.Size = new Size(735, 111);
            txtDescripcionDelMecanico.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(5, 23);
            label14.Name = "label14";
            label14.Size = new Size(689, 20);
            label14.TabIndex = 27;
            label14.Text = "Descripcion del mecanico =>Alguna observación  o paso a seguir al momento de atender la moto";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDescripcionTrabajoDetallaCliente);
            groupBox5.Controls.Add(label13);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(749, 162);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // txtDescripcionTrabajoDetallaCliente
            // 
            txtDescripcionTrabajoDetallaCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcionTrabajoDetallaCliente.Location = new Point(8, 42);
            txtDescripcionTrabajoDetallaCliente.Multiline = true;
            txtDescripcionTrabajoDetallaCliente.Name = "txtDescripcionTrabajoDetallaCliente";
            txtDescripcionTrabajoDetallaCliente.Size = new Size(735, 120);
            txtDescripcionTrabajoDetallaCliente.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(8, 9);
            label13.Name = "label13";
            label13.Size = new Size(493, 20);
            label13.TabIndex = 30;
            label13.Text = "Descripcion trabajo => Cliente detalla lo que desea revisar  a su moto";
            // 
            // IngresoTallerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 235, 245);
            ClientSize = new Size(1173, 575);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "IngresoTallerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingreso al taller";
            WindowState = FormWindowState.Maximized;
            FormClosing += IngresoTallerForm_FormClosing;
            Load += IngresoTallerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtPlaca;
        private Label label6;
        private TextBox txtCilindrada;
        private Label label5;
        private TextBox txtColor;
        private Label label4;
        private Label label3;
        private Button btnBuscarMoto;
        private TextBox txtMotoPlacaBuscador;
        private Button btnGuardarIngresoTaller;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtKilometrajeIngreso;
        private Label label11;
        private TextBox txtCelularCliente;
        private Label label10;
        private TextBox txtCorreoCliente;
        private Label label9;
        private TextBox txtNombreCliente;
        private Label label13;
        private TextBox txtDescripcionTrabajoDetallaCliente;
        private GroupBox groupBox4;
        private Label label14;
        private TextBox txtDescripcionDelMecanico;
        private ComboBox cmbEstadoIngresoTaller;
        private Label lblEstado;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private TextBox txtModelo;
        private TextBox txtMarca;
    }
}