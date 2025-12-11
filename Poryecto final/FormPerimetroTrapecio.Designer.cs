/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 08/12/2025
 * Hora: 05:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Poryecto_final
{
	partial class FormPerimetroTrapecio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerimetroTrapecio));
			this.txtLado1 = new System.Windows.Forms.TextBox();
			this.txtLado2 = new System.Windows.Forms.TextBox();
			this.txtBaseMayor = new System.Windows.Forms.TextBox();
			this.txtBaseMenor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLado1
			// 
			this.txtLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLado1.Location = new System.Drawing.Point(142, 27);
			this.txtLado1.Name = "txtLado1";
			this.txtLado1.Size = new System.Drawing.Size(100, 27);
			this.txtLado1.TabIndex = 0;
			// 
			// txtLado2
			// 
			this.txtLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLado2.Location = new System.Drawing.Point(142, 60);
			this.txtLado2.Name = "txtLado2";
			this.txtLado2.Size = new System.Drawing.Size(100, 27);
			this.txtLado2.TabIndex = 1;
			// 
			// txtBaseMayor
			// 
			this.txtBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBaseMayor.Location = new System.Drawing.Point(142, 94);
			this.txtBaseMayor.Name = "txtBaseMayor";
			this.txtBaseMayor.Size = new System.Drawing.Size(100, 27);
			this.txtBaseMayor.TabIndex = 2;
			// 
			// txtBaseMenor
			// 
			this.txtBaseMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBaseMenor.Location = new System.Drawing.Point(142, 131);
			this.txtBaseMenor.Name = "txtBaseMenor";
			this.txtBaseMenor.Size = new System.Drawing.Size(100, 27);
			this.txtBaseMenor.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Lado1:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Lado2:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "BaseMayor:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "BaseMenor:";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(12, 176);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(219, 23);
			this.lblResultado.TabIndex = 8;
			this.lblResultado.Text = "Resultado:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Red;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(82, 225);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(101, 29);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(293, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(246, 228);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// FormPerimetroTrapecio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(562, 311);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBaseMenor);
			this.Controls.Add(this.txtBaseMayor);
			this.Controls.Add(this.txtLado2);
			this.Controls.Add(this.txtLado1);
			this.Name = "FormPerimetroTrapecio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "PerimTrapecio";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBaseMenor;
		private System.Windows.Forms.TextBox txtBaseMayor;
		private System.Windows.Forms.TextBox txtLado2;
		private System.Windows.Forms.TextBox txtLado1;
	}
}
