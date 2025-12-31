namespace MotoFixLUZ
{
    partial class DetalleTrabajoIngresoTallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleTrabajoIngresoTallerForm));
            lblDescripcionMotoAtendiendo = new Label();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            txtObservaciones = new RichTextBox();
            groupBox2 = new GroupBox();
            btnGuardarIngresoTaller = new Button();
            txtSugerencias = new RichTextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            txtFiltrarServicios = new TextBox();
            dgvServicios = new DataGridView();
            groupBox5 = new GroupBox();
            dgvServiciosRealizados = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosRealizados).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcionMotoAtendiendo
            // 
            lblDescripcionMotoAtendiendo.AutoSize = true;
            lblDescripcionMotoAtendiendo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcionMotoAtendiendo.Location = new Point(12, 13);
            lblDescripcionMotoAtendiendo.Name = "lblDescripcionMotoAtendiendo";
            lblDescripcionMotoAtendiendo.Size = new Size(496, 20);
            lblDescripcionMotoAtendiendo.TabIndex = 0;
            lblDescripcionMotoAtendiendo.Text = "Detalle trabajo realizados ingreso taller => Moto placa N°. MY 525 66";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDescripcionMotoAtendiendo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 50);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2780, 13);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "TOTAL: 20";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1135, 544);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(494, 538);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Dock = DockStyle.Fill;
            txtObservaciones.Location = new Point(3, 23);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(482, 237);
            txtObservaciones.TabIndex = 0;
            txtObservaciones.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuardarIngresoTaller);
            groupBox2.Controls.Add(txtSugerencias);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(488, 263);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sugerencia";
            // 
            // btnGuardarIngresoTaller
            // 
            btnGuardarIngresoTaller.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarIngresoTaller.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarIngresoTaller.Image = Properties.Resources.icon_save;
            btnGuardarIngresoTaller.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarIngresoTaller.Location = new Point(6, 195);
            btnGuardarIngresoTaller.Name = "btnGuardarIngresoTaller";
            btnGuardarIngresoTaller.Size = new Size(476, 62);
            btnGuardarIngresoTaller.TabIndex = 25;
            btnGuardarIngresoTaller.Text = "GUARDAR TRABAJO REALIZADO";
            btnGuardarIngresoTaller.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarIngresoTaller.UseVisualStyleBackColor = true;
            btnGuardarIngresoTaller.Click += btnGuardarIngresoTaller_Click;
            // 
            // txtSugerencias
            // 
            txtSugerencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSugerencias.Location = new Point(3, 23);
            txtSugerencias.Name = "txtSugerencias";
            txtSugerencias.Size = new Size(482, 155);
            txtSugerencias.TabIndex = 1;
            txtSugerencias.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(503, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(629, 538);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(623, 512);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtFiltrarServicios);
            groupBox4.Controls.Add(dgvServicios);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(617, 250);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Servicios disponibles";
            // 
            // txtFiltrarServicios
            // 
            txtFiltrarServicios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltrarServicios.Location = new Point(8, 31);
            txtFiltrarServicios.Name = "txtFiltrarServicios";
            txtFiltrarServicios.Size = new Size(603, 27);
            txtFiltrarServicios.TabIndex = 7;
            txtFiltrarServicios.TextChanged += txtFiltrarServicios_TextChanged;
            // 
            // dgvServicios
            // 
            dgvServicios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(6, 76);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(605, 164);
            dgvServicios.TabIndex = 6;
            dgvServicios.CellContentClick += dgvServicios_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvServiciosRealizados);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 259);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(617, 250);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Detalle de servicios realizados";
            // 
            // dgvServiciosRealizados
            // 
            dgvServiciosRealizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosRealizados.Dock = DockStyle.Fill;
            dgvServiciosRealizados.Location = new Point(3, 23);
            dgvServiciosRealizados.Name = "dgvServiciosRealizados";
            dgvServiciosRealizados.Size = new Size(611, 224);
            dgvServiciosRealizados.TabIndex = 7;
            dgvServiciosRealizados.CellClick += dgvServiciosRealizados_CellClick;
            // 
            // DetalleTrabajoIngresoTallerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 235, 245);
            ClientSize = new Size(1135, 594);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetalleTrabajoIngresoTallerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle ingreso taller";
            Load += DetalleTrabajoIngresoTallerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServiciosRealizados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescripcionMotoAtendiendo;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox txtObservaciones;
        private RichTextBox txtSugerencias;
        private DataGridView dgvServicios;
        private DataGridView dgvServiciosRealizados;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtFiltrarServicios;
        private Button btnGuardarIngresoTaller;
    }
}