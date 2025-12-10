/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 09/12/2025
 * Hora: 09:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormAcercaDeAlejandro.
	/// </summary>
	public partial class FormAcercaDeAlejandro : Form
	{
		public FormAcercaDeAlejandro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
