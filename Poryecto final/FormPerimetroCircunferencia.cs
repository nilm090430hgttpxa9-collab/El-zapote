/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormPerimetroCircunferencia.
	/// </summary>
	public partial class FormPerimetroCircunferencia : Form
	{
		public FormPerimetroCircunferencia()
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

            if (!double.TryParse(txtRadio.Text, out r))
            {
                MessageBox.Show("Ingresa un numero valido.");
                return;
            }

            double perimetro = 2 * Math.PI * r;

            lblResultado.Text = "Perimetro: " + perimetro.ToString("0.00");
		}
	}
}
