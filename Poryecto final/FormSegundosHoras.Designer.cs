/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Poryecto_final
{
	partial class FormSegundosHoras
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
			this.btnConvertir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtSegundos = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnConvertir
			// 
			this.btnConvertir.BackColor = System.Drawing.Color.Red;
			this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertir.ForeColor = System.Drawing.Color.White;
			this.btnConvertir.Location = new System.Drawing.Point(90, 119);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(103, 27);
			this.btnConvertir.TabIndex = 0;
			this.btnConvertir.Text = "Convertir";
			this.btnConvertir.UseVisualStyleBackColor = false;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Segundos:";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(29, 59);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(241, 23);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Horas:";
			// 
			// txtSegundos
			// 
			this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSegundos.Location = new System.Drawing.Point(135, 22);
			this.txtSegundos.Name = "txtSegundos";
			this.txtSegundos.Size = new System.Drawing.Size(100, 27);
			this.txtSegundos.TabIndex = 3;
			// 
			// FormSegundosHoras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(282, 172);
			this.Controls.Add(this.txtSegundos);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConvertir);
			this.Name = "FormSegundosHoras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "SegundosHoras";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtSegundos;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConvertir;
	}
}
