using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Users : Form
    {
        int aux;
        string[] userarr = new string[5];
        string[] passarr = new string[5];
        public Users(string[] userarr, string[] passarr, int aux)
        {
            InitializeComponent();

            this.userarr = userarr;
            this.passarr = passarr;
            this.aux = aux;
        }
        private void Users_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < aux; i++)
            {
                dgvAdmin.Rows.Add();
                dgvAdmin.Rows[i].Cells[0].Value = i;
                dgvAdmin.Rows[i].Cells[1].Value = userarr[i];
                dgvAdmin.Rows[i].Cells[2].Value = passarr[i];
            }
        }
        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackUsersButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
