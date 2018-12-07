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
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLog_Load(object sender, EventArgs e)
        {

        }

        private void BtnAccesarLog_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("server = HECTOJO; database = DB_FaramaSolutionJD; integrated security = true;");
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM USUARIO_LOGIN WHERE Usuario ='" + TbUser.Text + "' AND clave='" + TbPass.Text + "'", cnx);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    FormMenuPrinc fmr = new FormMenuPrinc();
                    this.Hide();
                    fmr.ShowDialog();
                    this.Show();
                    TbUser.Clear();
                    TbPass.Clear();




                }
                else
                    MessageBox.Show("Contraseña y Usuario incorrectos");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally

            {


            }
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            TbUser.Text = "";
            TbPass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
