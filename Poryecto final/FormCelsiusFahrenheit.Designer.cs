/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Poryecto_final
{
	partial class FormCelsiusFahrenheit
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtCelsius = new System.Windows.Forms.TextBox();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Celsius:";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(27, 68);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(206, 23);
			this.lblResultado.TabIndex = 1;
			this.lblResultado.Text = "Fahrenheit:\r\n";
			// 
			// txtCelsius
			// 
			this.txtCelsius.Location = new System.Drawing.Point(133, 23);
			this.txtCelsius.Name = "txtCelsius";
			this.txtCelsius.Size = new System.Drawing.Size(100, 22);
			this.txtCelsius.TabIndex = 2;
			// 
			// btnConvertir
			// 
			this.btnConvertir.BackColor = System.Drawing.Color.Black;
			this.btnConvertir.ForeColor = System.Drawing.Color.White;
			this.btnConvertir.Location = new System.Drawing.Point(92, 110);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(75, 30);
			this.btnConvertir.TabIndex = 3;
			this.btnConvertir.Text = "Converti";
			this.btnConvertir.UseVisualStyleBackColor = false;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// FormCelsiusFahrenheit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(282, 152);
			this.Controls.Add(this.btnConvertir);
			this.Controls.Add(this.txtCelsius);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label1);
			this.Name = "FormCelsiusFahrenheit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "CelsiusFahrenheit";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.TextBox txtCelsius;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label1;
	}
}
