/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 03:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Poryecto_final
{
	partial class FormFactorial
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.la = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Black;
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(111, 182);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 28);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// la
			// 
			this.la.Location = new System.Drawing.Point(44, 56);
			this.la.Name = "la";
			this.la.Size = new System.Drawing.Size(100, 23);
			this.la.TabIndex = 1;
			this.la.Text = "Numero:";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(150, 56);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 22);
			this.txtNumero.TabIndex = 2;
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(44, 103);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(206, 23);
			this.lblResultado.TabIndex = 4;
			this.lblResultado.Text = "Resultado:";
			// 
			// FormFactorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(296, 242);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.la);
			this.Controls.Add(this.btnCalcular);
			this.Name = "FormFactorial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FormFactorial";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label la;
		private System.Windows.Forms.Button btnCalcular;
	}
}
