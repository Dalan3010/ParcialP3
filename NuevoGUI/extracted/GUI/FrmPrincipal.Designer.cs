namespace GUI
{
    partial class FrmPrincipal
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
            this.tbPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnEditarProductos = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEliminarProveedores = new System.Windows.Forms.Button();
            this.btnEditarProveedores = new System.Windows.Forms.Button();
            this.btnAgregarProveedores = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreProveedores = new System.Windows.Forms.TextBox();
            this.txtContactoProovedores = new System.Windows.Forms.TextBox();
            this.txtIdProveedores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefonoProovedores = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmailProveedores = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStockEntrada = new System.Windows.Forms.TextBox();
            this.btnEntradaMovimientos = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSalidaMovimientos = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.dgvProductosMovimientos = new System.Windows.Forms.DataGridView();
            this.tbPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrincipal.Controls.Add(this.tabPage1);
            this.tbPrincipal.Controls.Add(this.tabPage2);
            this.tbPrincipal.Controls.Add(this.tabPage3);
            this.tbPrincipal.Controls.Add(this.tabPage4);
            this.tbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(901, 572);
            this.tbPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEliminarProductos);
            this.tabPage1.Controls.Add(this.btnEditarProductos);
            this.tabPage1.Controls.Add(this.btnAgregarProductos);
            this.tabPage1.Controls.Add(this.dgvProductos);
            this.tabPage1.Controls.Add(this.cmbProveedor);
            this.tabPage1.Controls.Add(this.cmbCategoria);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.txtPrecio);
            this.tabPage1.Controls.Add(this.txtStock);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminarCategoria);
            this.tabPage2.Controls.Add(this.btnEditarCategoria);
            this.tabPage2.Controls.Add(this.btnAgregarCategoria);
            this.tabPage2.Controls.Add(this.dgvCategorias);
            this.tabPage2.Controls.Add(this.txtNombreCategoria);
            this.tabPage2.Controls.Add(this.txtDescripcionCategoria);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtEmailProveedores);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtTelefonoProovedores);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.btnEliminarProveedores);
            this.tabPage3.Controls.Add(this.btnEditarProveedores);
            this.tabPage3.Controls.Add(this.btnAgregarProveedores);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.txtNombreProveedores);
            this.tabPage3.Controls.Add(this.txtContactoProovedores);
            this.tabPage3.Controls.Add(this.txtIdProveedores);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(893, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proveedores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvProductosMovimientos);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.btnSalidaMovimientos);
            this.tabPage4.Controls.Add(this.txtSalida);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.btnEntradaMovimientos);
            this.tabPage4.Controls.Add(this.txtStockEntrada);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.dgvMovimientos);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(893, 543);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movimientos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = " Precio :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(126, 244);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(161, 22);
            this.txtStock.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(126, 196);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(161, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(126, 150);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(161, 22);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Proveedor :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(126, 286);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(161, 24);
            this.cmbCategoria.TabIndex = 12;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(126, 332);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(161, 24);
            this.cmbProveedor.TabIndex = 13;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(327, 109);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(530, 247);
            this.dgvProductos.TabIndex = 14;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(39, 402);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(135, 57);
            this.btnAgregarProductos.TabIndex = 15;
            this.btnAgregarProductos.Text = "AGREGAR";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            // 
            // btnEditarProductos
            // 
            this.btnEditarProductos.Location = new System.Drawing.Point(228, 402);
            this.btnEditarProductos.Name = "btnEditarProductos";
            this.btnEditarProductos.Size = new System.Drawing.Size(135, 57);
            this.btnEditarProductos.TabIndex = 16;
            this.btnEditarProductos.Text = "EDITAR";
            this.btnEditarProductos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Location = new System.Drawing.Point(419, 402);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(135, 57);
            this.btnEliminarProductos.TabIndex = 17;
            this.btnEliminarProductos.Text = "ELIMINAR";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            this.btnEliminarProductos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(419, 427);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(135, 57);
            this.btnEliminarCategoria.TabIndex = 34;
            this.btnEliminarCategoria.Text = "ELIMINAR";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Location = new System.Drawing.Point(228, 427);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(135, 57);
            this.btnEditarCategoria.TabIndex = 33;
            this.btnEditarCategoria.Text = "EDITAR";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(39, 427);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(135, 57);
            this.btnAgregarCategoria.TabIndex = 32;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(327, 134);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(530, 247);
            this.dgvCategorias.TabIndex = 31;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(126, 175);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(161, 22);
            this.txtNombreCategoria.TabIndex = 27;
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(126, 221);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(161, 22);
            this.txtDescripcionCategoria.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 134);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Descripcion :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nombre :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "ID :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "CATEGORIAS";
            // 
            // btnEliminarProveedores
            // 
            this.btnEliminarProveedores.Location = new System.Drawing.Point(423, 427);
            this.btnEliminarProveedores.Name = "btnEliminarProveedores";
            this.btnEliminarProveedores.Size = new System.Drawing.Size(135, 57);
            this.btnEliminarProveedores.TabIndex = 45;
            this.btnEliminarProveedores.Text = "ELIMINAR";
            this.btnEliminarProveedores.UseVisualStyleBackColor = true;
            // 
            // btnEditarProveedores
            // 
            this.btnEditarProveedores.Location = new System.Drawing.Point(232, 427);
            this.btnEditarProveedores.Name = "btnEditarProveedores";
            this.btnEditarProveedores.Size = new System.Drawing.Size(135, 57);
            this.btnEditarProveedores.TabIndex = 44;
            this.btnEditarProveedores.Text = "EDITAR";
            this.btnEditarProveedores.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedores
            // 
            this.btnAgregarProveedores.Location = new System.Drawing.Point(43, 427);
            this.btnAgregarProveedores.Name = "btnAgregarProveedores";
            this.btnAgregarProveedores.Size = new System.Drawing.Size(135, 57);
            this.btnAgregarProveedores.TabIndex = 43;
            this.btnAgregarProveedores.Text = "AGREGAR";
            this.btnAgregarProveedores.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 247);
            this.dataGridView1.TabIndex = 42;
            // 
            // txtNombreProveedores
            // 
            this.txtNombreProveedores.Location = new System.Drawing.Point(130, 175);
            this.txtNombreProveedores.Name = "txtNombreProveedores";
            this.txtNombreProveedores.Size = new System.Drawing.Size(161, 22);
            this.txtNombreProveedores.TabIndex = 41;
            // 
            // txtContactoProovedores
            // 
            this.txtContactoProovedores.Location = new System.Drawing.Point(130, 221);
            this.txtContactoProovedores.Name = "txtContactoProovedores";
            this.txtContactoProovedores.Size = new System.Drawing.Size(161, 22);
            this.txtContactoProovedores.TabIndex = 40;
            // 
            // txtIdProveedores
            // 
            this.txtIdProveedores.Location = new System.Drawing.Point(130, 134);
            this.txtIdProveedores.Name = "txtIdProveedores";
            this.txtIdProveedores.Size = new System.Drawing.Size(161, 22);
            this.txtIdProveedores.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Contacto :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Nombre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "ID :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "PROVEEDORES";
            // 
            // txtTelefonoProovedores
            // 
            this.txtTelefonoProovedores.Location = new System.Drawing.Point(130, 270);
            this.txtTelefonoProovedores.Name = "txtTelefonoProovedores";
            this.txtTelefonoProovedores.Size = new System.Drawing.Size(161, 22);
            this.txtTelefonoProovedores.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 46;
            this.label16.Text = "Telefono :";
            // 
            // txtEmailProveedores
            // 
            this.txtEmailProveedores.Location = new System.Drawing.Point(130, 316);
            this.txtEmailProveedores.Name = "txtEmailProveedores";
            this.txtEmailProveedores.Size = new System.Drawing.Size(161, 22);
            this.txtEmailProveedores.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(70, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 16);
            this.label17.TabIndex = 48;
            this.label17.Text = "Email :";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(447, 284);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersWidth = 51;
            this.dgvMovimientos.RowTemplate.Height = 24;
            this.dgvMovimientos.Size = new System.Drawing.Size(378, 182);
            this.dgvMovimientos.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Entrada :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Salida :";
            // 
            // txtStockEntrada
            // 
            this.txtStockEntrada.Location = new System.Drawing.Point(113, 135);
            this.txtStockEntrada.Name = "txtStockEntrada";
            this.txtStockEntrada.Size = new System.Drawing.Size(197, 22);
            this.txtStockEntrada.TabIndex = 4;
            // 
            // btnEntradaMovimientos
            // 
            this.btnEntradaMovimientos.Location = new System.Drawing.Point(40, 174);
            this.btnEntradaMovimientos.Name = "btnEntradaMovimientos";
            this.btnEntradaMovimientos.Size = new System.Drawing.Size(186, 49);
            this.btnEntradaMovimientos.TabIndex = 5;
            this.btnEntradaMovimientos.Text = "button1";
            this.btnEntradaMovimientos.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "Stock :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(37, 323);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 16);
            this.label21.TabIndex = 11;
            this.label21.Text = "Stock :";
            // 
            // btnSalidaMovimientos
            // 
            this.btnSalidaMovimientos.Location = new System.Drawing.Point(40, 362);
            this.btnSalidaMovimientos.Name = "btnSalidaMovimientos";
            this.btnSalidaMovimientos.Size = new System.Drawing.Size(186, 62);
            this.btnSalidaMovimientos.TabIndex = 10;
            this.btnSalidaMovimientos.Text = "button2";
            this.btnSalidaMovimientos.UseVisualStyleBackColor = true;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(113, 323);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(197, 22);
            this.txtSalida.TabIndex = 9;
            // 
            // dgvProductosMovimientos
            // 
            this.dgvProductosMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosMovimientos.Location = new System.Drawing.Point(447, 41);
            this.dgvProductosMovimientos.Name = "dgvProductosMovimientos";
            this.dgvProductosMovimientos.RowHeadersWidth = 51;
            this.dgvProductosMovimientos.RowTemplate.Height = 24;
            this.dgvProductosMovimientos.Size = new System.Drawing.Size(378, 182);
            this.dgvProductosMovimientos.TabIndex = 12;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 596);
            this.Controls.Add(this.tbPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.tbPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnEditarProductos;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoProovedores;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminarProveedores;
        private System.Windows.Forms.Button btnEditarProveedores;
        private System.Windows.Forms.Button btnAgregarProveedores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreProveedores;
        private System.Windows.Forms.TextBox txtContactoProovedores;
        private System.Windows.Forms.TextBox txtIdProveedores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmailProveedores;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSalidaMovimientos;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEntradaMovimientos;
        private System.Windows.Forms.TextBox txtStockEntrada;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvProductosMovimientos;
    }
}