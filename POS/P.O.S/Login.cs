using System;
using System.Windows.Forms;
using Methods;

namespace Bill_System
{
    public partial class Login : Form
    {
        Methods.Library dll = new Library();
        public Login()
        {
            InitializeComponent();
        }
        private void lgnBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (dll.username[i] == nameTxt.Text)
                {
                    if (dll.password[i] == dll.dePass(passTxt.Text))
                    {
                        POS p = new POS();
                        p.Show();
                        nameTxt.Clear();
                        passTxt.Clear();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                        break;
                    }
                }
            }
        }
        private void sgnBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }


        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (PasswordSU_TB.Text == CnfrmPassSU_TB.Text)
            {
                dll.enPass(PasswordSU_TB.Text, UNameSU_TB.Text);
                MessageBox.Show("Registered!!");
                UNameSU_TB.Clear();
                PasswordSU_TB.Clear();
                CnfrmPassSU_TB.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }

        private void SULogin_Btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
