using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UyeKayit.PersonCheck;


namespace UyeKayit
{
    public partial class Form1 : Form
    {
        public string Del()
        {
            string ComponentText = "";
            return (ComponentText);
        
        }
        public void TextUpper(object sender, string message)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = message;
            }
            else
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextUpper(sender, "Adınız...");
            
        }
       

        private void textBox1_Enter(object sender, EventArgs e)
        {

           
            ((TextBox)sender).Text =  Del();
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Del();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            // yukarıdakilerle aynıdır kullanımı.
            ((TextBox)sender).Text = Del();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextUpper(sender, "Soyadınız...");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TextUpper(sender, "Doğum Yılınız...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonCheckService personCheckService = new PersonCheckService();
            personCheckService.Control(maskedTextBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            
        }
    }
}
