using System;
using System.Windows.Forms;
using System.IO.Ports;

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
                Data = serialPort1.ReadLine();
                

                Console.WriteLine("puerto abierto");


            }
            else
            {
                Console.WriteLine(close);
            }
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2(object sender, EventArgs e)
        {



        }




        public void Button2_Click(object sender, EventArgs e)
        {
          


            int count = 3;
            // Crear vector con tamaño que se ha asignado
            string[] datossensor = new string[count];

            // Llenar 


            for (int i = 0; i < 3; i++)
            {
                Console.Write("dato de sensor {0}: ", i);
                datossensor[i] = serialPort1.ReadLine();
                
            }
            textBox2.Text = datossensor[0];
            textBox3.Text = datossensor[1];
            textBox4.Text = datossensor[2];



            // Imprimirlo
            Console.WriteLine("\nValores del vector:\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Posicion {0}: {1}", i, datossensor[i]);
             

            }












        }










        private void Label1_Click(object sender, EventArgs e)
        {

        }


        //DisplayText sirve para ver los datos en tiempo real
        private void DisplayText(object sender, EventArgs e)
        {


            textBox2.AppendText(Data);
           

        }

        







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
