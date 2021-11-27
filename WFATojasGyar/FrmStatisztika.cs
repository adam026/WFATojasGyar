using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATojasGyar
{
    public partial class FrmStatisztika : Form
    {
        string connectionString;
        public FrmStatisztika(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void FrmStatisztika_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);

            connection.Open();
            var command = new SqlCommand("SELECT Nev FROM Nyul;",connection);
            var reader = command.ExecuteReader();
            while (reader.Read()) cbNev.Items.Add(reader[0]);
            reader.Close();
            cbNev.SelectedIndex = 0;
            connection.Close();
   
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            var connection = new SqlConnection(connectionString);
            dgvStat.Rows.Clear();

            connection.Open();

            var command = new SqlCommand("SELECT Datum, Tojas.Szin, Mennyiseg FROM Termeles " +
                "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                "INNER JOIN Nyul ON NyulId = Nyul.Id " +
                $"WHERE Nev LIKE '{cbNev.Text}' " +
                $"AND MONTH(Datum) = {nudHonap.Value} " +
                "ORDER BY Datum ASC;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvStat.Rows.Add(
                    reader.GetDateTime(0).ToString("yyyy-MM-dd"),
                    reader[1],
                    reader[2] + " db");
            }
            reader.Close();
            
            if (dgvStat.Rows.Count != 0)
            {
                reader = new SqlCommand(
                    "SELECT TOP 1 Szin, SUM(Mennyiseg) " +
                    "FROM Nyul " +
                    "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                    "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                    $"WHERE Nev LIKE '{cbNev.Text}' " +
                    $"AND MONTH(Datum) = {nudHonap.Value} " +
                    "GROUP BY Szin " +
                    "ORDER BY SUM(Mennyiseg) DESC;",
                    connection).ExecuteReader();
                reader.Read();
                tbMaxSzin.Text = $"{reader[0]}, ({reader[1]} db)";
                reader.Close();

                reader = new SqlCommand(
                    "SELECT SUM(Suly * Mennyiseg) " +
                    "FROM Nyul " +
                    "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                    "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                    $"WHERE Nev LIKE '{cbNev.Text}' " +
                    $"AND MONTH(Datum) = {nudHonap.Value};",
                    connection).ExecuteReader();
                reader.Read();
                tbMaxSuly.Text = $"{reader.GetInt32(0) / 1000F} Kg";
            }
            connection.Close();
        }

        private void cbNev_SelectedIndexChanged(object sender, EventArgs e) => UpdateDGV();

        private void nudHonap_ValueChanged(object sender, EventArgs e) => UpdateDGV();

    }
}
