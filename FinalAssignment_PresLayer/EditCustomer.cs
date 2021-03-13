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
using Microsoft.Data.SqlClient;

namespace FinalAssignment_PresLayer
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Shown(object sender, EventArgs e)
        {
            fNameText.Text = PresentCust.custFName;
            lNameText.Text = PresentCust.custLName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            CustomerDataContext dc = new CustomerDataContext();
            if (string.IsNullOrEmpty(fNameText.Text))
            {
                MessageBox.Show("First Name cannot be empty");
            }
            else
            {
                var cID = new SqlParameter("@id", PresentCust.id);
                var cFName = new SqlParameter("@firstName", fNameText.Text);
                dc.Database.ExecuteSqlRaw("EXECUTE updateCusts @firstName, @id", cFName, cID);
                this.Close();
            }
        }
    }
}