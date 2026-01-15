namespace MotoFixLUZ
{
    partial class HistorialServicioForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialServicioForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label7 = new Label();
            TxtPlaca = new TextBox();
            label6 = new Label();
            txtCilindrada = new TextBox();
            label5 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnBuscarMoto = new Button();
            txtBusquedaPlaca = new TextBox();
            groupBox2 = new GroupBox();
            lsvDetalleVisitaAlTaller = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            verDetalleToolStripMenuItem = new ToolStripMenuItem();
            enviarReporteWHASTAPPToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            panel1.Size = new Size(915, 50);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2560, 13);
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
            label1.Size = new Size(402, 20);
            label1.TabIndex = 0;
            label1.Text = "Historial de servicios => mostrar detalles visitas al taller";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(915, 550);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtPlaca);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCilindrada);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnBuscarMoto);
            groupBox1.Controls.Add(txtBusquedaPlaca);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 544);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar detalle moto";
            // 
            // txtModelo
            // 
            txtModelo.Enabled = false;
            txtModelo.Location = new Point(9, 217);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(322, 27);
            txtModelo.TabIndex = 25;
            // 
            // txtMarca
            // 
            txtMarca.Enabled = false;
            txtMarca.Location = new Point(9, 157);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(322, 27);
            txtMarca.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 70);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 23;
            label7.Text = "Placa";
            // 
            // TxtPlaca
            // 
            TxtPlaca.Enabled = false;
            TxtPlaca.Location = new Point(9, 93);
            TxtPlaca.Name = "TxtPlaca";
            TxtPlaca.Size = new Size(322, 27);
            TxtPlaca.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 304);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 21;
            label6.Text = "Cilindrada";
            // 
            // txtCilindrada
            // 
            txtCilindrada.Enabled = false;
            txtCilindrada.Location = new Point(6, 328);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(322, 27);
            txtCilindrada.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 247);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 19;
            label5.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Enabled = false;
            txtColor.Location = new Point(9, 270);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(322, 27);
            txtColor.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 190);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 17;
            label4.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 129);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 15;
            label3.Text = "Marca";
            // 
            // btnBuscarMoto
            // 
            btnBuscarMoto.Image = Properties.Resources.icon_search;
            btnBuscarMoto.Location = new Point(278, 26);
            btnBuscarMoto.Name = "btnBuscarMoto";
            btnBuscarMoto.Size = new Size(53, 36);
            btnBuscarMoto.TabIndex = 13;
            btnBuscarMoto.UseVisualStyleBackColor = true;
            btnBuscarMoto.Click += btnBuscarMoto_Click;
            // 
            // txtBusquedaPlaca
            // 
            txtBusquedaPlaca.CharacterCasing = CharacterCasing.Upper;
            txtBusquedaPlaca.Location = new Point(9, 26);
            txtBusquedaPlaca.Multiline = true;
            txtBusquedaPlaca.Name = "txtBusquedaPlaca";
            txtBusquedaPlaca.Size = new Size(255, 32);
            txtBusquedaPlaca.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDetalleVisitaAlTaller);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(353, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(559, 544);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial de servicio visita al taller";
            // 
            // lsvDetalleVisitaAlTaller
            // 
            lsvDetalleVisitaAlTaller.ContextMenuStrip = contextMenuStrip1;
            lsvDetalleVisitaAlTaller.Dock = DockStyle.Fill;
            lsvDetalleVisitaAlTaller.FullRowSelect = true;
            lsvDetalleVisitaAlTaller.GridLines = true;
            lsvDetalleVisitaAlTaller.Location = new Point(3, 23);
            lsvDetalleVisitaAlTaller.Name = "lsvDetalleVisitaAlTaller";
            lsvDetalleVisitaAlTaller.Size = new Size(553, 518);
            lsvDetalleVisitaAlTaller.TabIndex = 0;
            lsvDetalleVisitaAlTaller.UseCompatibleStateImageBehavior = false;
            lsvDetalleVisitaAlTaller.View = View.Details;
            lsvDetalleVisitaAlTaller.DrawColumnHeader += lsvDetalleVisitaAlTaller_DrawColumnHeader;
            lsvDetalleVisitaAlTaller.DrawItem += lsvDetalleVisitaAlTaller_DrawItem;
            lsvDetalleVisitaAlTaller.DrawSubItem += lsvDetalleVisitaAlTaller_DrawSubItem;
            lsvDetalleVisitaAlTaller.MouseDown += lsvDetalleVisitaAlTaller_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, verDetalleToolStripMenuItem, enviarReporteWHASTAPPToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(250, 70);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(249, 22);
            editarToolStripMenuItem.Text = "Editar ingreso taller";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // verDetalleToolStripMenuItem
            // 
            verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            verDetalleToolStripMenuItem.Size = new Size(249, 22);
            verDetalleToolStripMenuItem.Text = "Agregar detalles trabajo realizado";
            verDetalleToolStripMenuItem.Click += verDetalleToolStripMenuItem_Click;
            // 
            // enviarReporteWHASTAPPToolStripMenuItem
            // 
            enviarReporteWHASTAPPToolStripMenuItem.Name = "enviarReporteWHASTAPPToolStripMenuItem";
            enviarReporteWHASTAPPToolStripMenuItem.Size = new Size(249, 22);
            enviarReporteWHASTAPPToolStripMenuItem.Text = "Enviar reporte WHASTAPP";
            enviarReporteWHASTAPPToolStripMenuItem.Click += enviarReporteWHASTAPPToolStripMenuItem_Click;
            // 
            // HistorialServicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 235, 245);
            ClientSize = new Size(915, 600);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "HistorialServicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de servicios";
            FormClosing += HistorialServicioForm_FormClosing;
            Load += HistorialServicioForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox TxtPlaca;
        private Label label6;
        private TextBox txtCilindrada;
        private Label label5;
        private TextBox txtColor;
        private Label label4;
        private Label label3;
        private Button btnBuscarMoto;
        private TextBox txtBusquedaPlaca;
        private GroupBox groupBox2;
        private ListView lsvDetalleVisitaAlTaller;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem verDetalleToolStripMenuItem;
        private ToolStripMenuItem enviarReporteWHASTAPPToolStripMenuItem;
        private TextBox txtModelo;
        private TextBox txtMarca;
    }
}