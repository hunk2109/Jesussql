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
    public partial class FormAdmClientes : Form
    {
        public FormAdmClientes()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conccionsql oper = new conccionsql();
            dgvcliente.DataSource = oper.cosnsultaconresultado("select * from Cliente");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conccionsql oper = new conccionsql();
            oper.consultasinreaultado("insert into CLIENTE(Id_Cliente,Nombre,Apellidos,Direccion,Telefono,Sexo,Cedula,Email)values('"+txtid.Text+"','"+txtnomb.Text+"','"+txtape.Text+"','"+txtdirec.Text+"','"+txttel.Text+"','"+cmbsex.Text+"','"+txtced.Text+"','"+txtemail.Text+"')");
            dgvcliente.DataSource = oper.cosnsultaconresultado("select * from Cliente");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            conccionsql o = new conccionsql();
           dgvcliente.DataSource = o.cosnsultaconresultado("select * from cliente where id_Cliente like '%" + txtbuscar.Text + "%' ");

            

        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {DataGridViewRow
             act = dgvcliente.Rows[e.RowIndex];
            txtid.Text = act.Cells["id_Cliente"].Value.ToString();
            txtnomb.Text = act.Cells["Nombre"].Value.ToString();
            txtape.Text = act.Cells["Apellidos"].Value.ToString();
            txtdirec.Text = act.Cells["Direccion"].Value.ToString();
            txtced.Text = act.Cells["Cedula"].Value.ToString();
            cmbsex.Text = act.Cells["Sexo"].Value.ToString();
            txttel.Text = act.Cells["Telefono"].Value.ToString();
            txtemail.Text = act.Cells["Email"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtnomb.Text = "";
            txtape.Text = "";
            txtdirec.Text = "";
            txtced.Text = "";
            cmbsex.Text = "";
            txttel.Text = "";
            txtemail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result
               = MessageBox.Show("Seguro que desea borrar?", "Borrar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                conccionsql oper = new conccionsql();
                oper.consultasinreaultado("delete from Cliente where id_Cliente = '" + txtid.Text + "'");
                dgvcliente.DataSource = oper.cosnsultaconresultado("select * from cliente");
                MessageBox.Show("Datos borrados");
            }
        }
    }
}
