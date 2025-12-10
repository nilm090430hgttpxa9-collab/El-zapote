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
	/// Description of FormKgLibras.
	/// </summary>
	public partial class FormKgLibras : Form
	{
		public FormKgLibras()
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
			double kg;

            if (!double.TryParse(txtKilogramos.Text, out kg) || kg < 0)
            {
                MessageBox.Show("Ingresa un valor valido.");
                return;
            }

            double libras = kg * 2.20462;
            lblResultado.Text = "Libras: " + libras.ToString("0.00");
		}
	}
}
