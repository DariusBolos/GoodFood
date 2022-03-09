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
    public partial class Optiuni : Form
    {
        public Optiuni()
        {
            InitializeComponent();
            
        }

        private void btn_calculeaza_Click(object sender, EventArgs e)
        {
            int S = 0;
         
            if (textBox_varsta.Text != "" && textBox_inaltime.Text != "" && textBox_greutate.Text != "")
            {
                S = Convert.ToInt32(textBox_varsta.Text) + Convert.ToInt32(textBox_inaltime.Text) + Convert.ToInt32(textBox_greutate.Text);
                if (S < 250)
                    label_kcal.Text = "1800";
                else
                if (S >= 250 && S <= 750)
                    label_kcal.Text = "2200";
                else
                    label_kcal.Text = "2500";
            }
            else
                MessageBox.Show("Introduceti datele!");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
