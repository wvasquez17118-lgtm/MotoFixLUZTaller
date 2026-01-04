using Datos;
using Datos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MotoFixLUZ
{
    public partial class CatalogoServiciosForm : Form
    {
        AppDbContext app = new AppDbContext();
        public long idservicio = 0;
        public CatalogoServiciosForm()
        {
            InitializeComponent();
        }

        private void CatalogoServiciosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.AbrirFormulario = false;
        }

        private void CatalogoServiciosForm_Load(object sender, EventArgs e)
        {
            lsvServicio.View = View.Details;
            lsvServicio.FullRowSelect = true;
            lsvServicio.OwnerDraw = true;

            lsvServicio.Columns.Add("Id", 0);
            lsvServicio.Columns.Add("Servicios", 400);
            lsvServicio.Columns.Add("Observacion", 400);
            lsvServicio.Columns.Add("Precio estimado", 200);
            CargarGRID();
        }

        private void lsvServicio_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var backBrush = new SolidBrush(SystemColors.Control))
            using (var borderPen = new Pen(SystemColors.ControlDark))
            using (var headerFont = new Font(lsvServicio.Font, FontStyle.Bold))
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

        private void lsvServicio_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lsvServicio_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtObervacion.Enabled = true;
            txtServicio.Enabled = true;
            txtServicio.Clear();
            txtObervacion.Clear();
            txtPrecioEstimado.Clear();
            txtPrecioEstimado.Enabled = true;
            idservicio = 0;

            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtServicio.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Servicio a ofrecer, es requerido.", "Moto FIX LUZ");
                return;
            }
            if (idservicio == 0)
            {
                app.CatTrabajoRealizados.Add(new CatTrabajoRealizados()
                {
                    TrabajoRealizado = txtServicio.Text?.Trim() ?? "",
                    Observacion = txtObervacion.Text?.Trim() ?? "",
                    Estado = true,
                    PrecioEstimado = Convert.ToDecimal(txtPrecioEstimado.Text.Trim() ?? "0")
                });
            }
            else
            {
                var servicio = app.CatTrabajoRealizados.FirstOrDefault(p => p.CatTrabajoRealizadoId == idservicio);
                if (servicio == null) return;

                servicio.Estado = true;
                servicio.TrabajoRealizado = txtServicio.Text?.Trim() ?? "";
                servicio.Observacion = txtObervacion.Text?.Trim() ?? "";
                servicio.PrecioEstimado = Convert.ToDecimal(txtPrecioEstimado.Text.Trim() ?? "0");
            }
            app.SaveChanges();

            txtObervacion.Enabled = false;
            txtServicio.Enabled = false;
            txtServicio.Clear();
            txtObervacion.Clear();
            txtBusqueda.Clear();
            idservicio = 0;
            txtPrecioEstimado.Clear();
            txtPrecioEstimado.Enabled = false;

            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            CargarGRID();
            MessageBox.Show("Se ha guardado correctamente.", "Moto FIX LUZ");
        }

        private void CargarGRID(string servicio = "")
        {
            lsvServicio.Items.Clear();
            var query = (from ca in app.CatTrabajoRealizados.AsNoTracking()
                         where ca.Estado == true
                         select new
                         {
                             Estado = ca.Estado,
                             Trabajo = ca.TrabajoRealizado,
                             Observacion = ca.Observacion,
                             Id = ca.CatTrabajoRealizadoId,
                             PrecioEstimado = ca.PrecioEstimado,
                         });
            if (!string.IsNullOrEmpty(servicio))
            {
                query = query.Where(p => p.Trabajo.Contains(servicio));
            }

            var data = query.ToList();
            foreach (var item in data)
            {
                ListViewItem items = new ListViewItem(item.Id.ToString());
                items.SubItems.Add(item.Trabajo);
                items.SubItems.Add(item.Observacion);
                items.SubItems.Add(item.PrecioEstimado.ToString().Replace(".00",""));
                lsvServicio.Items.Add(items);
            }
            lblTotal.Text = "TOTAL: " + data.Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGRID(txtBusqueda.Text.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;

            txtObervacion.Text = string.Empty;
            txtServicio.Text = string.Empty;
            idservicio = 0;
            txtObervacion.Enabled = false;
            txtServicio.Enabled = false;
            txtPrecioEstimado.Clear();
            txtPrecioEstimado.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtServicio.Enabled = true;
            txtObervacion.Enabled = true;
            btnCancelar.Enabled = true;
            txtPrecioEstimado.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idservicio == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para poder eliminar", "Moto FIX LUZ");
                return;
            }
            DialogResult r = MessageBox.Show("Estas seguro desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                var servicio = app.CatTrabajoRealizados.FirstOrDefault(p => p.CatTrabajoRealizadoId == idservicio);
                if (servicio == null) return;
                servicio.Estado = false;
                app.SaveChanges();
                CargarGRID();
                btnCancelar_Click(null, null);
                MessageBox.Show("Se ha eliminado correctamente.", "Moto FIX LUZ");
            }
        }

        private void lsvServicio_DoubleClick(object sender, EventArgs e)
        {
            if (lsvServicio.SelectedItems.Count == 0)
                return;  // por seguridad

            // Item seleccionado (la fila)
            ListViewItem item = lsvServicio.SelectedItems[0];

            // Columna id producto
            idservicio = Convert.ToInt32(item.Text);

            txtServicio.Text = item.SubItems[1].Text;
            txtObervacion.Text = item.SubItems[2].Text;
            txtPrecioEstimado.Text = item.SubItems[3].Text;

            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void txtPrecioEstimado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite control (Backspace, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Permite dígitos 0-9
            if (char.IsDigit(e.KeyChar))
                return;

            // (Opcional) Permitir signo negativo solo al inicio y solo una vez
            if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0 && !((TextBox)sender).Text.Contains("-"))
                return;

            // Bloquea todo lo demás
            e.Handled = true;
        }
    }
}
