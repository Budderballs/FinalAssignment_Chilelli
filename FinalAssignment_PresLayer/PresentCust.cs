using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment_DataLayer;
using Microsoft.EntityFrameworkCore;

namespace FinalAssignment_PresLayer
{
    public partial class PresentCust : Form
    {
        EditAddress ea = new EditAddress();
        EditCustomer ec = new EditCustomer();
        public static string custFName;
        public static string custLName;
        public static string street;
        public static string city;
        public static string state;
        public static string zip;
        public static int id;
        public PresentCust()
        {
            InitializeComponent();


        }

        private void PresentCust_Load(object sender, EventArgs e)
        {
            showStuff();
        }

        private void summaryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editCusts.Enabled = true;
            editAdds.Enabled = true;
        }
        private void editAdds_Click(object sender, EventArgs e)
        {
            getAddressContext();
            ea.ShowDialog();
            showStuff();
        }

        private void editCusts_Click(object sender, EventArgs e)
        {
            getCustContext();
            ec.ShowDialog();
            showStuff();
        }
        private void showStuff()
        {
            CustomerDataContext dc = new CustomerDataContext();
            summaryGrid.DataSource = dc.Customers.Join(dc.Addresses, z => z.CustomerId, y => y.Customer.CustomerId, (y, z) => new { y.CustomerId, y.Firstname, y.Lastname, z.Street, z.City, z.State, z.Zip }).ToList().AsReadOnly();
            summaryGrid.Columns["CustomerId"].Visible = false;
        }
        private void getCustContext()
        {
            custFName = summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[1].Value.ToString();
            custLName = summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[2].Value.ToString();
            id = Convert.ToInt32(summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[0].Value);
        }
        private void getAddressContext()
        {
            getCustContext();
            street = summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[3].Value.ToString();
            city = summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[4].Value.ToString();
            state = summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[5].Value.ToString();
            zip = summaryGrid.Rows[summaryGrid.CurrentRow.Index].Cells[6].Value.ToString();
        }
    }
}