using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objektum_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Rogzit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nev.Text.Trim()))
            {
                MessageBox.Show("Nem töltötte ki a név mezőt!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Nev.Focus();
            }
            if (checkBox_enek.Checked ==false &&  checkBox_magyar.Checked ==false && checkBox_matek.Checked == false)
            {
                MessageBox.Show("Nem jelölt be tantárgyat!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Tanulo tanulo = new Tanulo(textBox_Nev.Text.Trim(), (int)numericUpDown1.Value, checkBox_matek.Checked, checkBox_magyar.Checked, checkBox_enek.Checked, comboBox_hobby.SelectedItem.ToString());
            listBox_Tanulok.Items.Add(tanulo);
        }

        private void listBox_Tanulok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tanulo tanulo = (Tanulo)listBox_Tanulok.Items[listBox_Tanulok.SelectedIndex];
            textBox_Nev.Text = tanulo.Nev;
            numericUpDown1.Value = tanulo.Magassag;
            checkBox_enek.Checked = tanulo.Enek;
            checkBox_magyar.Checked = tanulo.Magyar;
            checkBox_matek.Checked = tanulo.Matek;

        }
    }
}
