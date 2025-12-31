using Datos;
using Datos.DTO;
using Datos.Modelos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace MotoFixLUZ
{

    public partial class DetalleTrabajoIngresoTallerForm : Form
    {
        public DetalleTrabajoIngresoTallerForm()
        {
            InitializeComponent(); 
        }
        List<CatTrabajoRealizados> Servicios = new List<CatTrabajoRealizados>();
        private BindingList<IngresoTallerDetalleDTO> Data = new BindingList<IngresoTallerDetalleDTO>();
        private BindingSource bsRealizados = new BindingSource();
        AppDbContext dbContext = new AppDbContext();
        public string Titulo = "";
        public long ingresotallerid = 0;


        private void DetalleTrabajoIngresoTallerForm_Load(object sender, EventArgs e)
        {
            this.Width = 1500;
            this.Height = 700;
            Servicios = dbContext.CatTrabajoRealizados.Where(p => p.Estado).ToList();
            ConfigurarGridServicios();
            ConfigurarGridServiciosRealizados();
            dgvServicios.DataSource = Servicios;
            lblDescripcionMotoAtendiendo.Text = Titulo;
            var ingresodetalle = dbContext.IngresoTaller.FirstOrDefault(p => p.IngresoTallerId == ingresotallerid);
            txtObservaciones.Text = ingresodetalle?.ObservacionesTrabajoRealizado?.Trim() ?? "";
            txtSugerencias.Text = ingresodetalle?.SugerenciaTrabajoRealizado?.Trim() ?? "";
            CargarGrid();
        }

        private void CargarGrid()
        {
            Data.Clear();
            bsRealizados.DataSource = Data;
            dgvServiciosRealizados.DataSource = bsRealizados;
            var eData = (from ingresoTallerDetalle in dbContext.IngresoTallerDetalles.AsNoTracking()
                         join detalle in dbContext.CatTrabajoRealizados.AsNoTracking() on ingresoTallerDetalle.CatTrabajoRealizadoId equals detalle.CatTrabajoRealizadoId
                         where ingresoTallerDetalle.IngresoTallerId == ingresotallerid
                         select new IngresoTallerDetalleDTO
                         {
                             IngresoTallerDetalleId = ingresoTallerDetalle.IngresoTallerDetalleId,
                             CatTrabajoRealizadoId = ingresoTallerDetalle.CatTrabajoRealizadoId,
                             TrabajoRealizado = detalle.TrabajoRealizado,
                             Descripcion = ingresoTallerDetalle.Observacion,
                             StatusTrabajoRealizado = ingresoTallerDetalle.StatusTrabajoRealizado
                         }).ToList();
            Data.Clear();
            foreach (var x in eData) Data.Add(x);
        }
      
        private void ConfigurarGridServicios()
        {
            dgvServicios.AutoGenerateColumns = false;
            dgvServicios.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "CatTrabajoRealizadoId",
                DataPropertyName = "CatTrabajoRealizadoId",
                Visible = false
            };

            // Trabajo
            var colNombre = new DataGridViewTextBoxColumn
            {
                Name = "TrabajoRealizado",
                HeaderText = "Servicios",
                DataPropertyName = "TrabajoRealizado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            // Descripción (se expande)
            var colDescripcion = new DataGridViewTextBoxColumn
            {
                Name = "Observacion",
                HeaderText = "Observacion",
                DataPropertyName = "Observacion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            // Botón Agregar
            var colAgregar = new DataGridViewButtonColumn
            {
                Name = "Agregar",
                HeaderText = "",
                Text = "+ Agregar",                       // mostramos el + como texto
                UseColumnTextForButtonValue = true,
                Width = 120
            };

            // Colores del botón
            colAgregar.FlatStyle = FlatStyle.Flat;
            colAgregar.DefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);       // Verde (#4CAF50)
            colAgregar.DefaultCellStyle.ForeColor = Color.White;                       // Texto blanco
            colAgregar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 142, 60); // Verde más oscuro al seleccionar
            colAgregar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvServicios.Columns.AddRange(colId, colNombre, colDescripcion, colAgregar);
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            // Trabajo y Descripción se estiran
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Mitad y mitad (50 / 50)
            colNombre.FillWeight = 50;
            colDescripcion.FillWeight = 50;

            // Agregar: ancho fijo, sin estirarse
            colAgregar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colAgregar.Width = 90;   // o el que estés usando

            dgvServicios.ReadOnly = true;
            dgvServicios.EditMode = DataGridViewEditMode.EditProgrammatically;

            // 👉 Que siempre seleccione la fila completa
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // (opcional) Solo una fila a la vez
            dgvServicios.MultiSelect = false;

            // (opcional) que no puedan agregar/eliminar filas desde el grid
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;
        }


        private void ConfigurarGridServiciosRealizados()
        {
            dgvServiciosRealizados.AutoGenerateColumns = false;
            dgvServiciosRealizados.AllowUserToAddRows = false;
            dgvServiciosRealizados.AllowUserToDeleteRows = false;
            dgvServiciosRealizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiciosRealizados.MultiSelect = false;


            var colIdDetalle = new DataGridViewTextBoxColumn();
            colIdDetalle.Name = "IngresoTallerDetalleId";
            colIdDetalle.HeaderText = "IngresoTallerDetalleId";
            colIdDetalle.DataPropertyName = "IngresoTallerDetalleId";
            colIdDetalle.Visible = false;
            dgvServiciosRealizados.Columns.Add(colIdDetalle);

            // --- Columna 0: IdServicio (oculta) ---
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "CatTrabajoRealizadoId";
            colId.HeaderText = "CatTrabajoRealizadoId";
            colId.DataPropertyName = "CatTrabajoRealizadoId";
            colId.Visible = false;
            dgvServiciosRealizados.Columns.Add(colId);

            // --- Columna 1: Servicio (solo lectura) ---
            var colServicio = new DataGridViewTextBoxColumn();
            colServicio.Name = "TrabajoRealizado";
            colServicio.HeaderText = "Servicio";
            colServicio.DataPropertyName = "TrabajoRealizado";
            colServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colServicio.FillWeight = 40;
            colServicio.ReadOnly = true;          // 👈 no se edita
            dgvServiciosRealizados.Columns.Add(colServicio);

            // --- Columna 2: Descripción (editable) ---
            var colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.Name = "Descripcion";
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.DataPropertyName = "Descripcion";
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.FillWeight = 40;
            colDescripcion.ReadOnly = false;      // 👈 sí se edita
            dgvServiciosRealizados.Columns.Add(colDescripcion);

            // --- Columna 3: CheckBox (por defecto true) ---
            var colActivo = new DataGridViewCheckBoxColumn();
            colActivo.Name = "StatusTrabajoRealizado";
            colActivo.DataPropertyName = "StatusTrabajoRealizado";
            colActivo.HeaderText = "Hecho";
            colActivo.Width = 60;
            colActivo.ThreeState = false;
            dgvServiciosRealizados.Columns.Add(colActivo);

            // --- Columna 4: Icono eliminar ---
            var colEliminar = new DataGridViewImageColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "";
            colEliminar.Width = 40;
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.Image = Properties.Resources.icon_delete; // agrega tu PNG a Recursos
            dgvServiciosRealizados.Columns.Add(colEliminar);

            // Grid en general: se permite editar, pero solo en las columnas que NO son ReadOnly
            dgvServiciosRealizados.ReadOnly = false;

            // Por si acaso, fuerza que solo Descripcion y Aplicar sean editables
            foreach (DataGridViewColumn col in dgvServiciosRealizados.Columns)
                col.ReadOnly = true;

            dgvServiciosRealizados.Columns["Descripcion"].ReadOnly = false;
            dgvServiciosRealizados.Columns["StatusTrabajoRealizado"].ReadOnly = false;
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Solo reaccionar si se hizo click en la columna Agregar
            if (dgvServicios.Columns[e.ColumnIndex].Name != "Agregar")
                return;

            DataGridViewRow filaOrigen = dgvServicios.Rows[e.RowIndex];

            // Tomamos el Id y el nombre del servicio (ajusta los nombres de columnas si son otros)
            long idServicio = long.Parse(filaOrigen.Cells["CatTrabajoRealizadoId"].Value?.ToString() ?? "0");
            var nombreServicio = filaOrigen.Cells["TrabajoRealizado"].Value?.ToString();

            if (Data.Any(p => p.CatTrabajoRealizadoId == idServicio))
            {
                MessageBox.Show("Este servicio ya fue agregado.", "Moto FIX LUZ");
                return;
            }
            Data.Add(new IngresoTallerDetalleDTO()
            {
                CatTrabajoRealizadoId = (long)idServicio,
                TrabajoRealizado = nombreServicio ?? "",
                StatusTrabajoRealizado = true,
                IngresoTallerDetalleId = 0
            }); 
        }
 
    
        private void txtFiltrarServicios_TextChanged(object sender, EventArgs e)
        {
            Servicios = dbContext.CatTrabajoRealizados.Where(p => p.Estado).ToList();

            if (txtFiltrarServicios.Text.Length == 0)
            {
                dgvServicios.DataSource = Servicios;
            }
            else
            {
                string texto = txtFiltrarServicios.Text.Trim().ToLower();
                dgvServicios.DataSource = Servicios.Where(p => p.TrabajoRealizado.Trim().ToLower().Contains(texto)).ToList();
            }
        }

        private void btnGuardarIngresoTaller_Click(object sender, EventArgs e)
        {
            if ((txtObservaciones.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Observaciones es requerido.", "Moto FIX LUZ");
                return;
            }
            else if ((txtSugerencias.Text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Sugerencias es requerido.", "Moto FIX LUZ");
                return;
            }
            else if (dgvServiciosRealizados.Rows.Count == 0)
            {
                MessageBox.Show("Servicios realizados al menos uno es requerido .", "Moto FIX LUZ");
                return;
            }

            var ingresoTaller = dbContext.IngresoTaller.FirstOrDefault(p => p.IngresoTallerId == ingresotallerid);
            if (ingresoTaller is null) return;

            ingresoTaller.ObservacionesTrabajoRealizado = txtObservaciones.Text?.Trim() ?? "";
            ingresoTaller.SugerenciaTrabajoRealizado = txtSugerencias.Text?.Trim() ?? "";

            var detalle = ObtenerServiciosRealizadosDesdeGrid();
            var eliminar = dbContext.IngresoTallerDetalles.Where(p =>  !detalle.Select(c=> c.IngresoTallerDetalleId).Contains(p.IngresoTallerDetalleId) && p.IngresoTallerId == ingresotallerid).ToList();
            if (eliminar.Any())
            {
                dbContext.IngresoTallerDetalles.RemoveRange(eliminar);
            }
            dbContext.SaveChanges();
            var actualizar = dbContext.IngresoTallerDetalles.Where(p => p.IngresoTallerId == ingresotallerid && detalle.Select(c => c.CatTrabajoRealizadoId).Contains(p.CatTrabajoRealizadoId)).ToList();
            foreach (var item in actualizar)
            {
                item.Observacion = detalle.FirstOrDefault(p => p.CatTrabajoRealizadoId == item.CatTrabajoRealizadoId)?.Observacion ?? "";
            }
            dbContext.IngresoTallerDetalles.AddRange(detalle.Where(p => p.IngresoTallerDetalleId == 0).Select(c => new IngresoTallerDetalles
            {
                IngresoTallerDetalleId = 0,
                IngresoTallerId = ingresotallerid,
                CatTrabajoRealizadoId = c.CatTrabajoRealizadoId,
                StatusTrabajoRealizado = true,
                Observacion = c.Observacion,
                Fecha = DateTime.Now,
                Estado = true
            }).ToList());

            dbContext.SaveChanges();
            CargarGrid();
            MessageBox.Show("Se ha guardado correctamente.", "Moto FIX LUZ");
            
        }

        private List<IngresoTallerDetalles> ObtenerServiciosRealizadosDesdeGrid()
        {
            // Por si hay una celda en edición (sobre todo el checkbox)
            dgvServiciosRealizados.EndEdit();

            var lista = new List<IngresoTallerDetalles>();

            foreach (DataGridViewRow row in dgvServiciosRealizados.Rows)
            {
                // Ignorar la fila nueva vacía
                if (row.IsNewRow)
                    continue;

                // Si no tiene Id de catálogo, no tiene sentido guardarlo
                if (row.Cells["CatTrabajoRealizadoId"].Value == null)
                    continue;

                var item = new IngresoTallerDetalles
                {
                    // Id detalle (puede ser null si aún no existe en BD)
                    IngresoTallerDetalleId = row.Cells["IngresoTallerDetalleId"].Value == null
                        ? 0 : Convert.ToInt32(row.Cells["IngresoTallerDetalleId"].Value),

                    // Id del servicio catálogo
                    CatTrabajoRealizadoId = Convert.ToInt32(row.Cells["CatTrabajoRealizadoId"].Value),

                    // Solo para referencia / mostrar, no lo necesitas para guardar si ya tienes el Id
                    Observacion = Convert.ToString(row.Cells["Descripcion"].Value ?? string.Empty),

                    // Checkbox (si viene null lo tomo como false)
                    StatusTrabajoRealizado = row.Cells["StatusTrabajoRealizado"].Value != null &&
                                             Convert.ToBoolean(row.Cells["StatusTrabajoRealizado"].Value),
                    Fecha = DateTime.Now,
                    Estado = true,
                    IngresoTallerId = ingresotallerid
                };

                lista.Add(item);
            }

            return lista;
        }

        private void dgvServiciosRealizados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (dgvServiciosRealizados.Columns[e.ColumnIndex].Name != "Eliminar") return;

                dgvServiciosRealizados.EndEdit();
                dgvServiciosRealizados.CommitEdit(DataGridViewDataErrorContexts.Commit);

                if (MessageBox.Show("¿Seguro desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                bsRealizados.RemoveAt(e.RowIndex);
        } 
    }
}
