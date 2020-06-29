using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialComonication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAllPort();
        }
        void getAllPort()
        {
            string[] s = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32((comboBox2.Text));
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch(Exception)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(richTextBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = serialPort1.ReadLine();

        }
    }

}
