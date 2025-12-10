/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 03:43 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormFibonacci.
	/// </summary>
	public partial class FormFibonacci : Form
	{
		public FormFibonacci()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnGenerarClick(object sender, EventArgs e)
		{
			 int n;

            if (!int.TryParse(txtCantidad.Text, out n) || n <= 0)
            {
                MessageBox.Show("Ingresa un numero entero mayor a 0.");
                return;
            }

            int a = 0, b = 1, c;
            string serie = "";

            for (int i = 1; i <= n; i++)
            {
                serie += a + " ";
                c = a + b;
                a = b;
                b = c;
            }

            lblResultado.Text = "Resultado: " + serie;
		}
	}
}
