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
    public partial class NuevoCliente : Form
    {
        public static DataGridView datagrid;
        public NuevoCliente()
        {
            InitializeComponent();
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtgenero.Text = "";
            txtedad.Text = "";
        }


        private void NuevoCliente_Load(object sender, EventArgs e)
        {

        }


        private void btguardar_Click_1(object sender, EventArgs e)
        {
            if (txtnombres.Text != "" && txtapellidos.Text != "")
            {
                MySqlConnection con = Db.cn();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO cliente (nombres, apellidos, genero, edad)"
                             + "VALUES ('" + txtnombres.Text + "', '" + txtapellidos.Text + "', '" + txtgenero.Text + "', '" + txtedad.Text + "')";
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    // Cierro la Conexión.
                    con.Close();
                    this.Close();
                }

            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
