using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_TempHum
{
    public partial class Form1 : Form
    {
        private const string close = "Port is close";
        public String Data;


        public Form1()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                Console.WriteLine("puerto abierto");

            }
            else {
                Console.WriteLine(close);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
         Data=serialPort1.ReadLine();
            Console.WriteLine("Datos recibidos");
            Console.WriteLine(Data);
            Console.WriteLine("****");


        }



        private void Button2_Click(object sender, EventArgs e)
        {

                textBox2.Text = Data;
                // Data = serialPort1.ReadLine();

                Console.WriteLine("Datos de boton2");
                Console.WriteLine(Data);
            
        }





        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
