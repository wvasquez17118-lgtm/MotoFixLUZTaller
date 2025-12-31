using Datos;
using Datos.Modelos;

namespace MotoFixLUZ
{
    public partial class IngresoTallerForm : Form
    {
        AppDbContext dbContext;
        public long idmoto = 0;
        public long ingresotallerid = 0;
        public string placamoto = "";
        public IngresoTallerForm()
        {
            InitializeComponent();
            dbContext = new AppDbContext();
        }

        private void IngresoTallerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.AbrirFormulario = false;
            idmoto = 0;
            ingresotallerid = 0;
            placamoto = "";
        }

        private void btnGuardarIngresoTaller_Click(object sender, EventArgs e)
        {
            if (idmoto == 0)
            {
                MessageBox.Show("Debe seleccionar la moto que ingresara a taller, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtKilometrajeIngreso.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Kilometraje de la moto que ingresara a taller, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtNombreCliente.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Nombre cliente, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtCelularCliente.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Celular cliente, es requerido.", "Moto FIX LUZ");
                return;
            }
            //else if ((txtDescripcionProblemaMoto.Text ?? "").Trim().Length == 0)
            //{
            //    MessageBox.Show("Descripcion problema => Cliente detalla problema siente su moto, es requerido.", "Moto FIX LUZ");
            //    return;
            //}
            else if ((txtDescripcionTrabajoDetallaCliente.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Descripcion trabajo => Cliente detalla lo que desea revisar  a su moto, es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtDescripcionDelMecanico.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Descripcion del mecanico =>Alguna observación  o paso a seguir al momento de atender la moto, es requerido.", "Moto FIX LUZ");
                return;
            }

            if (ingresotallerid == 0)
            {
                int idestado = dbContext.Estados.FirstOrDefault(p=> p.Codigo == 1)?.CatEstadoId ?? 0;
                dbContext.IngresoTaller.Add(new Datos.Modelos.IngresoTaller()
                {
                    CatMotoId = idmoto,
                    KilometrajeIngreso = txtKilometrajeIngreso.Text?.Trim() ?? "",
                    NombreCliente = txtNombreCliente.Text?.Trim() ?? "",
                    CorreoCliente = txtCorreoCliente.Text?.Trim() ?? "",
                    CelularCliente = txtCelularCliente.Text?.Trim() ?? "",
                    DesProblemaDetallaCliente = "", //txtDescripcionProblemaMoto.Text?.Trim() ?? "",
                    DesTrabajoDetallaCliente = txtDescripcionTrabajoDetallaCliente.Text?.Trim() ?? "",
                    DesTrabajoDetallaMecanico = txtDescripcionDelMecanico.Text?.Trim() ?? "",
                    FechaIngreso = DateTime.Now,
                    CatEstadoId = idestado,
                    Estado = true
                });
            }
            else
            {
                var ingresotallereditar = dbContext.IngresoTaller.FirstOrDefault(p=> p.IngresoTallerId == ingresotallerid);
                ingresotallereditar.KilometrajeIngreso = txtKilometrajeIngreso.Text?.Trim() ?? "";
                ingresotallereditar.NombreCliente = txtNombreCliente.Text?.Trim() ?? "";
                ingresotallereditar.CorreoCliente = txtCorreoCliente.Text?.Trim() ?? "";
                ingresotallereditar.CelularCliente = txtCelularCliente.Text?.Trim() ?? "";
                ingresotallereditar.DesProblemaDetallaCliente = "";
                ingresotallereditar.DesTrabajoDetallaCliente = txtDescripcionTrabajoDetallaCliente.Text?.Trim() ?? "";
                ingresotallereditar.DesTrabajoDetallaMecanico = txtDescripcionDelMecanico.Text?.Trim() ?? "";
                ingresotallereditar.CatEstadoId = int.Parse(cmbEstadoIngresoTaller.SelectedValue?.ToString() ?? "0");
                ingresotallereditar.ObservacionesTrabajoRealizado = ingresotallereditar.ObservacionesTrabajoRealizado;
                ingresotallereditar.SugerenciaTrabajoRealizado = ingresotallereditar.SugerenciaTrabajoRealizado;
            }

            dbContext.SaveChanges();
            MessageBox.Show("Se ha guardado correctamente ingreso a taller.", "Moto FIX LUZ");
            txtPlaca.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtCilindrada.Text = string.Empty;
            cmbMarca.SelectedValue = -1;
            cmbModelo.SelectedValue = -1;
            txtKilometrajeIngreso.Text = "";
            txtNombreCliente.Text = "";
            txtCorreoCliente.Text = "";
            txtCelularCliente.Text = "";
            //txtDescripcionProblemaMoto.Text = "";
            txtDescripcionTrabajoDetallaCliente.Text = "";
            txtDescripcionDelMecanico.Text = "";
            idmoto = 0;
            if (ingresotallerid > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            ingresotallerid = 0;
        }

        private void btnBuscarMoto_Click(object sender, EventArgs e)
        {
            var moto = dbContext.Motos.FirstOrDefault(p => p.Placa.Trim() == txtMotoPlacaBuscador.Text.Trim().ToUpper());
            txtPlaca.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtCilindrada.Text = string.Empty;
            cmbMarca.SelectedValue = -1;
            cmbModelo.SelectedValue = -1;
            idmoto = 0;
            if (moto is null)
            {
                MessageBox.Show("No se encontro la moto por favor validar numero de placa este correcto", "Moto FIX LUZ");
                return;
            }
            idmoto = moto.CatMotoId;
            txtPlaca.Text = moto.Placa;
            txtColor.Text = moto.Color;
            txtCilindrada.Text = moto.Cilindrada;
            cmbMarca.SelectedValue = moto.CatMarcaId;
            cmbModelo.SelectedValue = moto.CatModeloId;
        }

        private void IngresoTallerForm_Load(object sender, EventArgs e)
        {
            cmbMarca.DataSource = dbContext.Marcas.ToList();
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "CatMarcaId";
            cmbMarca.SelectedIndex = -1;

            cmbModelo.DataSource = dbContext.Modelos.ToList();
            cmbModelo.DisplayMember = "Modelo";
            cmbModelo.ValueMember = "CatModeloId";
            cmbModelo.SelectedIndex = -1;
            lblEstado.Visible = false;
            cmbEstadoIngresoTaller.Visible = false;

            if (ingresotallerid > 0)
            {
                lblEstado.Visible = true;
                cmbEstadoIngresoTaller.Visible = true;
                cmbEstadoIngresoTaller.DataSource = dbContext.Estados.ToList();
                cmbEstadoIngresoTaller.DisplayMember = "NombreEstado";
                cmbEstadoIngresoTaller.ValueMember = "CatEstadoId";
                

                var ingreso = dbContext.IngresoTaller.FirstOrDefault(p=> p.IngresoTallerId == ingresotallerid);
                if (ingreso is null) return;

                txtMotoPlacaBuscador.Text = placamoto;
                txtKilometrajeIngreso.Text = ingreso.KilometrajeIngreso;
                txtNombreCliente.Text = ingreso.NombreCliente;
                txtCorreoCliente.Text = ingreso.CorreoCliente;
                txtCelularCliente.Text = ingreso.CelularCliente;
                //txtDescripcionProblemaMoto.Text = ingreso.DesProblemaDetallaCliente;
                txtDescripcionTrabajoDetallaCliente.Text = ingreso.DesTrabajoDetallaCliente;
                txtDescripcionDelMecanico.Text = ingreso.DesTrabajoDetallaMecanico;
                cmbEstadoIngresoTaller.SelectedValue = ingreso.CatEstadoId;
                btnBuscarMoto_Click(null, null);

            }
        }
    }
}
