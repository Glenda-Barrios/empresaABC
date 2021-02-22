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
    public partial class EditarCliente : Form
    {
        public static DataGridView datagrid;
        public static int id_cliente=0;
        public EditarCliente()
        {
            InitializeComponent();
            if (id_cliente == 0)
            {
                this.Close();
            }
            MySqlConnection con = Db.cn();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from cliente where idcliente=" + id_cliente;
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            String nombres = "";
            String apellidos = "";
            String genero = "";
            String edad = "";

            while (reader.Read())
            {
                nombres = reader.GetString(1);
                apellidos = reader.GetString(2);
                genero = reader.GetString(3);
                edad = reader.GetString(4);
            }
            con.Close();
            txtnombres.Text = nombres;
            txtapellidos.Text = apellidos;
            txtgenero.Text = genero;
           txtedad.Text = edad;
        }

       

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombres.Text != "" && txtapellidos.Text != "" && txtgenero.Text != "" && txtedad.Text != "")
            {
                MySqlConnection con = Db.cn();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update cliente set ";
                cmd.CommandText += "nombres=\"" + txtnombres.Text + "\",apellidos=\"" + txtapellidos.Text + "\",genero=\"" + txtgenero.Text + "\",edad=\"" + txtedad.Text + "\" where idcliente=" + id_cliente;
                con.Open();
                cmd.ExecuteNonQuery();             
                MessageBox.Show("Actualizado exitosamente!");
                con.Close();
                Form1.load_dgv_clientes(datagrid);
                this.Close();

            }
            else
            {
                MessageBox.Show("error");
            }
        }

       

        private void btneliminar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = Db.cn();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from cliente";
            cmd.CommandText += " where idcliente=" + id_cliente;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se Ha Eliminado exitosamente!");
            con.Close();
            Form1.load_dgv_clientes(datagrid);
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtgenero.Text = "";
            txtedad.Text = "";
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
