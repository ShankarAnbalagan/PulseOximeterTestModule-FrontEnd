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
        private String indata = "";
        private String[] recvData=new String[2];
        private String sendData="";
        private float spo2;
        private float bpm;
        private float pi;
        private float[,] freqency=new float[2,3];

        frequencyCalc fc=new frequencyCalc();

        public pulse_om()
        {
            InitializeComponent();
        }

        private void pulse_om_Load(object sender, EventArgs e)
        {
            spo2_req.Value=98;
            bpm_req.Value=72;
            pi_req.Value=10;
            label6.Text = "Status";
            spo2_test.Text = "-";
            bpm_test.Text = "-";
            try
            {
                serialPort1.Open();
            }
            catch (Exception  )
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

        private void findData()
        {
            int p=0;
            String[] individual_data = new String[13];
            individual_data = indata.Split(',');
            while (p < 14)
            {
                if (individual_data[p].Equals("135"))
                {
                    recvData[0] = individual_data[p + 3];
                    recvData[1] = individual_data[p + 4];
                    break;
                }
                p++;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Finger detected";
            spo2= (float)spo2_req.Value;
            bpm = (float)bpm_req.Value;
            pi = (float)pi_req.Value;
            freqency = fc.frequencyOfWaves(spo2, bpm, pi);
            convToString(freqency);

            try
            {
                serialPort1.WriteLine(sendData);
                sendData = "";
            }
            catch (Exception)
            {
                MessageBox.Show("COM not available");
                sendData = "";
                return;
            }

            Thread.Sleep(500);
            if (recvData!=null)
            {
                spo2_test.Text = recvData[0];
                bpm_test.Text = recvData[1];
                //plotGraph();
            }
            else
            {
                label6.Text = "No incomming data";
            }
            
        }

        private void convToString(float[,] f)
        {
            String s;
            for(int i=0;i<2;i++)
                for(int j = 0; j < 3; j++)
                {
                    s = (Math.Floor(f[i, j])).ToString();
                    sendData = sendData + s + ",";
                }
            sendData = sendData + "\0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "No Finger detected";
            serialPort1.WriteLine("B");
            spo2_test.Text = "-";
            bpm_test.Text = "-";
         
        }

        ~pulse_om()
        {
            serialPort1.Close();
        }

        private void plotGraph()
        {
            int x = 0;
            Bitmap BM = new Bitmap(
                           pictureBox1.ClientSize.Width,
                           pictureBox1.ClientSize.Height);
            pictureBox1.Image = BM;
            while(recvData!=null)
            {
                //change here
                int y = (int)(Math.Sin((double)x / 50) * BM.Height / 2 + BM.Height / 2);
                //int y = 0;
                x++;
                if (x == 10000) x = 0;
                BM.SetPixel(0, y, Color.Black);
                BM = BM.Scroll(1, 0);
                pictureBox1.Image = BM;
                Application.DoEvents();
            }
        }

        private void cOM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            try
            {
                serialPort1.Open();
            }
            catch (Exception  )
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
            catch (Exception  )
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
            catch (Exception  )
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
            catch (Exception  )
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
            catch (Exception  )
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
            catch (Exception  )
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
            catch (Exception  )
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
            catch (Exception  )
            {
                MessageBox.Show("COM is not available");
            }
        }
    }



    public static class MyExtensions
    {
        [DllImport("user32.dll")]
        private static extern int ScrollWindowEx(
          System.IntPtr hWnd,
          int dx,
          int dy,
        [MarshalAs(UnmanagedType.LPStruct)]
   RECT prcScroll,
        [MarshalAs(UnmanagedType.LPStruct)]
   RECT prcClip,
          System.IntPtr hrgnUpdate,
        [MarshalAs(UnmanagedType.LPStruct)]
   RECT prcUpdate,
          System.UInt32 flags);

        public static Bitmap Scroll(this Bitmap BM,
                                      int dx, int dy)
        {
            Bitmap BMTemp = new Bitmap(BM.Width,
                                            BM.Height);
            Graphics G = Graphics.FromImage(BMTemp);
            G.DrawImage(BM, dx, dy);
            G.Dispose();
            return BMTemp;
        }

        public static void Scroll(this PictureBox BP,
                                         int dx, int dy)
        {
            ScrollWindowEx(BP.Handle,
                           dx, dy,
                           null, null,
                           IntPtr.Zero,
                           null, 2);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public class RECT
    {
        public Int32 left;
        public Int32 top;
        public Int32 right;
        public Int32 bottom;
    }
}
