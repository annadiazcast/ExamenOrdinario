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
    public partial class Form1 : Form
    {
        Usuarios usuarios= new Usuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user=txtUsuario.Text;
            string password=txtContraseña.Text;

            var lista = usuarios.ObtenerUsuarios();
            var validar = lista.FirstOrDefault(u => u.NomUsuario == user && u.Contrasenia == password);
            if (validar != null)
            {
                this.Hide();
                Inicio inicio= new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario Invalido");
            }
        }
    }
}
