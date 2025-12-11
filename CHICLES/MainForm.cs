using System;
using System.Windows.Forms;

namespace CHICLES
{
    public partial class frmProducto : Form
    {
        decimal subtotal = 0;
        decimal totalNeto = 0;

        public frmProducto()
        {
            InitializeComponent();
        }

        // -----------------------------
        // Cargar productos según radio
        // -----------------------------
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

        // ----------------------------
        // Asignar precio según producto
        // ----------------------------
        void CbProductosSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductos.Text.Contains("1")) txtPrecio.Text = "5";
            else if (cbProductos.Text.Contains("2")) txtPrecio.Text = "10";
            else if (cbProductos.Text.Contains("3")) txtPrecio.Text = "15";
        }

        // -----------------------------
        // Calcular total (precio * cantidad)
        // -----------------------------
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

        // -----------------------------
        // Agregar al ListView
        // -----------------------------
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

        // -----------------------------
        // Eliminar del ListView
        // -----------------------------
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

        // -----------------------------
        // Recalcular importe cuando cambie descuento
        // -----------------------------
        void TxtDescuentoTextChanged(object sender, EventArgs e)
        {
            CalcularNeto();
        }

        // -----------------------------
        // Recalcular cambio cuando cambie pagado
        // -----------------------------
        void TxtPagadoTextChanged(object sender, EventArgs e)
        {
            decimal pagado = 0;
            decimal.TryParse(txtPagado.Text, out pagado);
            txtCambio.Text = (pagado - totalNeto).ToString("0.00");
        }

        // -----------------------------
        // Cálculo final con validación
        // -----------------------------
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
    }
}
