/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 03:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poryecto_final
{
	/// <summary>
	/// Description of FormPrincipal.
	/// </summary>
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CerrarVentanas()
		{
    		foreach (Form ventanas in this.MdiChildren)
    		{
       	 		ventanas.Close();
    		}
		}
		
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormFactorial f = new FormFactorial();
            f.MdiParent = this;
            f.Show();
		}
		
		void FibonacciToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormFibonacci f = new FormFibonacci();
            f.MdiParent = this;
            f.Show();
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormAreaCuadrado f = new FormAreaCuadrado();
            f.MdiParent = this;
            f.Show();
		}
		
		void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormAreaRectangulo f = new FormAreaRectangulo();
            f.MdiParent = this;
            f.Show();
		}
		
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormAreaTriangulo f = new FormAreaTriangulo();
            f.MdiParent = this;
            f.Show();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormPerimetroCircunferencia f = new FormPerimetroCircunferencia();
            f.MdiParent = this;
            f.Show();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormPerimetroTrapecio f = new FormPerimetroTrapecio();
            f.MdiParent = this;
            f.Show();
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormVolumenEsfera f = new FormVolumenEsfera();
            f.MdiParent = this;
            f.Show();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormVolumenCubo f = new FormVolumenCubo();
            f.MdiParent = this;
            f.Show();
		}
		
		void PiramideToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormVolumenPiramide f = new FormVolumenPiramide();
            f.MdiParent = this;
            f.Show();
		}
		
		void KmMillasToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormKmMillas f = new FormKmMillas();
            f.MdiParent = this;
            f.Show();
		}
		
		void KgLibrasToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormKgLibras f = new FormKgLibras();
            f.MdiParent = this;
            f.Show();
		}
		
		void CFToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormCelsiusFahrenheit f = new FormCelsiusFahrenheit();
            f.MdiParent = this;
            f.Show();
		}
		
		void SegundosHorasToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormSegundosHoras f = new FormSegundosHoras();
            f.MdiParent = this;
            f.Show();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult respuesta;

            respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
		}
		
		void MaximusToolStripMenuItemClick(object sender, EventArgs e)
		{	
			CerrarVentanas();
			
			FormAcercaDeMaximus f = new FormAcercaDeMaximus();
			f.MdiParent = this;
			f.Show();
		}
		
		void AlejandroToolStripMenuItemClick(object sender, EventArgs e)
		{	
			CerrarVentanas();
			
			FormAcercaDeAlejandro f = new FormAcercaDeAlejandro();
			f.MdiParent = this;
			f.Show();
		}
		
		void AlexisToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			FormAcercaDeAlexis f = new FormAcercaDeAlexis();
			f.MdiParent = this;
			f.Show();
		}
		
		void BoletaDeCalificasionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			Boleta.frmBoletaCalificasiones frmBolea = new Boleta.frmBoletaCalificasiones();
			frmBolea.MdiParent = this;
			frmBolea.Show();
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			CerrarVentanas();
			
			evaluacion3.MainForm f = new evaluacion3.MainForm();
			f.MdiParent = this;
			f.Show();
		}
	}
}