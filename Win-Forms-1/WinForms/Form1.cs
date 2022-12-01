using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
   

    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string message);
        public event MyDelegate MyEvent;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyEvent += textBoxMessage;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Isa")
            {
               if(MyEvent != null)
                {
                    MyEvent(listBox1.Text);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void textBoxMessage(string message)
        {
            MessageBox.Show("New Message from Admin:"+message);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       
        private void listBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.Text.Length.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
