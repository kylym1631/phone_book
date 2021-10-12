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
    public partial class ShowContacts : Form
    {
        //declated here because I want access from other events
        int counter =0;
        int turn = 1;
        StreamReader sr;
        FileStream fs;
   
       
        public ShowContacts()
        {
            InitializeComponent();
            this.CenterToScreen();
            labAddress.Text = labName.Text = labLastName.Text = labGender.Text = labMidName.Text = labPhone.Text = "";
            if (!File.Exists("contacts.txt") || new FileInfo("contacts.txt").Length ==0)
            {
                butPrev.Enabled = butNext.Enabled = groupBox1.Enabled = false;
            }
            else
            {
                changeLab();
                //for counting how many contact do I have
                while (!sr.EndOfStream)
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        sr.ReadLine();
                    }
                    counter++;
                }
                //if there is only 1 contact
                if (counter == 0)
                {
                    counter++;
                    butNext.Enabled = false;
                }
                checkPrev();
                checkQuant();
                sr.Close();
                fs.Close();
            }
           
        }

        public void changeLab()
        {
            try
            {
                fs = new FileStream("contacts.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                //which contact's turn... reads that many times
                for (int i = 0; i < turn; i++)
                {
                    string divider = sr.ReadLine();
                    labName.Text = Contacts.name = inputHandler(sr.ReadLine()); ;
                    labMidName.Text = Contacts.middleName = inputHandler(sr.ReadLine());
                    labLastName.Text = Contacts.lastName = inputHandler(sr.ReadLine());
                    labPhone.Text = Contacts.phoneNumber = inputHandler(sr.ReadLine());
                    labAddress.Text = Contacts.address = inputHandler(sr.ReadLine());
                    labGender.Text = Contacts.gender = inputHandler(sr.ReadLine());
                    pbImage.Image = Image.FromFile(Contacts.imagePath = inputHandler(sr.ReadLine()));
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void butBack2M_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            butPrev.Enabled = true;
            turn++;
            if (turn < counter+1)
            {
                changeLab();
                if (turn == counter)
                {
                    butNext.Enabled = false;
                }
            }
            checkQuant();
            sr.Close();
            fs.Close();

        }

        private void butPrev_Click(object sender, EventArgs e)
        {
            butNext.Enabled = true;
            checkPrev();
            if(turn > 1)
            {
                turn--;
                checkPrev();
                for (int i = 0; i < counter - 1; i++)
                {
                    changeLab();
                    sr.Close();
                    fs.Close();
                }
            }
            checkQuant();
            sr.Close();
            fs.Close();

        }

        private string inputHandler(string s)
        {
            int doubleIndex = s.LastIndexOf(":");
            string finR = s.Substring(doubleIndex + 1).Trim();
            return finR;
        }
        public void checkPrev()
        {
            if(turn == 1)
            {
                butPrev.Enabled = false;
            }
        }
        public void checkQuant()
        {
            labQuant.Text = $"{turn} out of {counter}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
