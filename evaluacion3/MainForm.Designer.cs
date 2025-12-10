/*
 * Creado por SharpDevelop.
 * Usuario: manue
 * Fecha: 10/12/2025
 * Hora: 04:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace evaluacion3
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.dtpfecha = new System.Windows.Forms.DateTimePicker();
			this.pbfoto = new System.Windows.Forms.PictureBox();
			this.btnquitar = new System.Windows.Forms.Button();
			this.btnactualizar = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbContrato = new System.Windows.Forms.RadioButton();
			this.rbRegular = new System.Windows.Forms.RadioButton();
			this.lblsexo = new System.Windows.Forms.Label();
			this.sbosexo = new System.Windows.Forms.ComboBox();
			this.sboasignatura = new System.Windows.Forms.ComboBox();
			this.lblpuesto = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtEmpleados = new System.Windows.Forms.TextBox();
			this.lblparcial3 = new System.Windows.Forms.Label();
			this.lblparcial2 = new System.Windows.Forms.Label();
			this.lblparcial1 = new System.Windows.Forms.Label();
			this.btncarrar = new System.Windows.Forms.Button();
			this.btnreagistrar = new System.Windows.Forms.Button();
			this.errperror = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errperror)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleados.Location = new System.Drawing.Point(203, 331);
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.RowTemplate.Height = 28;
			this.dgvEmpleados.Size = new System.Drawing.Size(720, 150);
			this.dgvEmpleados.TabIndex = 82;
			// 
			// dtpfecha
			// 
			this.dtpfecha.Location = new System.Drawing.Point(225, 153);
			this.dtpfecha.Name = "dtpfecha";
			this.dtpfecha.Size = new System.Drawing.Size(308, 26);
			this.dtpfecha.TabIndex = 81;
			// 
			// pbfoto
			// 
			this.pbfoto.Image = ((System.Drawing.Image)(resources.GetObject("pbfoto.Image")));
			this.pbfoto.Location = new System.Drawing.Point(829, 12);
			this.pbfoto.Name = "pbfoto";
			this.pbfoto.Size = new System.Drawing.Size(227, 200);
			this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbfoto.TabIndex = 80;
			this.pbfoto.TabStop = false;
			// 
			// btnquitar
			// 
			this.btnquitar.Location = new System.Drawing.Point(939, 243);
			this.btnquitar.Name = "btnquitar";
			this.btnquitar.Size = new System.Drawing.Size(130, 32);
			this.btnquitar.TabIndex = 79;
			this.btnquitar.Text = "QUITAR";
			this.btnquitar.UseVisualStyleBackColor = true;
			this.btnquitar.Click += new System.EventHandler(this.BtnquitarClick);
			// 
			// btnactualizar
			// 
			this.btnactualizar.Location = new System.Drawing.Point(806, 240);
			this.btnactualizar.Name = "btnactualizar";
			this.btnactualizar.Size = new System.Drawing.Size(127, 32);
			this.btnactualizar.TabIndex = 78;
			this.btnactualizar.Text = "ACTUALIZAR";
			this.btnactualizar.UseVisualStyleBackColor = true;
			this.btnactualizar.Click += new System.EventHandler(this.BtnactualizarClick);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Location = new System.Drawing.Point(583, 237);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(90, 32);
			this.btnlimpiar.TabIndex = 77;
			this.btnlimpiar.Text = "LIMPIAR";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbContrato);
			this.groupBox1.Controls.Add(this.rbRegular);
			this.groupBox1.Location = new System.Drawing.Point(56, 225);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 100);
			this.groupBox1.TabIndex = 76;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ESTADO";
			// 
			// rbContrato
			// 
			this.rbContrato.Location = new System.Drawing.Point(91, 52);
			this.rbContrato.Name = "rbContrato";
			this.rbContrato.Size = new System.Drawing.Size(122, 24);
			this.rbContrato.TabIndex = 1;
			this.rbContrato.TabStop = true;
			this.rbContrato.Text = "CONTRATO";
			this.rbContrato.UseVisualStyleBackColor = true;
			// 
			// rbRegular
			// 
			this.rbRegular.Location = new System.Drawing.Point(91, 22);
			this.rbRegular.Name = "rbRegular";
			this.rbRegular.Size = new System.Drawing.Size(116, 24);
			this.rbRegular.TabIndex = 0;
			this.rbRegular.TabStop = true;
			this.rbRegular.Text = "REGULAR";
			this.rbRegular.UseVisualStyleBackColor = true;
			// 
			// lblsexo
			// 
			this.lblsexo.Location = new System.Drawing.Point(27, 189);
			this.lblsexo.Name = "lblsexo";
			this.lblsexo.Size = new System.Drawing.Size(89, 23);
			this.lblsexo.TabIndex = 75;
			this.lblsexo.Text = "SEXO";
			// 
			// sbosexo
			// 
			this.sbosexo.FormattingEnabled = true;
			this.sbosexo.Items.AddRange(new object[] {
									"MASCULUNO ",
									"FEMENINO",
									"OTROS"});
			this.sbosexo.Location = new System.Drawing.Point(122, 186);
			this.sbosexo.Name = "sbosexo";
			this.sbosexo.Size = new System.Drawing.Size(188, 28);
			this.sbosexo.TabIndex = 74;
			// 
			// sboasignatura
			// 
			this.sboasignatura.FormattingEnabled = true;
			this.sboasignatura.Items.AddRange(new object[] {
									"ENCARGADO",
									"AYUDANTE",
									"RESEPCIONISTA",
									"GUARDIA"});
			this.sboasignatura.Location = new System.Drawing.Point(147, 115);
			this.sboasignatura.Name = "sboasignatura";
			this.sboasignatura.Size = new System.Drawing.Size(246, 28);
			this.sboasignatura.TabIndex = 73;
			// 
			// lblpuesto
			// 
			this.lblpuesto.Location = new System.Drawing.Point(12, 115);
			this.lblpuesto.Name = "lblpuesto";
			this.lblpuesto.Size = new System.Drawing.Size(77, 23);
			this.lblpuesto.TabIndex = 72;
			this.lblpuesto.Text = "PUESTO";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(239, 31);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(230, 26);
			this.txtCodigo.TabIndex = 71;
			// 
			// txtEmpleados
			// 
			this.txtEmpleados.Location = new System.Drawing.Point(239, 72);
			this.txtEmpleados.Name = "txtEmpleados";
			this.txtEmpleados.Size = new System.Drawing.Size(230, 26);
			this.txtEmpleados.TabIndex = 70;
			// 
			// lblparcial3
			// 
			this.lblparcial3.Location = new System.Drawing.Point(22, 158);
			this.lblparcial3.Name = "lblparcial3";
			this.lblparcial3.Size = new System.Drawing.Size(211, 23);
			this.lblparcial3.TabIndex = 69;
			this.lblparcial3.Text = "FECHA DE NACIMIENTO";
			// 
			// lblparcial2
			// 
			this.lblparcial2.Location = new System.Drawing.Point(17, 34);
			this.lblparcial2.Name = "lblparcial2";
			this.lblparcial2.Size = new System.Drawing.Size(204, 23);
			this.lblparcial2.TabIndex = 68;
			this.lblparcial2.Text = "CODIGO DE EMPLEADO";
			// 
			// lblparcial1
			// 
			this.lblparcial1.Location = new System.Drawing.Point(10, 72);
			this.lblparcial1.Name = "lblparcial1";
			this.lblparcial1.Size = new System.Drawing.Size(223, 23);
			this.lblparcial1.TabIndex = 67;
			this.lblparcial1.Text = "NOMBRE DEL EMPLEADO";
			// 
			// btncarrar
			// 
			this.btncarrar.Location = new System.Drawing.Point(487, 236);
			this.btncarrar.Name = "btncarrar";
			this.btncarrar.Size = new System.Drawing.Size(90, 36);
			this.btncarrar.TabIndex = 66;
			this.btncarrar.Text = "CERRAR";
			this.btncarrar.UseVisualStyleBackColor = true;
			this.btncarrar.Click += new System.EventHandler(this.BtncarrarClick);
			// 
			// btnreagistrar
			// 
			this.btnreagistrar.Location = new System.Drawing.Point(364, 236);
			this.btnreagistrar.Name = "btnreagistrar";
			this.btnreagistrar.Size = new System.Drawing.Size(117, 33);
			this.btnreagistrar.TabIndex = 65;
			this.btnreagistrar.Text = "REAGISTAR";
			this.btnreagistrar.UseVisualStyleBackColor = true;
			this.btnreagistrar.Click += new System.EventHandler(this.BtnreagistrarClick);
			// 
			// errperror
			// 
			this.errperror.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1201, 606);
			this.Controls.Add(this.dgvEmpleados);
			this.Controls.Add(this.dtpfecha);
			this.Controls.Add(this.pbfoto);
			this.Controls.Add(this.btnquitar);
			this.Controls.Add(this.btnactualizar);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblsexo);
			this.Controls.Add(this.sbosexo);
			this.Controls.Add(this.sboasignatura);
			this.Controls.Add(this.lblpuesto);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.txtEmpleados);
			this.Controls.Add(this.lblparcial3);
			this.Controls.Add(this.lblparcial2);
			this.Controls.Add(this.lblparcial1);
			this.Controls.Add(this.btncarrar);
			this.Controls.Add(this.btnreagistrar);
			this.Name = "MainForm";
			this.Text = "evaluacion3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errperror)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errperror;
		private System.Windows.Forms.Button btnreagistrar;
		private System.Windows.Forms.Button btncarrar;
		private System.Windows.Forms.Label lblparcial1;
		private System.Windows.Forms.Label lblparcial2;
		private System.Windows.Forms.Label lblparcial3;
		private System.Windows.Forms.TextBox txtEmpleados;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblpuesto;
		private System.Windows.Forms.ComboBox sboasignatura;
		private System.Windows.Forms.ComboBox sbosexo;
		private System.Windows.Forms.Label lblsexo;
		private System.Windows.Forms.RadioButton rbRegular;
		private System.Windows.Forms.RadioButton rbContrato;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.Button btnactualizar;
		private System.Windows.Forms.Button btnquitar;
		private System.Windows.Forms.PictureBox pbfoto;
		private System.Windows.Forms.DateTimePicker dtpfecha;
		private System.Windows.Forms.DataGridView dgvEmpleados;
	}
}
