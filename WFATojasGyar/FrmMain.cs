using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATojasGyar
{
    public partial class FrmMain : Form
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TojasGyar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTermeles_Click(object sender, EventArgs e)
        {
            var frm = new FrmTermeles(connectionString);
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pbKep.Image = Properties.Resources.nyul;
        }

        private void btnStatisztika_Click(object sender, EventArgs e)
        {
            var frm = new FrmStatisztika(connectionString);
            frm.ShowDialog();
        }
    }
}
