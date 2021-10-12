using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_4
{
    public partial class AddContact : Form
    {
        
        public AddContact()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        Image File;
        OpenFileDialog ofd = new OpenFileDialog();
        private void butBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "(*.jpg, *.png) | *.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(ofd.FileName);
                pbImage.Image = File;
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            
            if (rbFemale.Checked)
            {
                Contacts.gender = "female";
            }
            else if(rbMale.Checked)
            {
                Contacts.gender = "male";
            }
            try
            {
                
                int checkPhone = Convert.ToInt32(tbPhone.Text);
                Contacts.phoneNumber = checkPhone.ToString();
                Contacts.name = tbName.Text.Trim();
                Contacts.middleName = tbMidName.Text.Trim();
                Contacts.lastName = tbLastName.Text.Trim();
                Contacts.address = tbAddress.Text.Trim();

                if (String.IsNullOrEmpty(Contacts.name) || String.IsNullOrEmpty(Contacts.lastName) || String.IsNullOrEmpty(Contacts.address) || String.IsNullOrEmpty(Contacts.phoneNumber))
                {
                    throw new ArgumentNullException("Forms cannot be empty");
                }


                if (File != null)
                {
                    Contacts.imagePath = "img\\" + ofd.SafeFileName;
                    pbImage.Image.Save(Contacts.imagePath);
                }

                Contacts.conText = $"+++++++++++++++++++\nName: {Contacts.name}\nMiddle Name: {Contacts.middleName}\nLastName: {Contacts.lastName}\nPhone Number: {Contacts.phoneNumber}\nAddress: {Contacts.address}\nGender: {Contacts.gender}\nImage: {Contacts.imagePath}";


                FileStream fs = new FileStream("contacts.txt", FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Contacts.conText);

                sw.Close();
                fs.Close();

                MessageBox.Show("Contact added");

                //setting to default...
                Contacts.setDefault();
                tbName.Text = tbMidName.Text = tbLastName.Text = tbAddress.Text = tbPhone.Text = "";
                pbImage.Image = Properties.Resources.image_not_available2;

            }
            catch (Exception ane)
            {

                MessageBox.Show(ane.Message);
            }

            
        }
        

        private void butBackToM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
