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
    public partial class Creare_cont_client : Form
    {
        bool ok;
        List<User> Users = new List<User>();
        public Creare_cont_client()
        {
            InitializeComponent();
            btn_creareCont.BackColor = Color.SkyBlue;
            btn_back.BackColor = Color.SkyBlue;
            Users.Add(new User("1", "1", "1", "1", "1"));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        private void btn_creareCont_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text != "")
                    ok = true;
                else
                {
                    ok = false;
                    break;
                }
            }
            if(!ok)
            {
                MessageBox.Show("Introduceti toate datele de autentificare!");
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                    tb.Clear();

                return;
            }

            foreach (User user in Users)
            {
                if (textBox_email.Text == user.email && textBox_parola.Text == user.password && textBox_nume.Text == user.nume && textBox_prenume.Text == user.prenume && textBox_adresa.Text == user.adresa)
                {
                    MessageBox.Show("Utilizatorul exista deja!");
                    return;
                }
            }
            Users.Add(new User(textBox_email.Text, textBox_parola.Text, textBox_nume.Text, textBox_prenume.Text, textBox_adresa.Text));
            Creare_cont_succes form = new Creare_cont_succes();
            this.Hide();
            form.Show();
        }
    }
}
