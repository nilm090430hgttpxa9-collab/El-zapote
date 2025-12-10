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
	/// Description of FormVolumenPiramide.
	/// </summary>
	public partial class FormVolumenPiramide : Form
	{
		public FormVolumenPiramide()
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
			 double areaBase, altura;

            if (!double.TryParse(txtBase.Text, out areaBase) ||
                !double.TryParse(txtAltura.Text, out altura) ||
                areaBase <= 0 || altura <= 0)
            {
                MessageBox.Show("Ingresa valores validos.");
                return;
            }

            double volumen = (areaBase * altura) / 3.0;
            lblResultado.Text = "Volumen: " + volumen.ToString("0.00");
		}
	}
}
