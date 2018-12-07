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
    public partial class AdministrarVentas : Form
    {
        conccionsql oper = new conccionsql();

        public AdministrarVentas()
        {
            InitializeComponent();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

            if (rbcliente.Checked == true)
            {

                dgvventas.DataSource = oper.cosnsultaconresultado("select Id_Cliente,Nombre,Apellidos from CLIENTE");
            }

            if (rbusuario.Checked == true)
            {
                dgvventas.DataSource = oper.cosnsultaconresultado("select Id_Usuario,Nombre from USUARIO");
            }

            if (rbprod.Checked == true)
            {
                dgvventas.DataSource = oper.cosnsultaconresultado("select Id_Producto,Descripcion,fecha_venc,Precio from PRODUCTO");
            }

            if(rbfact.Checked == true)
            {
                conccionsql o = new conccionsql();
                dgvventas.DataSource = o.cosnsultaconresultado("select * from cliente where id_Cliente like '%" + txtbuscar.Text + "%' ");
            }
        }

        private void dgvventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dgvventas.Rows[e.RowIndex];
            txtusu.Text = act.Cells["id_usuario"].Value.ToString();

            if (rbcliente.Checked == true)
            {


                txtidcli.Text = act.Cells["id_Cliente"].Value.ToString();
                txtnomc.Text = act.Cells["Nombre"].Value.ToString();
                txtapell.Text = act.Cells["Apellidos"].Value.ToString();
            }

            else if (rbprod.Checked == true)
            {
                txtidp.Text = act.Cells["id_Producto"].Value.ToString();
                txtdesc.Text = act.Cells["Descripcion"].Value.ToString();
                txtfech.Text = act.Cells["fecha_venc"].Value.ToString();
                txtprec.Text = act.Cells["Precio"].Value.ToString();


            }

            else if (rbusuario.Checked == true)
            {

                txtusu.Text = act.Cells["id_usuario"].Value.ToString();
            }

        }

        private void rbcliente_CheckedChanged(object sender, EventArgs e)
        {
            dgvventas.DataSource = oper.cosnsultaconresultado("select Id_Cliente,Nombre,Apellidos from CLIENTE");
        }

        private void rbprod_CheckedChanged(object sender, EventArgs e)
        {
            dgvventas.DataSource = oper.cosnsultaconresultado("select Id_Producto,Descripcion,fecha_venc,Precio from PRODUCTO");


        }

        private void rbusuario_CheckedChanged(object sender, EventArgs e)
        {
            dgvventas.DataSource = oper.cosnsultaconresultado("select Id_Usuario,Nombre from USUARIO");
        }

        private void txtprec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {

            double importe, preciou, itebis = 0.16, subtotal, total, cantidad, desc;
            string descuento = "0";



            if (comboBox1.Text == "5%")
            {
                descuento = "0,05";
            }

            else if (comboBox1.Text == "10%")
            {
                descuento = "0,10";
            }

            else if (comboBox1.Text == "15%")
            {
                descuento = "0,15";
            }

            else if (comboBox1.Text == "20%")
            {
                descuento = "0,20";
            }

            else if (comboBox1.Text == "25%")
            {
                descuento = "0,25";
            }

            else if (comboBox1.Text == "30%")
            {
                descuento = "0,30";
            }
            try
            {
                preciou = Convert.ToDouble(txtprec.Text);
                cantidad = Convert.ToDouble(txtcant.Text);
                importe = (preciou * itebis);
                txtite.Text = itebis.ToString();
                subtotal = (importe + preciou) * cantidad;
                txtsubt.Text = subtotal.ToString();
                txtimpor.Text = importe.ToString();
                desc = (importe * Convert.ToDouble(descuento));
                total = (importe - desc);
                txttotal.Text = total.ToString();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oper.consultasinreaultado("insert into ventasfactura(id_cliente,id_usuario,itebis,importe,subtotal,descuento,total,fecha)values('" + txtidcli.Text + "','" + txtusu.Text + "','" + txtite.Text + "','" + txtimpor.Text + "','" + txtsubt.Text + "','" + comboBox1.Text + "','" + txttotal.Text + "','" + dateTimePicker1.Text + "')");
            dgvventas.DataSource = oper.cosnsultaconresultado("select * from ventasfactura");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();



            DataTable dt = oper.cosnsultaconresultado("select id_factura, nombre,itebis,importe,subtotal,descuento,total,fecha from  cliente inner join ventasfactura on ventasfactura.id_cliente = CLIENTE.Id_Cliente where ventasfactura.id_factura = '" + txtusu.Text + "'");

            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\factura\Factura1.xml");
            visor f = new visor();
            f.Show();

        }

        private void AdministrarVentas_Load(object sender, EventArgs e)
        {
            dgvventas.DataSource = oper.cosnsultaconresultado("select * from ventasfactura");
        }
    }
}
