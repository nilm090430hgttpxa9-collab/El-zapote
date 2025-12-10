/*
 * Creado por SharpDevelop.
 * Usuario: manue
 * Fecha: 10/12/2025
 * Hora: 04:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace evaluacion3
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
 			dgvEmpleados.Columns.Add("cod", "CODIGO");
    		dgvEmpleados.Columns.Add("nom", "NOMBRE");
    		dgvEmpleados.Columns.Add("pue", "PUESTO");
    		dgvEmpleados.Columns.Add("fec", "FECHA DE NAC");
    		dgvEmpleados.Columns.Add("sex", "SEXO");
    		dgvEmpleados.Columns.Add("est", "ESTADO");			
		}
		
		
		void BtnreagistrarClick(object sender, EventArgs e)
		{
{
    bool valido = true;
    errperror.Clear();

    if (txtCodigo.Text.Trim() == "")
    {
        errperror.SetError(txtCodigo, "Ingrese el código del empleado");
        valido = false;
    }

    if (txtEmpleados.Text.Trim() == "")
    {
        errperror.SetError(txtEmpleados, "Ingrese el nombre del empleado");
        valido = false;
    }

    if (sboasignatura.SelectedIndex == -1)
    {
        errperror.SetError(sboasignatura, "Seleccione un puesto");
        valido = false;
    }

    if (sbosexo.SelectedIndex == -1)
    {
        errperror.SetError(sbosexo, "Seleccione sexo");
        valido = false;
    }

    if (!rbRegular.Checked && !rbContrato.Checked)
    {
        errperror.SetError(rbContrato, "Seleccione estado del empleado");
        valido = false;
    }

    if (!valido)
        return;

    string estado = rbRegular.Checked ? "REGULAR" : "CONTRATO";

   
        dgvEmpleados.Rows.Add(
        txtCodigo.Text,
        txtEmpleados.Text,
        sboasignatura.Text,
        dtpfecha.Value.ToShortDateString(),
        sbosexo.Text,
        estado
    );

    MessageBox.Show("Empleado registrado correctamente ");
			
		}
	}
		
		void BtncarrarClick(object sender, EventArgs e)
		{
			Close();	
		}
		
		void BtnlimpiarClick(object sender, EventArgs e)
		{
        	 txtCodigo.Clear();
           	 txtEmpleados.Clear();
           	 sbosexo.SelectedIndex = -1;
           	 sboasignatura.SelectedIndex = -1;
             dtpfecha.Value = DateTime.Now;
           	 rbRegular.Checked = false;
             pbfoto.Image = null;
   			
		}
		
		void BtnactualizarClick(object sender, EventArgs e)
		{
			 OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pbfoto.Image = System.Drawing.Image.FromFile(abrir.FileName);
                pbfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }			
		}
		
		void BtnquitarClick(object sender, EventArgs e)
		{
        pbfoto.Image = null;			
		}
}
}
    