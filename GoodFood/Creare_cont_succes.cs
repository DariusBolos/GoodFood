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
    public partial class Creare_cont_succes : Form
    {
        public Creare_cont_succes()
        {
            InitializeComponent();
        }

        private void button_succes_Click(object sender, EventArgs e)
        {
            Autentificare_clienti form = new Autentificare_clienti();
            this.Hide();
            form.Show();
        }
    }
}
