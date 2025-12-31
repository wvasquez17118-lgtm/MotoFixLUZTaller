namespace MotoFixLUZ
{
    partial class RegistrarMotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMotoForm));
            panel1 = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cmbModelo = new ComboBox();
            cmbMarca = new ComboBox();
            panel4 = new Panel();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtPlaca = new TextBox();
            label6 = new Label();
            txtCilindrada = new TextBox();
            label5 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtBusqueda = new TextBox();
            panel3 = new Panel();
            lsvMotos = new ListView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 50);
            panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(872, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "TOTAL: 20";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Catalogos de motos";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbModelo);
            panel2.Controls.Add(cmbMarca);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPlaca);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCilindrada);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtColor);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtBusqueda);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 555);
            panel2.TabIndex = 1;
            // 
            // cmbModelo
            // 
            cmbModelo.Enabled = false;
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(13, 211);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(318, 28);
            cmbModelo.TabIndex = 14;
            // 
            // cmbMarca
            // 
            cmbMarca.Enabled = false;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(13, 150);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(318, 28);
            cmbMarca.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(btnCancelar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 359);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 196);
            panel4.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ControlText;
            btnNuevo.Image = Properties.Resources.icon_new;
            btnNuevo.ImageAlign = ContentAlignment.TopCenter;
            btnNuevo.Location = new Point(5, 21);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(129, 55);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "NUEVO";
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = Properties.Resources.icon_delete;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(90, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 55);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.icon_save;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(202, 82);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 55);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.icon_edit;
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(202, 21);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 55);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = Properties.Resources.icon_cancel;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(5, 82);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 55);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 68);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 11;
            label7.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Enabled = false;
            txtPlaca.Location = new Point(12, 91);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(322, 27);
            txtPlaca.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 302);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 9;
            label6.Text = "Cilindrada";
            // 
            // txtCilindrada
            // 
            txtCilindrada.Enabled = false;
            txtCilindrada.Location = new Point(9, 326);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(322, 27);
            txtCilindrada.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Enabled = false;
            txtColor.Location = new Point(12, 268);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(322, 27);
            txtColor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icon_search;
            button1.Location = new Point(281, 24);
            button1.Name = "button1";
            button1.Size = new Size(53, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(12, 24);
            txtBusqueda.Multiline = true;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(255, 32);
            txtBusqueda.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lsvMotos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(343, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 555);
            panel3.TabIndex = 2;
            // 
            // lsvMotos
            // 
            lsvMotos.Dock = DockStyle.Fill;
            lsvMotos.GridLines = true;
            lsvMotos.Location = new Point(0, 0);
            lsvMotos.Name = "lsvMotos";
            lsvMotos.Size = new Size(649, 555);
            lsvMotos.TabIndex = 0;
            lsvMotos.UseCompatibleStateImageBehavior = false;
            lsvMotos.View = View.Details;
            lsvMotos.DrawColumnHeader += lsvMotos_DrawColumnHeader;
            lsvMotos.DrawItem += lsvMotos_DrawItem;
            lsvMotos.DrawSubItem += lsvMotos_DrawSubItem;
            lsvMotos.DoubleClick += lsvMotos_DoubleClick;
            // 
            // RegistrarMotoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 235, 245);
            ClientSize = new Size(992, 605);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarMotoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar moto";
            FormClosing += RegistrarMotoForm_FormClosing;
            Load += RegistrarMotoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblTotal;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvMotos;
        private Button button1;
        private TextBox txtBusqueda;
        private Label label6;
        private TextBox txtCilindrada;
        private Label label5;
        private TextBox txtColor;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtPlaca;
        private Panel panel4;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnCancelar;
        private ComboBox cmbModelo;
        private ComboBox cmbMarca;
    }
}