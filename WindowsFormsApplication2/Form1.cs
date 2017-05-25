using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public enum APPLanguage
    {
        English,
        Slovensky
    }

    public enum DisplayPhase
    {
        selectLang,
        enterPin,
        withdrawmoney,
        cardBlocked,
        maketranstaction
    }

    public partial class Form1 : Form
    {
        private object state;
        private object pin;
        private UserControl1 lbl;
        private UserControl2 lbl2;
        private UserControl3 lbl3;
        private UserControl4 lbl4;
        public Form1()
        {
            InitializeComponent();
            Form2 f = new Form2(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
            pictureBox2.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\slovakia-flag.jpg";
            pictureBox1.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\eng.jpg";
            lbl = new UserControl1();
            this.panel1.Controls.Add(lbl);
            lbl2 = new UserControl2();
            this.panel1.Controls.Add(lbl2);
            lbl3 = new UserControl3();
            this.panel1.Controls.Add(lbl3);
            lbl4 = new UserControl4();
            this.panel1.Controls.Add(lbl4);
        }

        public void SetPin(object pin)
        {
            this.pin = pin;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            
        }

        private void checkPinKod()
        {
            // todo Correct pin

            // todo incorrect pin
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add (lbl2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(lbl3);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(lbl4);
        }
    }
}
