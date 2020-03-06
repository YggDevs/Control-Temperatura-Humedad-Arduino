using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Control_TempHum
{
    public partial class Form1 : Form
    {
        private const string close = "Port is close";
        public String Data;
       

        public Form1()
        {
            InitializeComponent();
            conectarpuertos();
            


        }



        public void conectarpuertos() {

            Control.CheckForIllegalCrossThreadCalls = false;

            foreach (string s in SerialPort.GetPortNames())

            {

                comboBox1.Items.Add(s);

            }

        }



        public void generartxt(string datossensor0, string datossensor1, string datossensor2)
        {

            string time = DateTime.Now.ToString("hh:mm:ss");
            string date = DateTime.Now.ToLongDateString();


          
            // timer para que se ejecute a una hora determinada para obtener los datos solo las horas que indicamos
         /*   
            for (int i = 10; i < 12; i++)
            {
                int I = i;
              
              
                if (time.StartsWith(I.ToString()))
                {

                    Console.Write("funcioina  " + time+"  iterador  "+I);
                }
            }

               */
          


                string path = @"c:\temp\Control_TEM_HUMEDAD.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {

               
                  
                try
                {
                    sw.WriteLine("Fecha " + date+ " time  " +time+"  " +datossensor0+" "+ datossensor1+" " + datossensor2);
                   
                }
                catch {
                    sw.WriteLine("No hay datos");
                }  

                
                }
            



        }


      /*   private void Button1_Click(object sender, EventArgs e)
        {

           
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
               // textBox5.Text = "Estas conectado al " +port;
               
            }

            Console.ReadLine();


        }

    */

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2(object sender, EventArgs e)
        {



        }




        public void Button2_Click(object sender, EventArgs e)
        {
            int c = 0;
            int d = 1;

            while (c < d) {
                int count = 3;
                // creamo sun vector de tamaño 3 porque vamos a recibir tres datos
                string[] datossensor = new string[count];

                // Llenar 


                for (int i = 0; i < 3; i++)
                {
                    Console.Write("dato de sensor {0}: ", i);
                    datossensor[i] = serialPort1.ReadLine();
                   
                }
                



                // Imprimirlo
                Console.WriteLine("\nValores del vector:\n");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Posicion {0}: {1}", i, datossensor[i]);
                  

                    textBox2.Text = datossensor[0];
                    textBox3.Text = datossensor[1];
                    textBox4.Text = datossensor[2];
                    generartxt(datossensor[0], datossensor[1], datossensor[2]);

                }
               

            }









        }










        private void Label1_Click(object sender, EventArgs e)
        {

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerramos el puerto cuando cerramos el formulario
            serialPort1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

           // este evento SelectedIndexChanged.
            //hará que el puerto sea válido deshabilitará el resto .

            serialPort1.PortName = comboBox1.Text;

            try
            {

                serialPort1.Open();
                
            }

            catch

            {

                MessageBox.Show("Puerto no válido");

                return;

            }

            comboBox1.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
