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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            btn_inregistrare.BackColor = Color.SkyBlue;
            btn_autentificare.BackColor = Color.SkyBlue;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creare_cont_client form = new Creare_cont_client();
            form.Show();
        }

        private void btn_autentificare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificare_clienti form = new Autentificare_clienti();
            form.Show();
        }
    }
}
