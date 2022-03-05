using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLab
{
    public partial class PrimerPagina : Form
    {
        public PrimerPagina()
        {
            InitializeComponent();
        }

        private void PrimerPagina_Load(object sender, EventArgs e)
        {

        }

        private void botonRolEmpleado_Click(object sender, EventArgs e)
        {
            Form1 Empleado = new Form1();
            this.Hide();
            Empleado.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCliente Cliente = new FormCliente();
            this.Hide();
            Cliente.ShowDialog();
            this.Close();
        }
    }
}
