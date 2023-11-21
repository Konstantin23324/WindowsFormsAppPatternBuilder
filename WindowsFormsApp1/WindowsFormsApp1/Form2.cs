using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.NewFolder1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            labelPictures.Text = FormAutorization.Enter_User.Pictures;
            labelLogin.Text = FormAutorization.Enter_User.Login;
        }

        private void labelPictures_Click(object sender, EventArgs e)
        {

        }
    }
}
