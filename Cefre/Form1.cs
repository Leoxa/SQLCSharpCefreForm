using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cefre
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("server=localhost,Port=3306, Database=cefredb, UId=root, Pwd=;");
            conn.Open();

            Adatoklistazas();
        }

        void Adatoklistazas()
        {
            listFozde.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT nev FROM fozde ORDER BY nev";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nev = reader.GetString("nev");

                    listFozde.Items.Clear();
                }
            }
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNev.Text) || String.IsNullOrWhiteSpace(tbTulajdonos.Text))
            {
                MessageBox.Show("minden mezőt ki kell tölteni");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO fozde(nev, tulajdonos, alapitva)
                                VALUES (@nev,tulajdonos,@alapitas);";
            cmd.Parameters.AddWithValue("@nev", tbNev.Text);
            cmd.Parameters.AddWithValue("@tulajdonos", tbTulajdonos.Text);
            cmd.Parameters.AddWithValue("@alapitas", alapitas.Text);

            cmd.ExecuteNonQuery();


        }
    }
}
