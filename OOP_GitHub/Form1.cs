using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Class sinif = new Class();//In this field we produce a product which name is "sinif" by using "Class".
            sinif.FirstName = (txtFirstName.Text); // We manage object on this row however wants because now we are reshaping object.
            sinif.LastName = (txtLastName.Text);
            sinif.ID = Convert.ToInt32(txtid.Text);
            sinif.Field = (txtField.Text);

            listBox1.Items.Add(sinif.FirstName);//And finally we ve produced an object now we get this on the listbox.
            listBox1.Items.Add(sinif.LastName);
            listBox1.Items.Add(sinif.ID);
            listBox1.Items.Add(sinif.Field);

        }
    }
}
