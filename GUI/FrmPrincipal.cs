using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ENTITY;
using BLL;
using System.Linq;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        private readonly CategoriaService _catService = new CategoriaService();
        private readonly ProveedorService _provService = new ProveedorService();
        private readonly ProductoService _prodService = new ProductoService();
        private readonly MovimientoService _movService = new MovimientoService();

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarEventos();
            CargarDatosIniciales();
        }

        private void ConfigurarEventos()
        {
            // Productos
            btnAgregarProductos.Click += (s, e) => AgregarProducto();
            btnEditarProductos.Click += (s, e) => EditarProducto();
            btnEliminarProductos.Click += (s, e) => EliminarProducto();
            dgvProductos.CellClick += (s, e) => SeleccionarProducto();

            // Categorias
            btnAgregarCategoria.Click += (s, e) => AgregarCategoria();
            btnEditarCategoria.Click += (s, e) => EditarCategoria();
            btnEliminarCategoria.Click += (s, e) => EliminarCategoria();
            dgvCategorias.CellClick += (s, e) => SeleccionarCategoria();

            // Proveedores
            btnAgregarProveedores.Click += (s, e) => AgregarProveedor();
            btnEditarProveedores.Click += (s, e) => EditarProveedor();
            btnEliminarProveedores.Click += (s, e) => EliminarProveedor();
            dataGridView1.CellClick += (s, e) => SeleccionarProveedor();

            // Movimientos
            btnEntradaMovimientos.Click += (s, e) => RegistrarMovimiento("Entrada");
            btnSalidaMovimientos.Click += (s, e) => RegistrarMovimiento("Salida");
            dgvProductosMovimientos.CellClick += (s, e) => SeleccionarProductoMovimiento();
        }

        // Métodos explícitos para el Diseñador de Visual Studio
        private void button3_Click(object sender, EventArgs e) { EliminarProducto(); }
        private void button1_Click(object sender, EventArgs e) { RegistrarMovimiento("Entrada"); }
        private void button2_Click(object sender, EventArgs e) { RegistrarMovimiento("Salida"); }
        private void tabPage1_Click(object sender, EventArgs e) { }

        private void CargarDatosIniciales()
        {
            ActualizarGridProductos();
            ActualizarGridCategorias();
            ActualizarGridProveedores();
            ActualizarGridMovimientos();
            CargarCombos();
            CargarGridProductosMovimientos();
        }

        private void CargarCombos()
        {
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = _catService.Listar();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "IdCategoria";

            cmbProveedor.DataSource = null;
            cmbProveedor.DataSource = _provService.Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "IdProveedor";
        }

        #region Productos
        private void ActualizarGridProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _prodService.Listar();
        }

        private void AgregarProducto()
        {
            try
            {
                var p = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text),
                    IdCategoria = (int)cmbCategoria.SelectedValue,
                    IdProveedor = (int)cmbProveedor.SelectedValue
                };
                _prodService.Agregar(p);
                ActualizarGridProductos();
                MessageBox.Show("Producto agregado.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EditarProducto()
        {
            try
            {
                var p = new Producto
                {
                    IdProducto = int.Parse(txtNombre.Tag?.ToString() ?? "0"),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text),
                    IdCategoria = (int)cmbCategoria.SelectedValue,
                    IdProveedor = (int)cmbProveedor.SelectedValue
                };
                _prodService.Editar(p);
                ActualizarGridProductos();
                MessageBox.Show("Producto actualizado.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EliminarProducto()
        {
            try
            {
                int id = int.Parse(txtNombre.Tag?.ToString() ?? "0");
                if (MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _prodService.Eliminar(id);
                    ActualizarGridProductos();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SeleccionarProducto()
        {
            if (dgvProductos.CurrentRow != null)
            {
                var p = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                txtNombre.Text = p.Nombre;
                txtDescripcion.Text = p.Descripcion;
                txtPrecio.Text = p.Precio.ToString();
                txtStock.Text = p.Stock.ToString();
                cmbCategoria.SelectedValue = p.IdCategoria;
                cmbProveedor.SelectedValue = p.IdProveedor;
                txtNombre.Tag = p.IdProducto;
            }
        }
        #endregion

        #region Categorias
        private void ActualizarGridCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = _catService.Listar();
        }

        private void AgregarCategoria()
        {
            try
            {
                var c = new Categoria { NombreCategoria = txtNombreCategoria.Text, Descripcion = txtDescripcionCategoria.Text };
                _catService.Agregar(c);
                ActualizarGridCategorias();
                CargarCombos();
                MessageBox.Show("Categoría agregada.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EditarCategoria()
        {
            try
            {
                var c = new Categoria { IdCategoria = int.Parse(txtID.Text), NombreCategoria = txtNombreCategoria.Text, Descripcion = txtDescripcionCategoria.Text };
                _catService.Editar(c);
                ActualizarGridCategorias();
                CargarCombos();
                MessageBox.Show("Categoría actualizada.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EliminarCategoria()
        {
            try
            {
                _catService.Eliminar(int.Parse(txtID.Text));
                ActualizarGridCategorias();
                CargarCombos();
                MessageBox.Show("Categoría eliminada.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SeleccionarCategoria()
        {
            if (dgvCategorias.CurrentRow != null)
            {
                var c = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                txtID.Text = c.IdCategoria.ToString();
                txtNombreCategoria.Text = c.NombreCategoria;
                txtDescripcionCategoria.Text = c.Descripcion;
            }
        }
        #endregion

        #region Proveedores
        private void ActualizarGridProveedores()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _provService.Listar();
        }

        private void AgregarProveedor()
        {
            try
            {
                var p = new Proveedor { Nombre = txtNombreProveedores.Text, Contacto = txtContactoProovedores.Text, Telefono = txtTelefonoProovedores.Text, Email = txtEmailProveedores.Text };
                _provService.Agregar(p);
                ActualizarGridProveedores();
                CargarCombos();
                MessageBox.Show("Proveedor agregado.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EditarProveedor()
        {
            try
            {
                var p = new Proveedor { IdProveedor = int.Parse(txtIdProveedores.Text), Nombre = txtNombreProveedores.Text, Contacto = txtContactoProovedores.Text, Telefono = txtTelefonoProovedores.Text, Email = txtEmailProveedores.Text };
                _provService.Editar(p);
                ActualizarGridProveedores();
                CargarCombos();
                MessageBox.Show("Proveedor actualizado.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EliminarProveedor()
        {
            try
            {
                _provService.Eliminar(int.Parse(txtIdProveedores.Text));
                ActualizarGridProveedores();
                CargarCombos();
                MessageBox.Show("Proveedor eliminado.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SeleccionarProveedor()
        {
            if (dataGridView1.CurrentRow != null)
            {
                var p = (Proveedor)dataGridView1.CurrentRow.DataBoundItem;
                txtIdProveedores.Text = p.IdProveedor.ToString();
                txtNombreProveedores.Text = p.Nombre;
                txtContactoProovedores.Text = p.Contacto;
                txtTelefonoProovedores.Text = p.Telefono;
                txtEmailProveedores.Text = p.Email;
            }
        }
        #endregion

        #region Movimientos
        private void ActualizarGridMovimientos()
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = _movService.Listar();
        }

        private void CargarGridProductosMovimientos()
        {
            dgvProductosMovimientos.DataSource = null;
            dgvProductosMovimientos.DataSource = _prodService.Listar();
        }

        private void RegistrarMovimiento(string tipo)
        {
            try
            {
                if (dgvProductosMovimientos.CurrentRow == null) throw new Exception("Seleccione un producto.");
                var prod = (Producto)dgvProductosMovimientos.CurrentRow.DataBoundItem;
                
                int cant = tipo == "Entrada" ? int.Parse(txtStockEntrada.Text) : int.Parse(txtSalida.Text);
                
                var m = new Movimiento
                {
                    IdProducto = prod.IdProducto,
                    Tipo = tipo,
                    Cantidad = cant,
                    Descripcion = "Movimiento registrado desde GUI"
                };
                _movService.Registrar(m);
                ActualizarGridMovimientos();
                ActualizarGridProductos();
                CargarGridProductosMovimientos();
                MessageBox.Show($"Movimiento de {tipo} registrado.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SeleccionarProductoMovimiento()
        {
            // Optional: Show selected product name in a label
        }
        #endregion
    }
}
