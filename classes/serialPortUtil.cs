using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_off_displaying.classes
{
    class serialPortUtil
    {
        public static String connectPort(SerialPort serialPort)
        {
            try
            {
                serialPort.Open();
                return "Port Opened";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
