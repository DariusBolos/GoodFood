using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodFood
{
    public partial class Autentificare_clienti : Form
    {
        List<User> Users = new List<User>();
        public Autentificare_clienti()
        {
            InitializeComponent();
            btn_autentificare.BackColor = Color.SkyBlue;
            btn_back.BackColor = Color.SkyBlue;
            
        }

        private void btn_autentificare_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text != "" && textBox_password.Text != "")
            {
                foreach(User user in Users)
                    if (textBox_email.Text == user.email && textBox_password.Text == user.password)
                    {
                        this.Hide();
                        Optiuni form = new Optiuni();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Eroare autentificare!");
                        textBox_email.Clear();
                        textBox_password.Clear();
                    }
            }
            else
                MessageBox.Show("Introduceti datele de autentificare!");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }
    }
}
