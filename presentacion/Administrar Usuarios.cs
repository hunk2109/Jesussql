using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRESENTACION
{
    public partial class Administrar_Usuarios : Form
    {
        public Administrar_Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conccionsql oper = new conccionsql();
                oper.consultasinreaultado("insert into USUARIO(Id_Usuario,Nombre,Apellidos,Direccion,Telefono,Activo,Email)values('" + txtid.Text + "','" + txtnomb.Text + "','" + txtape.Text + "','" + txtdirec.Text + "','" + txttel.Text + "','" + cmbestusu.Text + "','" + txtem.Text + "')");
                dgvusu.DataSource = oper.cosnsultaconresultado("select * from usuario");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Administrar_Usuarios_Load(object sender, EventArgs e)
        {
            conccionsql oper = new conccionsql();
            dgvusu.DataSource = oper.cosnsultaconresultado("select * from usuario");
        }

        private void txtbucsar_TextChanged(object sender, EventArgs e)
        {
            conccionsql o = new conccionsql();
            dgvusu.DataSource = o.cosnsultaconresultado("Select * from usuario where Id_Usuario like '%" + txtbucsar.Text + "%' ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtnomb.Text = "";
            txtdirec.Text = "";
            txtape.Text = "";
            txttel.Text = "";
            cmbestusu.Text = "";
            txtem.Text = "";
        }

        private void dgvusu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dgvusu.Rows[e.RowIndex];
            txtid.Text = act.Cells["id_usuario"].Value.ToString();
            txtnomb.Text = act.Cells["Nombre"].Value.ToString();
            txtape.Text = act.Cells["Apellidos"].Value.ToString();
            cmbestusu.Text = act.Cells["Activo"].Value.ToString();
            txttel.Text = act.Cells["Telefono"].Value.ToString();
            txtem.Text = act.Cells["Email"].Value.ToString();
            txtdirec.Text = act.Cells["Direccion"].Value.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result
                   = MessageBox.Show("Seguro que desea borrar?", "Borrar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conccionsql oper = new conccionsql();
                    oper.consultasinreaultado("delete  from Usuario where id_Usuario = '" + txtid.Text + "'");
                    dgvusu.DataSource = oper.cosnsultaconresultado("select * from Usuario");
                    MessageBox.Show("Datos borrados");
                }

                
            }

            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
