/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:49 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormAreaCuadrado.
	/// </summary>
	public partial class FormAreaCuadrado : Form
	{
		public FormAreaCuadrado()
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
			 double lado;

            if (!double.TryParse(txtLado.Text, out lado))
            {
                MessageBox.Show("Ingresa un numero valido.");
                return;
            }

            double area = lado * lado;
            lblResultado.Text = "Area: " + area;
		}
	}
}
