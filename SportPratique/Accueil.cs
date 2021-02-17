using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace SportPratique
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Database=sport_pratique;Data Source=localhost;User Id=root;Password=";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT nom_sport FROM sport";
            cmd.Connection = conn;
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            int i = 1;
            while (dr.Read())
            {
                
                disponibles.Items.Add(new ListViewItem().SubItems.Add(dr[i].ToString()));

                i++;
            }

            dr.Close();
            conn.Close();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
