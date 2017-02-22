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

namespace PA2Simulator
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer; 

        SerialPort _serial_port = null;

        public Form1()
        {
            InitializeComponent();

            GetSerialPorts();

            // Create a timer and set a one second interval.
            aTimer = new System.Timers.Timer(1000);

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
        }

        private void GetSerialPorts()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();

            do
            {
                index += 1;
                PortComboBox.Items.Add(ArrayComPortsNames[index]);
            } while (!((ArrayComPortsNames[index] == ComPortName) ||
                       (index == ArrayComPortsNames.GetUpperBound(0))));

            Array.Sort(ArrayComPortsNames);

            //want to get first out
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            PortComboBox.Text = ArrayComPortsNames[0];
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (_serial_port == null)
            {
                try
                {
                    _serial_port = new SerialPort(PortComboBox.Text);
                    _serial_port.BaudRate = 9600;
                    _serial_port.Parity = Parity.None;
                    _serial_port.StopBits = StopBits.One;
                    _serial_port.DataBits = 8;
                    _serial_port.Handshake = Handshake.None;
                    _serial_port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    _serial_port.Open();
                    ConnectButton.Text = "Disconnect";
                    SendCommand("B1\r");
                }
                catch (Exception ex)
                {
                    _serial_port = null;
                    ConnectButton.Text = "Connect";
                    System.Console.WriteLine(ex.Message);
                    string error_text = "Unable to open serial port";
                    MessageBox.Show(error_text);
                }
            }
            else
            {
                bPA2Test = false;
                PA2Test.Text = "PA2 OFF";
                _serial_port.Close();
                _serial_port = null;
                ConnectButton.Text = "Connect";
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial_port = (SerialPort)sender;
            string indata = serial_port.ReadExisting();
            foreach (char ch in indata)
            {
                if (ch=='\r'||ch=='\n')
                {
                }
                else
                {
                }
            }
        }

        void SendCommand(string text)
        {
            if (_serial_port != null && _serial_port.IsOpen)
            {
                _serial_port.Write(text);
            }
        }

        float Vrms = 231.48f;   //2
        float Irms = 2.31f; //3
        float Preal = 480.23f;  //4
        float VA = 0;   //5
        float QA = 12;  //6
        float QI = 34;  //7
        float PF = 80;   //8
        float Temp = 37.5f;   //9
        float PH = 33;  //10
        float PFU = 44; //11
        float PQF = 55; //12
        float Watthr = 0; //13
        int Interval = 0;

        Random random = new Random();

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            float fVrms = 225.0f + random.Next(0, 100)/10.0f;
            float fIrms = 0.0f + random.Next(0, 100)/40.0f;
            float fPF = 80.0f + random.Next(0, 100)/10.0f;
            setTextboxText(fVrms, fIrms, fPF);
        }

        void setTextboxText(float fVrms, float fIrms, float fPF)
        {
            if (this.InvokeRequired)
            { 
                this.Invoke(new IntrDelegate(SetTextboxTextSafe), new object[] { fVrms, fIrms, fPF }); 
            }
            else
            {
                SetTextboxTextSafe(fVrms, fIrms, fPF);
            }
        }

        delegate void IntrDelegate(float fVrms, float fIrms, float fPF);

        void SetTextboxTextSafe(float fVrms, float fIrms, float fPF)
        {
            Vrms = fVrms;
            Vrms_textBox.Text = Vrms.ToString();
            Irms = fIrms;
            Irms_textBox.Text = Irms.ToString();
            PF_textBox.Text = fPF.ToString();
            PF = fPF/100.0f;
            PF_textBox.Text = fPF.ToString();

            VA = Vrms * Irms;
            Preal = VA * PF;
            Preal_textBox.Text = Preal.ToString();

            Watthr += Preal / 3600.0f;
            Watthr_textBox.Text = Watthr.ToString();

            Interval += 1;
            Interval_textBox.Text = Interval.ToString();

            if (bPA2Test)
            {
                string PA2_data = (char)2 + "OK,1000," + Vrms.ToString() + "," + Irms.ToString() + ","
                    + Preal.ToString() + "," + VA.ToString() + "," + QA.ToString() + "," + QI.ToString() + ","
                    + PF.ToString() + "," + Temp.ToString() + "," + PH.ToString() + "," + PFU.ToString() + ","
                    + PQF.ToString() + "," + Watthr.ToString() + "," + Interval.ToString() + (char)3;

                SendCommand(PA2_data);
            }
        }

        bool bPA2Test = false;

        private void PA2Test_Click(object sender, EventArgs e)
        {
            if (_serial_port!=null)
            {
                if (!bPA2Test)
                {
                    bPA2Test = true;
                    PA2Test.Text = "PA2 ON";
                }
                else
                {
                    bPA2Test = false;
                    PA2Test.Text = "PA2 OFF";
                }
            }
        }

    }
}
