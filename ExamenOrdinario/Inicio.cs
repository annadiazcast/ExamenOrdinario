using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenOrdinario
{
    public partial class Inicio : Form
    {
        Acciones acciones = new Acciones();

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = acciones.Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acciones.Eliminar(Convert.ToInt32(txtId.Text)))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminar");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acciones.Agregar(Convert.ToInt32(txtNewId.Text), txtMarca.Text, txtModelo.Text, Convert.ToInt32(txtAnio.Text), txtColor.Text, Convert.ToDouble(txtPrecio.Text), txtEstado.Text))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Error al agregar");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (acciones.Actualizar(Convert.ToInt32(txtNewId.Text), txtMarca.Text, txtModelo.Text, Convert.ToInt32(txtAnio.Text), txtColor.Text, Convert.ToDouble(txtPrecio.Text), txtEstado.Text))
                MessageBox.Show("Actualizado con exito");
            else
                MessageBox.Show("Error al actualizar");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (acciones.ExportaraExcel())
                MessageBox.Show("Exportado con exito");
            else
                MessageBox.Show("Fallo al exportar");
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (acciones.ImportarDeExcel())
                MessageBox.Show("Importado con exito");
            else
                MessageBox.Show("Fallo al importar");
        }

        private void btnContar_Click(object sender, EventArgs e)
        { 
            lblDisponibles.Text = $"Autos: {acciones.ContarAutos()}";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            lblSumaPrecios.Text = $"La suma de los precios es: {acciones.Suma()}";
        }
    }
}
