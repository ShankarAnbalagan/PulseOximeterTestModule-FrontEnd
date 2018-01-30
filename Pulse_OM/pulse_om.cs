using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse_OM
{
    public partial class pulse_om : Form
    {
        private Thread graphThread;

        private String indata = "";
        private String[] recvData = { "-", "-", "0" };
        private String sendData = "";
        int[] plDataArray = new int[200];
        int count=0;
        int graphValue = 0;
        private float spo2;
        private float bpm;
        private float pi;
        private float[,] freqency = new float[2, 3];

        frequencyCalc fc = new frequencyCalc();

        public pulse_om()
        {
            InitializeComponent();
        }

        private void pulse_om_Load(object sender, EventArgs e)
        {
            spo2_req.Value = 98;
            bpm_req.Value = 72;
            pi_req.Value = 10;
            label6.Text = "Status";
            spo2_test.Text = "-";
            bpm_test.Text = "-";

            PLGraph.Series["Series1"].Points.Clear();

            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            indata = serialPort1.ReadLine();
            findData();
            //MessageBox.Show(recvData[0]+" "+recvData[1]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spo2_test.Text = recvData[0];
            bpm_test.Text = recvData[1];
            plDataArray[count] = Convert.ToInt32(recvData[2]);
            count = (count + 1) % 200;
        }

        private void findData()
        {
            int p = 0;
            String[] individual_data = new String[13];
            individual_data = indata.Split(',');
            while (p < 14)
            {
                try
                {
                    if (individual_data[p].Equals("135"))
                    {
                        recvData[0] = individual_data[p + 4];
                        recvData[1] = individual_data[p + 3];
                        recvData[2] = individual_data[p + 1];
                        break;
                    }
                }
                catch (Exception)
                {
                    return;
                }
                p++;
            }
        }

        private void plotGraph()
        {
            while (true)
            {


                if (PLGraph.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdatePLGraph(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdatePLGraph()
        {
            PLGraph.Series["Series1"].Points.Clear();

            for (int i = 0; i < plDataArray.Length - 1; ++i)
            {
                if(plDataArray[i]<0)
                    PLGraph.Series["Series1"].Points.AddY(0);
                if(plDataArray[i]<127)
                    PLGraph.Series["Series1"].Points.AddY(127);
                else
                    PLGraph.Series["Series1"].Points.AddY(plDataArray[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphThread = new Thread(new ThreadStart(this.plotGraph));
            graphThread.IsBackground = true;

            label6.Text = "Finger detected";
            spo2 = (float)spo2_req.Value;
            bpm = (float)bpm_req.Value;
            pi = (float)pi_req.Value;
            freqency = fc.frequencyOfWaves(spo2, bpm, pi);
            convToString(freqency);

            try
            {
                //serialPort1.WriteLine(sendData);
                sendData = "";
            }
            catch (Exception)
            {
                MessageBox.Show("COM not available");
                sendData = "";
                return;
            }

            Thread.Sleep(500);
            if (recvData != null)
            {
                timer1.Start();
                graphThread.Start();
            }
            else
            {
                label6.Text = "No incomming data";
            }

        }

        private void convToString(float[,] f)
        {
            String s;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    s = (Math.Floor(f[i, j])).ToString();
                    sendData = sendData + s + ",";
                }
            sendData = sendData + "\0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            graphThread.Abort();
            PLGraph.Series["Series1"].Points.Clear();
            label6.Text = "No Finger detected";
            serialPort1.WriteLine("B");
            spo2_test.Text = "-";
            bpm_test.Text = "-";

        }

        ~pulse_om()
        {
            serialPort1.Close();
        }


        private void cOM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM2";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM3";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM4";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM5";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM6";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM7";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }

        private void cOM8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM8";
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not available");
            }
        }
    }
}