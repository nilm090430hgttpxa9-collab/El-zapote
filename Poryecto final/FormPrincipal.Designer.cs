/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 03:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Poryecto_final
{
	partial class FormPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aplicasionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.piramideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kmMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kgLibrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segundosHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaDeCalificasionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivoSalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maximusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alejandroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alexisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Gray;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aplicasionToolStripMenuItem,
									this.areaToolStripMenuItem,
									this.perimetroToolStripMenuItem,
									this.volumenToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.boletaDeCalificasionesToolStripMenuItem,
									this.archivoSalirToolStripMenuItem,
									this.aToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1039, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aplicasionToolStripMenuItem
			// 
			this.aplicasionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialToolStripMenuItem,
									this.fibonacciToolStripMenuItem});
			this.aplicasionToolStripMenuItem.Name = "aplicasionToolStripMenuItem";
			this.aplicasionToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
			this.aplicasionToolStripMenuItem.Text = "Aplicacion";
			// 
			// factorialToolStripMenuItem
			// 
			this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
			this.factorialToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.factorialToolStripMenuItem.Text = "Factorial";
			this.factorialToolStripMenuItem.Click += new System.EventHandler(this.FactorialToolStripMenuItemClick);
			// 
			// fibonacciToolStripMenuItem
			// 
			this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
			this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.fibonacciToolStripMenuItem.Text = "Fibonacci";
			this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.FibonacciToolStripMenuItemClick);
			// 
			// areaToolStripMenuItem
			// 
			this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadradoToolStripMenuItem,
									this.rectanguloToolStripMenuItem,
									this.trianguloToolStripMenuItem});
			this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
			this.areaToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.areaToolStripMenuItem.Text = "Area";
			// 
			// cuadradoToolStripMenuItem
			// 
			this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
			this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.cuadradoToolStripMenuItem.Text = "Cuadrado";
			this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.CuadradoToolStripMenuItemClick);
			// 
			// rectanguloToolStripMenuItem
			// 
			this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
			this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.rectanguloToolStripMenuItem.Text = "Rectangulo";
			this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.RectanguloToolStripMenuItemClick);
			// 
			// trianguloToolStripMenuItem
			// 
			this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
			this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.trianguloToolStripMenuItem.Text = "Triangulo";
			this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.TrianguloToolStripMenuItemClick);
			// 
			// perimetroToolStripMenuItem
			// 
			this.perimetroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
			this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.perimetroToolStripMenuItem.Text = "Perimetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			this.circunferenciaToolStripMenuItem.Click += new System.EventHandler(this.CircunferenciaToolStripMenuItemClick);
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.TrapecioToolStripMenuItemClick);
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.volumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem,
									this.piramideToolStripMenuItem});
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.volumenToolStripMenuItem.Text = "Volumen";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.esferaToolStripMenuItem.Text = "Esfera";
			this.esferaToolStripMenuItem.Click += new System.EventHandler(this.EsferaToolStripMenuItemClick);
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.cuboToolStripMenuItem.Text = "Cubo";
			this.cuboToolStripMenuItem.Click += new System.EventHandler(this.CuboToolStripMenuItemClick);
			// 
			// piramideToolStripMenuItem
			// 
			this.piramideToolStripMenuItem.Name = "piramideToolStripMenuItem";
			this.piramideToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.piramideToolStripMenuItem.Text = "Piramide";
			this.piramideToolStripMenuItem.Click += new System.EventHandler(this.PiramideToolStripMenuItemClick);
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.longitudToolStripMenuItem,
									this.masaToolStripMenuItem,
									this.temperaturaToolStripMenuItem,
									this.tiempoToolStripMenuItem});
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.conversionesToolStripMenuItem.Text = "Conversiones";
			// 
			// longitudToolStripMenuItem
			// 
			this.longitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kmMillasToolStripMenuItem});
			this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
			this.longitudToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.longitudToolStripMenuItem.Text = "Longitud";
			// 
			// kmMillasToolStripMenuItem
			// 
			this.kmMillasToolStripMenuItem.Name = "kmMillasToolStripMenuItem";
			this.kmMillasToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.kmMillasToolStripMenuItem.Text = "km - Millas";
			this.kmMillasToolStripMenuItem.Click += new System.EventHandler(this.KmMillasToolStripMenuItemClick);
			// 
			// masaToolStripMenuItem
			// 
			this.masaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kgLibrasToolStripMenuItem});
			this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
			this.masaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.masaToolStripMenuItem.Text = "Masa";
			// 
			// kgLibrasToolStripMenuItem
			// 
			this.kgLibrasToolStripMenuItem.Name = "kgLibrasToolStripMenuItem";
			this.kgLibrasToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.kgLibrasToolStripMenuItem.Text = "Kg - Libras";
			this.kgLibrasToolStripMenuItem.Click += new System.EventHandler(this.KgLibrasToolStripMenuItemClick);
			// 
			// temperaturaToolStripMenuItem
			// 
			this.temperaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cFToolStripMenuItem});
			this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
			this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.temperaturaToolStripMenuItem.Text = "Temperatura";
			// 
			// cFToolStripMenuItem
			// 
			this.cFToolStripMenuItem.Name = "cFToolStripMenuItem";
			this.cFToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.cFToolStripMenuItem.Text = "°C - °F";
			this.cFToolStripMenuItem.Click += new System.EventHandler(this.CFToolStripMenuItemClick);
			// 
			// tiempoToolStripMenuItem
			// 
			this.tiempoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.segundosHorasToolStripMenuItem});
			this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
			this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.tiempoToolStripMenuItem.Text = "Tiempo";
			// 
			// segundosHorasToolStripMenuItem
			// 
			this.segundosHorasToolStripMenuItem.Name = "segundosHorasToolStripMenuItem";
			this.segundosHorasToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
			this.segundosHorasToolStripMenuItem.Text = "Segundos - Horas";
			this.segundosHorasToolStripMenuItem.Click += new System.EventHandler(this.SegundosHorasToolStripMenuItemClick);
			// 
			// boletaDeCalificasionesToolStripMenuItem
			// 
			this.boletaDeCalificasionesToolStripMenuItem.Name = "boletaDeCalificasionesToolStripMenuItem";
			this.boletaDeCalificasionesToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
			this.boletaDeCalificasionesToolStripMenuItem.Text = "Boleta de calificasiones";
			this.boletaDeCalificasionesToolStripMenuItem.Click += new System.EventHandler(this.BoletaDeCalificasionesToolStripMenuItemClick);
			// 
			// archivoSalirToolStripMenuItem
			// 
			this.archivoSalirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.archivoSalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.archivoSalirToolStripMenuItem.Name = "archivoSalirToolStripMenuItem";
			this.archivoSalirToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.archivoSalirToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// aToolStripMenuItem
			// 
			this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.maximusToolStripMenuItem,
									this.alejandroToolStripMenuItem,
									this.alexisToolStripMenuItem});
			this.aToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.aToolStripMenuItem.Name = "aToolStripMenuItem";
			this.aToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
			this.aToolStripMenuItem.Text = "AcercaDe...";
			// 
			// maximusToolStripMenuItem
			// 
			this.maximusToolStripMenuItem.Name = "maximusToolStripMenuItem";
			this.maximusToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
			this.maximusToolStripMenuItem.Text = "Maximus :v";
			this.maximusToolStripMenuItem.Click += new System.EventHandler(this.MaximusToolStripMenuItemClick);
			// 
			// alejandroToolStripMenuItem
			// 
			this.alejandroToolStripMenuItem.Name = "alejandroToolStripMenuItem";
			this.alejandroToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
			this.alejandroToolStripMenuItem.Text = "Alejandro B)";
			this.alejandroToolStripMenuItem.Click += new System.EventHandler(this.AlejandroToolStripMenuItemClick);
			// 
			// alexisToolStripMenuItem
			// 
			this.alexisToolStripMenuItem.Name = "alexisToolStripMenuItem";
			this.alexisToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
			this.alexisToolStripMenuItem.Text = "Alexis :)";
			this.alexisToolStripMenuItem.Click += new System.EventHandler(this.AlexisToolStripMenuItemClick);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1039, 506);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem boletaDeCalificasionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alexisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alejandroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maximusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoSalirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem segundosHorasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kgLibrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kmMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem piramideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplicasionToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
