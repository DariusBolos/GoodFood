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
        
        
        public Creare_cont_client()
        {
            InitializeComponent();
            btn_creareCont.BackColor = Color.SkyBlue;
            btn_back.BackColor = Color.SkyBlue;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        private void btn_creareCont_Click(object sender, EventArgs e)
        {
            List<User> Users = new List<User>();
            Users.Add(new User(textBox_email.Text, textBox_parola.Text));
        }
    }
}
