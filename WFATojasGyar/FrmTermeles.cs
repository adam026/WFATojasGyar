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
    public partial class FrmTermeles : Form
    {
        string connectionString;
        public FrmTermeles(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e) => UpdateDGV();

        private void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            var connection = new SqlConnection(connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT Datum, Tojas.Szin, mennyiseg, Nyul.Nev " +
                "FROM Termeles " +
                "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                "INNER JOIN Nyul ON NyulId = Nyul.Id", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvMain.Rows.Add(
                    reader.GetDateTime(0).ToString("yyyy-MM-dd"),
                    reader[1],
                    reader[2] + " db",
                    reader[3]);
            }

            dgvMain.Sort(Date, ListSortDirection.Ascending);

            connection.Close();
            connection.Open();

            var command1 = new SqlCommand("SELECT Szin FROM Tojas", connection);
            var reader1 = command1.ExecuteReader();
            while (reader1.Read()) cbTojas.Items.Add(reader1[0]);
            cbTojas.SelectedIndex = 0;

            connection.Close();
            connection.Open();

            var command2 = new SqlCommand("SELECT Nev FROM Nyul", connection); 
            var reader2 = command2.ExecuteReader();
            while (reader2.Read()) cbMunkas.Items.Add(reader2[0]);
            cbMunkas.SelectedIndex = 0;

            connection.Close();

            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string datum = dtpDatum.Value.ToString("yyyy-MM-dd");
            int szin = cbTojas.SelectedIndex + 1;
            int mennyiseg = Convert.ToInt32(nudMennyiseg.Value);
            int nev = cbMunkas.SelectedIndex + 1;

            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand($"INSERT INTO Termeles VALUES ('{datum}','{szin}','{nev}','{mennyiseg}');", connection),
                };
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            UpdateDGV();
            
        }
    }
}
