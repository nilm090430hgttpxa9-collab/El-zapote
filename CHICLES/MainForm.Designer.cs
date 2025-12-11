/*
 * Creado por SharpDevelop.
 * Usuario: janux
 * Fecha: 08/12/2025
 * Hora: 08:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CHICLES
{
	partial class frmProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.colProducto = new System.Windows.Forms.ColumnHeader();
			this.colPrecio = new System.Windows.Forms.ColumnHeader();
			this.colCantidad = new System.Windows.Forms.ColumnHeader();
			this.colTotal = new System.Windows.Forms.ColumnHeader();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtImporteNeto = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPagado = new System.Windows.Forms.TextBox();
			this.Pagado = new System.Windows.Forms.Label();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbProductos = new System.Windows.Forms.ComboBox();
			this.rbSalados = new System.Windows.Forms.RadioButton();
			this.rbDulces = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(98, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "sleccionar producto";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "precio";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(60, 223);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 22);
			this.txtPrecio.TabIndex = 11;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(166, 223);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 22);
			this.txtCantidad.TabIndex = 14;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(272, 223);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 22);
			this.txtTotal.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(166, 195);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "cantidad";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(272, 195);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "total";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(426, 223);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 19;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(426, 260);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(71, 454);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "subtotal";
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.colProducto,
									this.colPrecio,
									this.colCantidad,
									this.colTotal});
			this.listView2.Location = new System.Drawing.Point(60, 306);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(471, 131);
			this.listView2.TabIndex = 22;
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
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(132, 455);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
			this.txtSubtotal.TabIndex = 23;
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(343, 454);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(100, 22);
			this.txtDescuento.TabIndex = 24;
			this.txtDescuento.TextChanged += new System.EventHandler(this.TxtDescuentoTextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(238, 453);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 25;
			this.label4.Text = "descuento";
			// 
			// txtImporteNeto
			// 
			this.txtImporteNeto.Location = new System.Drawing.Point(343, 479);
			this.txtImporteNeto.Name = "txtImporteNeto";
			this.txtImporteNeto.Size = new System.Drawing.Size(100, 22);
			this.txtImporteNeto.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(238, 479);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "Importe neto";
			// 
			// txtPagado
			// 
			this.txtPagado.Location = new System.Drawing.Point(132, 479);
			this.txtPagado.Name = "txtPagado";
			this.txtPagado.Size = new System.Drawing.Size(100, 22);
			this.txtPagado.TabIndex = 28;
			this.txtPagado.TextChanged += new System.EventHandler(this.TxtPagadoTextChanged);
			// 
			// Pagado
			// 
			this.Pagado.Location = new System.Drawing.Point(54, 477);
			this.Pagado.Name = "Pagado";
			this.Pagado.Size = new System.Drawing.Size(72, 23);
			this.Pagado.TabIndex = 29;
			this.Pagado.Text = "Pagado";
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(488, 480);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(100, 22);
			this.txtCambio.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(488, 455);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 31;
			this.label6.Text = "cambio";
			// 
			// cbProductos
			// 
			this.cbProductos.FormattingEnabled = true;
			this.cbProductos.Items.AddRange(new object[] {
									"",
									"Postre Dulce 1",
									"",
									"Postre Dulce 2",
									"",
									"Postre Dulce 3",
									"",
									"Postre Salado 1",
									"",
									"Postre Salado 2",
									"",
									"Postre Salado 3"});
			this.cbProductos.Location = new System.Drawing.Point(284, 137);
			this.cbProductos.Name = "cbProductos";
			this.cbProductos.Size = new System.Drawing.Size(121, 24);
			this.cbProductos.TabIndex = 33;
			this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.CbProductosSelectedIndexChanged);
			// 
			// rbSalados
			// 
			this.rbSalados.Location = new System.Drawing.Point(-3, 135);
			this.rbSalados.Name = "rbSalados";
			this.rbSalados.Size = new System.Drawing.Size(104, 24);
			this.rbSalados.TabIndex = 10;
			this.rbSalados.TabStop = true;
			this.rbSalados.Text = "saldos";
			this.rbSalados.UseVisualStyleBackColor = true;
			// 
			// rbDulces
			// 
			this.rbDulces.Location = new System.Drawing.Point(71, 136);
			this.rbDulces.Name = "rbDulces";
			this.rbDulces.Size = new System.Drawing.Size(104, 24);
			this.rbDulces.TabIndex = 9;
			this.rbDulces.TabStop = true;
			this.rbDulces.Text = "dulces";
			this.rbDulces.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-3, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(648, 104);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// frmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(645, 523);
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
			this.Name = "frmProducto";
			this.Text = "CHICLES";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbProductos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.Label Pagado;
		private System.Windows.Forms.TextBox txtPagado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtImporteNeto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.ColumnHeader colTotal;
		private System.Windows.Forms.ColumnHeader colCantidad;
		private System.Windows.Forms.ColumnHeader colPrecio;
		private System.Windows.Forms.ColumnHeader colProducto;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.RadioButton rbSalados;
		private System.Windows.Forms.RadioButton rbDulces;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
