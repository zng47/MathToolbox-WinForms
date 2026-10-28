using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var islem =  comboBox1.SelectedItem.ToString();

            int sayi1 = Convert.ToInt32(maskedTextBox1.Text);
            int sayi2 = Convert.ToInt32(maskedTextBox2.Text);
            if(comboBox1.SelectedItem.ToString() == "+")
            {
                int sonuc = sayi1 + sayi2;
                listBox1.Items.Add(sonuc);
            }
            else if (comboBox1.SelectedItem.ToString() == "-")
            {
                int sonuc = sayi1 - sayi2;
                listBox1.Items.Add(sonuc);
            }
            else if (comboBox1.SelectedItem.ToString() == "*")
            {
                int sonuc = sayi1 * sayi2;
                listBox1.Items.Add(sonuc);
            }
            else if (comboBox1.SelectedItem.ToString() == "/")
            {
                int sonuc = sayi1 / sayi2;
                listBox1.Items.Add(sonuc);
            }




        }  
    }
}
