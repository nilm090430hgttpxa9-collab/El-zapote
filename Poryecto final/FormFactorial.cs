/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 03:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormFactorial.
	/// </summary>
	public partial class FormFactorial : Form
	{
		public FormFactorial()
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
			int n;
            long resultado = 1;

            if (!int.TryParse(txtNumero.Text, out n) || n < 0)
            {
                MessageBox.Show("Ingresa un numero valido.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            lblResultado.Text = "Resultado: " + resultado;
		}
	}
}
