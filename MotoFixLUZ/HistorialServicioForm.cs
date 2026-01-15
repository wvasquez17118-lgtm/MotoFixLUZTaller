using Datos;
using Microsoft.EntityFrameworkCore;

namespace MotoFixLUZ
{
    public partial class HistorialServicioForm : Form
    {
        AppDbContext dbContext;
        public long idmoto = 0;
        public long ingresotallerid = 0;
        public HistorialServicioForm()
        {
            InitializeComponent();
            dbContext = new AppDbContext();
        }

        private void HistorialServicioForm_Load(object sender, EventArgs e)
        {

            lsvDetalleVisitaAlTaller.Columns.Add("Id", 0);
            lsvDetalleVisitaAlTaller.Columns.Add("Fecha ingreso al taller", 200, HorizontalAlignment.Left);
            lsvDetalleVisitaAlTaller.Columns.Add("Estado", 200, HorizontalAlignment.Left);
            lsvDetalleVisitaAlTaller.Columns.Add("Placa moto", 100, HorizontalAlignment.Left);
            lsvDetalleVisitaAlTaller.Columns.Add("Kilometraje ingresado", 200, HorizontalAlignment.Right);
            lsvDetalleVisitaAlTaller.OwnerDraw = true;

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvDetalleVisitaAlTaller.SelectedItems.Count == 0)
                return;

            ListViewItem item = lsvDetalleVisitaAlTaller.SelectedItems[0];

            using (IngresoTallerForm form = new IngresoTallerForm())
            {
                form.ingresotallerid = long.Parse(item.SubItems[0].Text);
                form.placamoto = item.SubItems[3].Text;

                var result = form.ShowDialog();

                // 🔹 Solo recargo si realmente guardó:
                if (result == DialogResult.OK)
                {
                    btnBuscarMoto_Click(null, null);
                }
            }
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvDetalleVisitaAlTaller.SelectedItems.Count == 0)
                return;

            ListViewItem item = lsvDetalleVisitaAlTaller.SelectedItems[0];
     
            using (DetalleTrabajoIngresoTallerForm form = new DetalleTrabajoIngresoTallerForm())
            {
                form.ingresotallerid = long.Parse(item.SubItems[0].Text);
                form.Titulo = string.Format("Detalle trabajo realizados ingreso taller => Moto placa N°. {0}  Fecha Ingreso taller => {1}.", item.SubItems[3].Text, item.SubItems[1].Text);
                var result = form.ShowDialog();

                // 🔹 Solo recargo si realmente guardó:
                if (result == DialogResult.OK)
                {
                    btnBuscarMoto_Click(null, null);
                }
            }

          
        }

        private void btnBuscarMoto_Click(object sender, EventArgs e)
        {
            var moto = dbContext.Motos.FirstOrDefault(p => p.Placa.Trim() == txtBusquedaPlaca.Text.Trim().ToUpper());
            TxtPlaca.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtCilindrada.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            idmoto = 0;
            lsvDetalleVisitaAlTaller.Items.Clear();
            if (moto is null)
            {
                MessageBox.Show("No se encontro la moto por favor validar numero de placa este correcto", "Moto FIX LUZ");
                return;
            }
            idmoto = moto.CatMotoId;
            TxtPlaca.Text = moto.Placa;
            txtColor.Text = moto.Color;
            txtCilindrada.Text = moto.Cilindrada;
            txtMarca.Text = moto.Marca;
            txtModelo.Text = moto.Modelo;
           

            var resultado = (from ingresotaller in dbContext.IngresoTaller.AsNoTracking()
                             join estado in dbContext.Estados.AsNoTracking() on ingresotaller.CatEstadoId equals estado.CatEstadoId
                             where ingresotaller.CatMotoId == idmoto
                             orderby ingresotaller.IngresoTallerId descending
                             select new
                             {
                                 IngresoTallerId = ingresotaller.IngresoTallerId,
                                 Kilometraje = ingresotaller.KilometrajeIngreso,
                                 Estado = estado.NombreEstado,
                                 Placa = moto.Placa,
                                 FechaIngreso = ingresotaller.FechaIngreso
                             }).ToList();

            foreach (var item in resultado)
            {
                ListViewItem items = new ListViewItem(item.IngresoTallerId.ToString());
                items.SubItems.Add(item.FechaIngreso.ToString("yyyy-MMMM-dd"));
                items.SubItems.Add(item.Estado);
                items.SubItems.Add(item.Placa);
                items.SubItems.Add(item.Kilometraje);
                lsvDetalleVisitaAlTaller.Items.Add(items);
            }
        }

        private void lsvDetalleVisitaAlTaller_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lsvDetalleVisitaAlTaller_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lsvDetalleVisitaAlTaller_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var backBrush = new SolidBrush(SystemColors.Control))
            using (var borderPen = new Pen(SystemColors.ControlDark))
            using (var headerFont = new Font(lsvDetalleVisitaAlTaller.Font, FontStyle.Bold))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
                e.Graphics.DrawRectangle(borderPen, e.Bounds);

                // Texto en negrita
                TextRenderer.DrawText(
                    e.Graphics,
                    e.Header.Text,
                    headerFont,
                    e.Bounds,
                    Color.Black,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis
                );
            }
        }

        private void HistorialServicioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.AbrirFormulario = false;
        }

        private void lsvDetalleVisitaAlTaller_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Averiguar qué item está bajo el mouse
                var info = lsvDetalleVisitaAlTaller.HitTest(e.Location);

                if (info.Item != null)
                {
                    // Limpiar selección anterior
                    lsvDetalleVisitaAlTaller.SelectedItems.Clear();

                    // Seleccionar la fila donde hiciste clic derecho
                    info.Item.Selected = true;
                    lsvDetalleVisitaAlTaller.FocusedItem = info.Item;
                }
                else
                {
                    // Si clic derecho en espacio en blanco, limpiar selección
                    lsvDetalleVisitaAlTaller.SelectedItems.Clear();
                }
            }
        }

        private void enviarReporteWHASTAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviarReporteWHASTAPPForm from = new EnviarReporteWHASTAPPForm();
            from.ShowDialog();
        }
    }
}
