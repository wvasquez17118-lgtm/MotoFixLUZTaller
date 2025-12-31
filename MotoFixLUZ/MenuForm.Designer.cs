namespace SIGMAF.Desktop
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            menuPrincipalStrip = new MenuStrip();
            motosToolStripMenuItem = new ToolStripMenuItem();
            flowMenu = new FlowLayoutPanel();
            panelRibbon = new Panel();
            panelInferior = new Panel();
            lblFooter = new Label();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            menuPrincipalStrip.SuspendLayout();
            panelRibbon.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipalStrip
            // 
            menuPrincipalStrip.Items.AddRange(new ToolStripItem[] { motosToolStripMenuItem });
            menuPrincipalStrip.Location = new Point(0, 0);
            menuPrincipalStrip.Name = "menuPrincipalStrip";
            menuPrincipalStrip.Padding = new Padding(7, 2, 0, 2);
            menuPrincipalStrip.Size = new Size(1328, 48);
            menuPrincipalStrip.TabIndex = 0;
            menuPrincipalStrip.Text = "menuStrip1";
            // 
            // motosToolStripMenuItem
            // 
            motosToolStripMenuItem.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motosToolStripMenuItem.Image = MotoFixLUZ.Properties.Resources.icon_motos;
            motosToolStripMenuItem.Name = "motosToolStripMenuItem";
            motosToolStripMenuItem.Size = new Size(244, 44);
            motosToolStripMenuItem.Text = "MOTO FIX LUZ";
            motosToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // flowMenu
            // 
            flowMenu.BackColor = Color.Transparent;
            flowMenu.Dock = DockStyle.Fill;
            flowMenu.Location = new Point(0, 0);
            flowMenu.Name = "flowMenu";
            flowMenu.Padding = new Padding(8);
            flowMenu.Size = new Size(1328, 100);
            flowMenu.TabIndex = 1;
            flowMenu.WrapContents = false;
            // 
            // panelRibbon
            // 
            panelRibbon.BackColor = Color.FromArgb(225, 235, 245);
            panelRibbon.Controls.Add(flowMenu);
            panelRibbon.Dock = DockStyle.Top;
            panelRibbon.Location = new Point(0, 48);
            panelRibbon.Name = "panelRibbon";
            panelRibbon.Size = new Size(1328, 100);
            panelRibbon.TabIndex = 2;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(225, 235, 245);
            panelInferior.Controls.Add(lblFooter);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 595);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1328, 39);
            panelInferior.TabIndex = 4;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFooter.Location = new Point(12, 7);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(262, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "SISTEMA DE TALLER DE MOTOS LUZ";
            // 
            // timerAnimacion
            // 
            timerAnimacion.Interval = 50;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 634);
            Controls.Add(panelInferior);
            Controls.Add(panelRibbon);
            Controls.Add(menuPrincipalStrip);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipalStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema taller motos fix luz";
            WindowState = FormWindowState.Maximized;
            Load += MenuForm_Load;
            menuPrincipalStrip.ResumeLayout(false);
            menuPrincipalStrip.PerformLayout();
            panelRibbon.ResumeLayout(false);
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipalStrip;
        private ToolStripMenuItem motosToolStripMenuItem;
        private FlowLayoutPanel flowMenu;
        private Panel panelRibbon;
        private Panel panelInferior;
        private Label lblFooter;
        private System.Windows.Forms.Timer timerAnimacion;
    }
}