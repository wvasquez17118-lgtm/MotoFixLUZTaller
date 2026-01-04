namespace MotoFixLUZ
{
    partial class CatalogoServiciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoServiciosForm));
            panel1 = new Panel();
            lblTotal = new Label();
            label2 = new Label();
            label1 = new Label();
            lsvServicio = new ListView();
            panel2 = new Panel();
            label3 = new Label();
            txtPrecioEstimado = new TextBox();
            txtObervacion = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtServicio = new TextBox();
            button1 = new Button();
            txtBusqueda = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 50);
            panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(874, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "TOTAL: 20";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1664, 13);
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
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Catalogos servicios ofrecer";
            // 
            // lsvServicio
            // 
            lsvServicio.Dock = DockStyle.Fill;
            lsvServicio.GridLines = true;
            lsvServicio.Location = new Point(343, 50);
            lsvServicio.Name = "lsvServicio";
            lsvServicio.Size = new Size(649, 555);
            lsvServicio.TabIndex = 2;
            lsvServicio.UseCompatibleStateImageBehavior = false;
            lsvServicio.View = View.Details;
            lsvServicio.DrawColumnHeader += lsvServicio_DrawColumnHeader;
            lsvServicio.DrawItem += lsvServicio_DrawItem;
            lsvServicio.DrawSubItem += lsvServicio_DrawSubItem;
            lsvServicio.DoubleClick += lsvServicio_DoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPrecioEstimado);
            panel2.Controls.Add(txtObervacion);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtServicio);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtBusqueda);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 555);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 16;
            label3.Text = "Precio estimado";
            // 
            // txtPrecioEstimado
            // 
            txtPrecioEstimado.Enabled = false;
            txtPrecioEstimado.Location = new Point(12, 174);
            txtPrecioEstimado.Multiline = true;
            txtPrecioEstimado.Name = "txtPrecioEstimado";
            txtPrecioEstimado.Size = new Size(322, 51);
            txtPrecioEstimado.TabIndex = 15;
            txtPrecioEstimado.KeyPress += txtPrecioEstimado_KeyPress;
            // 
            // txtObervacion
            // 
            txtObervacion.Enabled = false;
            txtObervacion.Location = new Point(12, 268);
            txtObervacion.Multiline = true;
            txtObervacion.Name = "txtObervacion";
            txtObervacion.Size = new Size(322, 51);
            txtObervacion.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 245);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 13;
            label4.Text = "Observacion";
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
            label7.Size = new Size(64, 20);
            label7.TabIndex = 11;
            label7.Text = "Servicio";
            // 
            // txtServicio
            // 
            txtServicio.Enabled = false;
            txtServicio.Location = new Point(12, 91);
            txtServicio.Multiline = true;
            txtServicio.Name = "txtServicio";
            txtServicio.Size = new Size(322, 51);
            txtServicio.TabIndex = 10;
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
            // CatalogoServiciosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 235, 245);
            ClientSize = new Size(992, 605);
            Controls.Add(lsvServicio);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CatalogoServiciosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo servicios ofrecer";
            FormClosing += CatalogoServiciosForm_FormClosing;
            Load += CatalogoServiciosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblTotal;
        private ListView lsvServicio;
        private Panel panel2;
        private Panel panel4;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnCancelar;
        private Label label7;
        private TextBox txtServicio;
        private Button button1;
        private TextBox txtBusqueda;
        private TextBox txtObervacion;
        private Label label4;
        private Label label3;
        private TextBox txtPrecioEstimado;
    }
}