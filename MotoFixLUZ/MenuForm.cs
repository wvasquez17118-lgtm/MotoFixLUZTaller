
using Datos;
using MotoFixLUZ;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SIGMAF.Desktop
{
    public partial class MenuForm : Form
    { 
        private Dictionary<FontStyle, Font> fuentes;
        public MenuForm()
        {
            InitializeComponent(); 
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }


        private Button CreateRibbonButton(string text, Image iconFile, Action onClick = null)
        {

            var btn = new Button();
            btn.Text = text;
            btn.Size = new Size(180, 80);   // antes 100, 80
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.TextImageRelation = TextImageRelation.ImageAboveText;
            btn.BackColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 242, 253);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 225, 240);
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            btn.Margin = new Padding(4);
            btn.Padding = new Padding(4);

            btn.Image = iconFile;
            btn.ImageAlign = ContentAlignment.TopCenter;


            if (onClick != null)
            {
                btn.Click += (s, e) => onClick();
            }
            return btn;
        } 

        #region MENU STRIP MOTO
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "MOTOFIX LUZ – Menu";
            flowMenu.SuspendLayout();
            flowMenu.Controls.Clear();
            flowMenu.Controls.Add(CreateRibbonButton("Catalogo de servicios", MotoFixLUZ.Properties.Resources.icon_catalogoservicio, () => AbrirCatalogosServicios()));
            flowMenu.Controls.Add(CreateRibbonButton("Registro de Motos", MotoFixLUZ.Properties.Resources.icon_motos, () => AbrirCatalogosMotos()));
            flowMenu.Controls.Add(CreateRibbonButton("Ingreso al Taller", MotoFixLUZ.Properties.Resources.icon_herramientas, () => AbrirIngresoAlTaller()));
            flowMenu.Controls.Add(CreateRibbonButton("Historial de Ingresos", MotoFixLUZ.Properties.Resources.icon_historialservicio, () => AbrirHistorialIngresoAlTaller()));

            flowMenu.ResumeLayout();
        }
        #endregion

        #region FORMULARIOS MOTOS

        
        private void AbrirCatalogosServicios()
        {
            if (!Global.AbrirFormulario)
            {
                Global.AbrirFormulario = true;
                this.Text = "MOTOFIX LUZ – Catálogos servicios MOTOS";
                CatalogoServiciosForm frm = new CatalogoServiciosForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        private void AbrirCatalogosMotos()
        {
            if (!Global.AbrirFormulario)
            {
                Global.AbrirFormulario = true;
                this.Text = "MOTOFIX LUZ – Catálogos MOTOS";
                RegistrarMotoForm frm = new RegistrarMotoForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void AbrirIngresoAlTaller()
        {
            if (!Global.AbrirFormulario)
            {
                this.Text = "MOTOFIX LUZ – Ingreso de moto al taller";
                IngresoTallerForm frm = new IngresoTallerForm();
                frm.MdiParent = this;
                Global.AbrirFormulario = true;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }            
        }

        private void AbrirHistorialIngresoAlTaller()
        {
            if (!Global.AbrirFormulario)
            {
                this.Text = "MOTOFIX LUZ – Historial de ingreso al taller";
                HistorialServicioForm frm = new HistorialServicioForm();
                frm.MdiParent = this;
                Global.AbrirFormulario = true;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }            
        }
        #endregion


        private void movimientosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowMenu.SuspendLayout();
            flowMenu.Controls.Clear();
            flowMenu.ResumeLayout();
        }

       
    }
}
