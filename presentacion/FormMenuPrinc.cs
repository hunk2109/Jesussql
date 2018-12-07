using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormMenuPrinc : Form
    {
        public FormMenuPrinc()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void irAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmClientes frm = new FormAdmClientes();
            frm.Show();
        }

        private void irAMendicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrarMedic f = new FormAdministrarMedic();
            f.Show();
        }

        private void irAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Usuarios f = new Administrar_Usuarios();
            f.Show();
        }

        private void irAVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarVentas f = new AdministrarVentas();
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
