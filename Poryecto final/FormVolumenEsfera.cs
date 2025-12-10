/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:52 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormVolumenEsfera.
	/// </summary>
	public partial class FormVolumenEsfera : Form
	{
		public FormVolumenEsfera()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			 double r;

            if (!double.TryParse(txtRadio.Text, out r) || r <= 0)
            {
                MessageBox.Show("Ingresa un numero valido.");
                return;
            }

            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            lblResultado.Text = "Volumen: " + volumen.ToString("0.00");
		}
	}
}
