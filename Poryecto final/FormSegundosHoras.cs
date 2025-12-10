/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormSegundosHoras.
	/// </summary>
	public partial class FormSegundosHoras : Form
	{
		public FormSegundosHoras()
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
			 double seg;

                if (!double.TryParse(txtSegundos.Text, out seg) || seg < 0)
                {
                    MessageBox.Show("Ingresa un valor válido.");
                    return;
                }

                double horas = seg / 3600.0;
                lblResultado.Text = "Horas: " + horas.ToString("0.00");
		}
	}
}
