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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }
        public static Users Enter_User;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "" || textBoxPass.Text=="")
            {
                MessageBox.Show("поля не заполнены");
            }
            else
            {
                Enter_User = null;
                Model1 model1 = new Model1();
                Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBoxLog.Text && x.Password == textBoxPass.Text);
                if (Enter_User != null)
                {
                    switch (Enter_User.RoleID)
                    {
                        case 1:
                            FormManager formManager = new FormManager();
                            formManager.ShowDialog();
                            break;
                        case 2:
                            FormSeller formSeller = new FormSeller();
                            formSeller.ShowDialog();
                            break;
                        case 3:
                            FormDirector formDirector = new FormDirector();
                            formDirector.ShowDialog();
                            break;
                            case 4:
                            Form2 form2 = new Form2();
                            form2.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет");
                }
            }
        }
        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
