using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("idcliente","Id_Cliente");
            dataGridView1.Columns.Add("nombres", "Nombres");
            dataGridView1.Columns.Add("apellidos", "Apellidos");
            dataGridView1.Columns.Add("genero", "Genero");
            dataGridView1.Columns.Add("edad", "Edad");
            dataGridView1.Columns["idcliente"].Visible = true;
            load_dgv_clientes(dataGridView1);
            NuevoCliente.datagrid = dataGridView1;
            EditarCliente.datagrid = dataGridView1;
        }

        public static void load_dgv_clientes(DataGridView dg)
        {
            dg.Rows.Clear();
            MySqlConnection con = Db.cn();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from cliente";
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idcliente = reader.GetInt32(0);
                String nombres = reader.GetString(1);
                String apellidos = reader.GetString(2);
                String genero = reader.GetString(3);
                String edad = reader.GetString(4);
                dg.Rows.Add(idcliente, nombres, apellidos, genero, edad);

            }
            con.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            load_dgv_clientes(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int c_id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            EditarCliente.id_cliente = c_id;
            EditarCliente ec = new EditarCliente();
            ec.Show();

        }

        private void btnuevocliente_Click(object sender, EventArgs e)
        {
            NuevoCliente nc = new NuevoCliente();
            nc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
