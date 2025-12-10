/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:50 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormAreaRectangulo.
	/// </summary>
	public partial class FormAreaRectangulo : Form
	{
		public FormAreaRectangulo()
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
			double b, h;

            if (!double.TryParse(txtBase.Text, out b) ||
                !double.TryParse(txtAltura.Text, out h))
            {
                MessageBox.Show("Ingresa valores validos.");
                return;
            }

            double area = b * h;
            lblResultado.Text = "Area: " + area;
		}
	}
}
