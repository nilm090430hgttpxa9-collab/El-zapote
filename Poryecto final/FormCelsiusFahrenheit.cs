/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormCelsiusFahrenheit.
	/// </summary>
	public partial class FormCelsiusFahrenheit : Form
	{
		public FormCelsiusFahrenheit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			 double c;

            if (!double.TryParse(txtCelsius.Text, out c))
            {
                MessageBox.Show("Ingresa un valor valido.");
                return;
            }

            double f = (c * 9.0 / 5.0) + 32;
            lblResultado.Text = "Fahrenheit: " + f.ToString("0.00");
		}
	}
}
