/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 03:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int inten=0;
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
		
		void BtnIngresarClick(object sender, EventArgs e)
		{
            string user = "admin";       
            string pass = "1234";         

            if (txtUsuario.Text == user && txtPassword.Text == pass)
            {
                FormPrincipal f = new FormPrincipal();
                f.Show();
                this.Hide();
            }
            else
            {
                inten++;

                if (inten >= 3)
                {
                    MessageBox.Show("Has agotado los 3 intentos.\nEl programa se cerrara.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.\nIntentos restantes: " + (3 - inten));
                }
            }
        }
    }
}