using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
            pictureBox3.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\EUR10.jpg";
            pictureBox4.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\EUR20.jpg";
            pictureBox5.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\EUR50.jpg";
            pictureBox6.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\EUR100.jpg";
            pictureBox7.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\EUR200.jpg";
            pictureBox8.ImageLocation = @"C:\Users\lukas.oros\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\img\EUR500.jpg";

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
