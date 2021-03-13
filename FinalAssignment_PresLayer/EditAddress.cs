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
    public partial class EditAddress : Form
    {
        public EditAddress()
        {
            InitializeComponent();
        }

        private void EditAddress_Shown(object sender, EventArgs e)
        {
            currentCust.Text = "Currently updating address for " + PresentCust.custFName + " " + PresentCust.custLName;
            streetText.Text = PresentCust.street;
            cityText.Text = PresentCust.city;
            stateText.Text = PresentCust.state;
            zipText.Text = PresentCust.zip;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(streetText.Text) || string.IsNullOrEmpty(cityText.Text) || string.IsNullOrEmpty(stateText.Text) || string.IsNullOrEmpty(zipText.Text))
            {
                MessageBox.Show("No fields may be empty!");
            }
            else if (stateText.Text.Length > 2)
            {
                MessageBox.Show("Use state abbreviations please");
            }
            else
            {
                CustomerDataContext dc = new CustomerDataContext();
                Address updateAddress = dc.Addresses.Single(up => up.CustomerId == PresentCust.id);
                updateAddress.Street = streetText.Text;
                updateAddress.City = cityText.Text;
                updateAddress.State = stateText.Text;
                updateAddress.Zip = zipText.Text;
                dc.SaveChanges();
                this.Close();
            }
        }
    }
}
