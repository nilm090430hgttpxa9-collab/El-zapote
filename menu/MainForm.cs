/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 04/12/2025
 * Hora: 08:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace menu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			string contraCorrecta = "1234";
		
			if(txtContra.Text == contraCorrecta)
			{
				frmPrincipal frm = new frmPrincipal();
				frm.Show();
				this.Hide();
			}
		}
	}
}
