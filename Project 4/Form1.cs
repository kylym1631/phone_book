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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAddCon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddContact aC = new AddContact();
            aC.ShowDialog();
            this.Close();
        }

        private void butShowCon_Click(object sender, EventArgs e)
        {
            if (!File.Exists("contacts.txt") || new FileInfo("contacts.txt").Length == 0)
            {
                MessageBox.Show("There is no data to show!");
            }
            this.Hide();
            ShowContacts sC = new ShowContacts();
            sC.ShowDialog();
            this.Close();

        }
    }
}
