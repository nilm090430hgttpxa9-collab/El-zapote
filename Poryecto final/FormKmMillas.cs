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
	/// Description of FormKmMillas.
	/// </summary>
	public partial class FormKmMillas : Form
	{
		public FormKmMillas()
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
			 double km;

            if (!double.TryParse(txtKilometros.Text, out km) || km < 0)
            {
                MessageBox.Show("Ingresa un valor valido.");
                return;
            }

            double millas = km * 0.621371;
            lblResultado.Text = "Millas: " + millas.ToString("0.00");
		}
	}
}
