using Datos;
using Microsoft.EntityFrameworkCore;

namespace MotoFixLUZ
{
    public partial class RegistrarMotoForm : Form
    {
        AppDbContext app = new AppDbContext();
        public long idmoto = 0;
        public RegistrarMotoForm()
        {
            InitializeComponent();
        }

        private void RegistrarMotoForm_Load(object sender, EventArgs e)
        {
            lsvMotos.View = View.Details;
            lsvMotos.FullRowSelect = true;
            lsvMotos.OwnerDraw = true;

            lsvMotos.Columns.Add("Id", 0);
            lsvMotos.Columns.Add("Placa", 200);
            lsvMotos.Columns.Add("Marca", 150);
            lsvMotos.Columns.Add("Modelo", 150);
            lsvMotos.Columns.Add("Color", 150);
            lsvMotos.Columns.Add("Cilindrada", 150);
             

            CargarMotosRandom();
        }

        private void CargarMotosRandom(string busqueda = "")
        {
            lsvMotos.Items.Clear();

            var fr = (from moto in app.Motos.AsNoTracking()                      
                      where string.IsNullOrEmpty(busqueda) ? moto.Estado == true : moto.Estado == true && moto.Placa.ToUpper().Contains(busqueda)
                      select new
                      {
                          Id = moto.CatMotoId,
                          Placa = moto.Placa,
                          Modelo = moto.Modelo??"",
                          Marca = moto.Marca ?? "",
                          Color = moto.Color,
                          Cilindrada = moto.Cilindrada,
                      }).ToList();

            foreach (var f in fr)
            {
                ListViewItem items = new ListViewItem(f.Id.ToString());
                items.SubItems.Add(f.Placa);
                items.SubItems.Add(f.Marca);
                items.SubItems.Add(f.Modelo);
                items.SubItems.Add(f.Color);
                items.SubItems.Add(f.Cilindrada);
                lsvMotos.Items.Add(items);
            }
            lblTotal.Text = "TOTAL: " + fr.Count();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            txtCilindrada.Enabled = true;
            txtColor.Enabled = true;
            txtPlaca.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtBusqueda.Clear();
            idmoto = 0;

            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtPlaca.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Numero de placa, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtMarca.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Marca de la moto, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtModelo.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Modelo de la moto, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtColor.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Color de la moto, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtCilindrada.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Cilindrada de la moto, es requerido.", "Moto FIX LUZ");
                return;
            }
            DialogResult r = MessageBox.Show("Estas seguro desea guardar el registro?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (idmoto == 0)
                {
                    app.Motos.Add(new Datos.Modelos.CatMotos()
                    {
                        Marca = txtMarca.Text.Trim(),
                        Modelo = txtModelo.Text.Trim(),
                        Cilindrada = txtCilindrada.Text?.Trim() ?? "",
                        Color = txtColor.Text?.Trim() ?? "",
                        Placa = txtPlaca.Text?.Trim().ToUpper() ?? "",
                        Estado = true
                    });
                }
                else
                {
                    var moto = app.Motos.FirstOrDefault(p => p.CatMotoId == idmoto);
                    if (moto == null) return;
                    moto.Estado = true;
                    moto.Placa = txtPlaca.Text?.Trim().ToUpper() ?? "";
                    moto.Cilindrada = txtCilindrada.Text?.Trim() ?? "";
                    moto.Color = txtColor.Text?.Trim() ?? "";
                    moto.Marca = txtMarca.Text.Trim();
                    moto.Modelo = txtModelo.Text.Trim();
                }
                app.SaveChanges();
                CargarMotosRandom();
                btnCancelar_Click(null, null);
                idmoto = 0;
                MessageBox.Show("Se ha guardado correctamente.", "Moto FIX LUZ");
            }
        }

        private void lsvMotos_DoubleClick(object sender, EventArgs e)
        {
            if (lsvMotos.SelectedItems.Count == 0)
                return;  // por seguridad

            // Item seleccionado (la fila)
            ListViewItem item = lsvMotos.SelectedItems[0];

            // Columna id producto
            idmoto = Convert.ToInt32(item.Text);

            txtMarca.Text = item.SubItems[2].Text;
            txtModelo.Text = item.SubItems[3].Text;
            

            txtPlaca.Text = item.SubItems[1].Text;
            txtColor.Text = item.SubItems[4].Text;
            txtCilindrada.Text = item.SubItems[5].Text;

            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
             
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;

            txtBusqueda.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Text = string.Empty;
            txtCilindrada.Text = string.Empty;
            txtColor.Text = string.Empty;
            idmoto = 0;

            txtCilindrada.Enabled = false;
            txtColor.Enabled = false;
            txtPlaca.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idmoto == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para poder eliminar", "Moto FIX LUZ");
                return;
            }
            DialogResult r = MessageBox.Show("Estas seguro desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                var moto = app.Motos.FirstOrDefault(p => p.CatMotoId == idmoto);
                if (moto == null) return;
                moto.Estado = false;
                app.SaveChanges();
                CargarMotosRandom();
                btnCancelar_Click(null, null);
                MessageBox.Show("Se ha eliminado correctamente.", "Moto FIX LUZ");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCilindrada.Enabled = true;
            txtColor.Enabled = true;
            txtPlaca.Enabled = true;
            txtModelo.Enabled = true;
            txtMarca.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarMotosRandom(txtBusqueda.Text.ToUpper());
        }

        private void lsvMotos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var backBrush = new SolidBrush(SystemColors.Control))
            using (var borderPen = new Pen(SystemColors.ControlDark))
            using (var headerFont = new Font(lsvMotos.Font, FontStyle.Bold))
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

        private void lsvMotos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lsvMotos_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void RegistrarMotoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.AbrirFormulario = false;
        }
    }
}
