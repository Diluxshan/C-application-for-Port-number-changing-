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
using on_off_displaying.classes;

namespace on_off_displaying
{
    public partial class portListener : Form
    {
        public portListener(String portName)
        {
            InitializeComponent();
            serialPort1.PortName = portName;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            addInfoToLog("status", "Port Listening ... ");
            addInfoToLog("status", "Put the card to Reader.....");

        }

        private void connectPort() {
            // serialPortUtil cls = new serialPortUtil();
            addInfoToLog("status", serialPortUtil.connectPort(serialPort1));

            User user1 = new User("Dilux", "vahe");
            User user2 = new User("Sutha", "kai");
            User user3 = new User("lux", "ve");
            user1.setAge(14);
            user2.setAge(15);

            User.compareAge(user1.getAge(), user2.getAge());

        }

        private void addInfoToLog(String Type, String msg)
        {
            listBox1.Items.Add(DateTime.Now.ToString() + "  " + " || " + "  " + Type.ToUpper() + " - " + msg);
           

        }


        //check the arduino code timely
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            try
            {
                if (!serialPort1.IsOpen)
                {
                    connectPort();
                }
                string READ;
                READ = serialPort1.ReadLine();
                addInfoToLog("STATUS", READ.ToString());
                listBox1.SelectedIndex = listBox1.Items.Count - 1;   //continue rolling scroll bar.
                
               
            }
            catch (Exception ex)
            {
                addInfoToLog("error", ex.Message);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;   
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

 
 