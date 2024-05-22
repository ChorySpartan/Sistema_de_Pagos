using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pagos
{
    public partial class frmControlPagos : Form
    {

        private bool nuevo = false;
        double sueldo = 0;
        public frmControlPagos()
        {
            InitializeComponent();
        }

        

        private void tabla_de_PagosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla_de_PagosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetControlPagos);

        }

        private bool ValidarCampos()
        {
            if (nuevo)
            {
                if (empleadoTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(empleadoTextBox, "Debe de ingresar el nombre del empleado");
                    empleadoTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }
            if (categoríaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(categoríaComboBox, "Debe de seleccionar una categoría");
                categoríaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void HabilitarCampos()
        {
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            categoríaComboBox.Enabled = true;
            empleadoTextBox.ReadOnly = false;
            empleadoTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;
            categoríaComboBox.Enabled = false;
            empleadoTextBox.ReadOnly = true;
        }

        private void frmControlPagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetControlPagos.Tabla_de_Pagos' Puede moverla o quitarla según sea necesario.
            this.tabla_de_PagosTableAdapter.Fill(this.dataSetControlPagos.Tabla_de_Pagos);

        }

        private void tabla_de_PagosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sueldoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sueldoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabla_de_PagosBindingSource.AddNew();
            HabilitarCampos();
            iD_PagosTextBox.ReadOnly = false;
            empleadoTextBox.Focus();
            fecha_de_RegistroDateTimePicker.Value = DateTime.Now;
            nuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            tabla_de_PagosBindingSource.CancelEdit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de eliminar el registro actual?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            tabla_de_PagosBindingSource.RemoveAt(tabla_de_PagosBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dataSetControlPagos);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.tabla_de_PagosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetControlPagos);
            DeshabilitarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void categoríaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Capturando la categoría seleccionada
            string categoria = categoríaComboBox.Text;

            // Asignando el sueldo según la categoría
            if (categoria == "Jefe") sueldo = 15000;
            if (categoria == "Administrador") sueldo = 10000;
            if (categoria == "Técnico") sueldo = 7000;
            if (categoria == "Operario") sueldo = 5000;
            if (categoria == "Intendente") sueldo = 3000;

            // Enviando el sueldo obtenido a la impresión
            sueldoTextBox.Text = sueldo.ToString("F2");

            // Realizando el cálculo
            double descuento = 0;
            if (sueldo > 3384.59) descuento = sueldo * (4.83 / 100);

            descuentoTextBox.Text = descuento.ToString("F2");

            double neto = sueldo - descuento;
            netoTextBox.Text = neto.ToString("F2");
        }

        private void tabla_de_PagosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
