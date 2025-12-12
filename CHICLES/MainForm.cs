/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 11/12/2025
 * Hora: 03:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CHICLES
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmPostres : Form
	{
		  decimal subtotal = 0;
        decimal totalNeto = 0;

		public frmPostres()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		 void CalcularNeto()
        {
              decimal sub = 0, desc = 0, pagado = 0, importe = 0, cambio = 0;

    decimal.TryParse(txtSubtotal.Text, out sub);

    if (!decimal.TryParse(txtDescuento.Text, out desc))
        desc = 0;

    if (desc > sub)
    {
        desc = sub;
        txtDescuento.Text = sub.ToString("0.00");
    }

    importe = sub - desc;
    totalNeto = importe;
    txtImporteNeto.Text = importe.ToString("0.00");

    if (!decimal.TryParse(txtPagado.Text, out pagado))
        pagado = 0;

    cambio = pagado - importe;

    if (cambio < 0)
        cambio = 0;

    txtCambio.Text = cambio.ToString("0.00");
        }
		
		void RbDulcesCheckedChanged(object sender, EventArgs e)
		{
			if (rbDulces.Checked)
            {
                cbProductos.Items.Clear();
                cbProductos.Items.Add("Postre Dulce 1");
                cbProductos.Items.Add("Postre Dulce 2");
                cbProductos.Items.Add("Postre Dulce 3");
                cbProductos.SelectedIndex = 0;
            }
		}
		
		void RbSaladosCheckedChanged(object sender, EventArgs e)
		{
			 if (rbSalados.Checked)
            {
                cbProductos.Items.Clear();
                cbProductos.Items.Add("Postre Salado 1");
                cbProductos.Items.Add("Postre Salado 2");
                cbProductos.Items.Add("Postre Salado 3");
                cbProductos.SelectedIndex = 0;
            }
		}
		
		void CbProductosSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbProductos.Text.Contains("1")) txtPrecio.Text = "10";
            else if (cbProductos.Text.Contains("2")) txtPrecio.Text = "20";
            else if (cbProductos.Text.Contains("3")) txtPrecio.Text = "30";
		}
		
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			decimal precio = 0;
            int cantidad = 0;

            if (decimal.TryParse(txtPrecio.Text, out precio) &&
                int.TryParse(txtCantidad.Text, out cantidad))
            {
                txtTotal.Text = (precio * cantidad).ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			 if (txtTotal.Text == "") return;

            ListViewItem item = new ListViewItem(cbProductos.Text);
            item.SubItems.Add(txtPrecio.Text);
            item.SubItems.Add(txtCantidad.Text);
            item.SubItems.Add(txtTotal.Text);

            listView2.Items.Add(item);

            subtotal += Convert.ToDecimal(txtTotal.Text);
            txtSubtotal.Text = subtotal.ToString();

            CalcularNeto();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			 if (listView2.SelectedItems.Count > 0)
            {
                decimal restar = Convert.ToDecimal(listView2.SelectedItems[0].SubItems[3].Text);
                subtotal -= restar;
                txtSubtotal.Text = subtotal.ToString();

                listView2.Items.Remove(listView2.SelectedItems[0]);

                CalcularNeto();
            }
		}
		
		void TxtDescuentoTextChanged(object sender, EventArgs e)
		{
			  CalcularNeto();
		}
		
		void TxtPagadoTextChanged(object sender, EventArgs e)
		{
			decimal pagado = 0;
            decimal.TryParse(txtPagado.Text, out pagado);
            txtCambio.Text = (pagado - totalNeto).ToString("0.00");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string conexion = "server=localhost; database=postres; user=root; password=root;";
   		 	MySqlConnection cn = new MySqlConnection(conexion);

    		try
    		{
        		cn.Open();

        		string query = "INSERT INTO Productosdulces (id_codigo, nombre, precio, cantidad, total) " +
                       "VALUES (@id, @nombre, @precio, @cantidad, @total)";
        		MySqlCommand cmd = new MySqlCommand(query, cn);

        		cmd.Parameters.AddWithValue("@id", int.Parse(txtCodigo.Text));
        		cmd.Parameters.AddWithValue("@nombre", cbProductos.Text);
		        cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
		        cmd.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
		        cmd.Parameters.AddWithValue("@total", txtTotal.Text);
		
		        cmd.ExecuteNonQuery();
		
		        MessageBox.Show("Registro guardado correctamente");
			    }
			    finally
			    {
			        cn.Close();
			    }
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			string conexion = "server=localhost; database=postres; user=root; password=root;";
    		MySqlConnection cn = new MySqlConnection(conexion);

   	 		try
    		{
        		cn.Open();
        		string query = "DELETE FROM Productosdulces WHERE id_codigo = @id";
        		MySqlCommand cmd = new MySqlCommand(query, cn);
		        cmd.Parameters.AddWithValue("@id", int.Parse(txtCodigo.Text));

		        int filas = cmd.ExecuteNonQuery();
		        if (filas > 0)
		            MessageBox.Show("Registro eliminado correctamente");
		        else
		            MessageBox.Show("No se encontró un empleado con ese ID");
		    }
		    finally
		    {
		        cn.Close();
		    }
		}
	}
}
