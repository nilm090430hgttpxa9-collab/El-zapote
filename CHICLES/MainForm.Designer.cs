/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 11/12/2025
 * Hora: 03:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CHICLES
{
	partial class frmPostres
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostres));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rbDulces = new System.Windows.Forms.RadioButton();
			this.cbProductos = new System.Windows.Forms.ComboBox();
			this.rbSalados = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.Pagado = new System.Windows.Forms.Label();
			this.txtPagado = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtImporteNeto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.colProducto = new System.Windows.Forms.ColumnHeader();
			this.colPrecio = new System.Windows.Forms.ColumnHeader();
			this.colCantidad = new System.Windows.Forms.ColumnHeader();
			this.colTotal = new System.Windows.Forms.ColumnHeader();
			this.label3 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(629, 104);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// rbDulces
			// 
			this.rbDulces.Location = new System.Drawing.Point(12, 135);
			this.rbDulces.Name = "rbDulces";
			this.rbDulces.Size = new System.Drawing.Size(104, 24);
			this.rbDulces.TabIndex = 37;
			this.rbDulces.TabStop = true;
			this.rbDulces.Text = "dulces";
			this.rbDulces.UseVisualStyleBackColor = true;
			this.rbDulces.CheckedChanged += new System.EventHandler(this.RbDulcesCheckedChanged);
			// 
			// cbProductos
			// 
			this.cbProductos.FormattingEnabled = true;
			this.cbProductos.Items.AddRange(new object[] {
									"",
									"",
									"Postre Dulce 1",
									"Postre Dulce 2",
									"Postre Dulce 3",
									"",
									"Postre Salado 1",
									"Postre Salado 2",
									"Postre Salado 3"});
			this.cbProductos.Location = new System.Drawing.Point(181, 108);
			this.cbProductos.Name = "cbProductos";
			this.cbProductos.Size = new System.Drawing.Size(121, 24);
			this.cbProductos.TabIndex = 57;
			this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.CbProductosSelectedIndexChanged);
			// 
			// rbSalados
			// 
			this.rbSalados.Location = new System.Drawing.Point(122, 135);
			this.rbSalados.Name = "rbSalados";
			this.rbSalados.Size = new System.Drawing.Size(104, 24);
			this.rbSalados.TabIndex = 38;
			this.rbSalados.TabStop = true;
			this.rbSalados.Text = "salados";
			this.rbSalados.UseVisualStyleBackColor = true;
			this.rbSalados.CheckedChanged += new System.EventHandler(this.RbSaladosCheckedChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(503, 450);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 56;
			this.label6.Text = "cambio";
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(503, 475);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(100, 22);
			this.txtCambio.TabIndex = 55;
			// 
			// Pagado
			// 
			this.Pagado.Location = new System.Drawing.Point(69, 472);
			this.Pagado.Name = "Pagado";
			this.Pagado.Size = new System.Drawing.Size(72, 23);
			this.Pagado.TabIndex = 54;
			this.Pagado.Text = "Pagado";
			// 
			// txtPagado
			// 
			this.txtPagado.Location = new System.Drawing.Point(147, 474);
			this.txtPagado.Name = "txtPagado";
			this.txtPagado.Size = new System.Drawing.Size(100, 22);
			this.txtPagado.TabIndex = 53;
			this.txtPagado.TextChanged += new System.EventHandler(this.TxtPagadoTextChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(253, 474);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 52;
			this.label5.Text = "Importe neto";
			// 
			// txtImporteNeto
			// 
			this.txtImporteNeto.Location = new System.Drawing.Point(358, 474);
			this.txtImporteNeto.Name = "txtImporteNeto";
			this.txtImporteNeto.Size = new System.Drawing.Size(100, 22);
			this.txtImporteNeto.TabIndex = 51;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(253, 448);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 50;
			this.label4.Text = "descuento";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(358, 449);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(100, 22);
			this.txtDescuento.TabIndex = 49;
			this.txtDescuento.TextChanged += new System.EventHandler(this.TxtDescuentoTextChanged);
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(147, 450);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
			this.txtSubtotal.TabIndex = 48;
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.colProducto,
									this.colPrecio,
									this.colCantidad,
									this.colTotal});
			this.listView2.Location = new System.Drawing.Point(75, 301);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(471, 131);
			this.listView2.TabIndex = 47;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// colProducto
			// 
			this.colProducto.Text = "Producto";
			this.colProducto.Width = 141;
			// 
			// colPrecio
			// 
			this.colPrecio.Text = "Precio";
			// 
			// colCantidad
			// 
			this.colCantidad.Text = "Cantidad";
			this.colCantidad.Width = 99;
			// 
			// colTotal
			// 
			this.colTotal.Text = "Total";
			this.colTotal.Width = 100;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(86, 449);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 46;
			this.label3.Text = "subtotal";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(441, 255);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 25);
			this.btnEliminar.TabIndex = 45;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(441, 209);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 31);
			this.btnAgregar.TabIndex = 44;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(287, 190);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 43;
			this.label10.Text = "total";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(181, 190);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 42;
			this.label9.Text = "cantidad";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(287, 218);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 22);
			this.txtTotal.TabIndex = 41;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(181, 218);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 22);
			this.txtCantidad.TabIndex = 40;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(75, 218);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 22);
			this.txtPrecio.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(75, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 36;
			this.label2.Text = "precio";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 23);
			this.label1.TabIndex = 35;
			this.label1.Text = "sleccionar producto";
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Cyan;
			this.btnGuardar.Location = new System.Drawing.Point(12, 255);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(197, 25);
			this.btnGuardar.TabIndex = 59;
			this.btnGuardar.Text = "Guardar en base de datos";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.Cyan;
			this.btnBorrar.Location = new System.Drawing.Point(215, 255);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(197, 25);
			this.btnBorrar.TabIndex = 60;
			this.btnBorrar.Text = "Eliminar de la base de datos";
			this.btnBorrar.UseVisualStyleBackColor = false;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(326, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 23);
			this.label7.TabIndex = 61;
			this.label7.Text = "Codigo de dulce:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(464, 111);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 22);
			this.txtCodigo.TabIndex = 62;
			// 
			// frmPostres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(645, 523);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rbDulces);
			this.Controls.Add(this.cbProductos);
			this.Controls.Add(this.rbSalados);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.Pagado);
			this.Controls.Add(this.txtPagado);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtImporteNeto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmPostres";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "CHICLES";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader colTotal;
		private System.Windows.Forms.ColumnHeader colCantidad;
		private System.Windows.Forms.ColumnHeader colPrecio;
		private System.Windows.Forms.ColumnHeader colProducto;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtImporteNeto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPagado;
		private System.Windows.Forms.Label Pagado;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rbSalados;
		private System.Windows.Forms.ComboBox cbProductos;
		private System.Windows.Forms.RadioButton rbDulces;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
