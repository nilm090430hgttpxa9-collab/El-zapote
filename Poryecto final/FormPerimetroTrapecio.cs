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
	/// Description of FormPerimetroTrapecio.
	/// </summary>
	public partial class FormPerimetroTrapecio : Form
	{
		public FormPerimetroTrapecio()
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
			 double lado1, lado2, baseMayor, baseMenor;

            if (!double.TryParse(txtLado1.Text, out lado1) ||
                !double.TryParse(txtLado2.Text, out lado2) ||
                !double.TryParse(txtBaseMayor.Text, out baseMayor) ||
                !double.TryParse(txtBaseMenor.Text, out baseMenor))
            {
                MessageBox.Show("Ingresa valores numericos correctos.");
                return;
            }

            double perimetro = lado1 + lado2 + baseMayor + baseMenor;

            lblResultado.Text = "Perimetro: " + perimetro;
		}
	}
}
