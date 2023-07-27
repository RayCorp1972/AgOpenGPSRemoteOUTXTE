using System;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
using System.Drawing;

namespace AgOpenGPS
{
    public partial class FormXTEGraph : Form
    {

        const string asciiHex = "0123456789ABCDEF";
        public event SerialDataReceivedEventHandler DataReceived;
        private SerialPort SerialPort1 = new SerialPort();
        private readonly FormGPS mf = null;
        private int Counter = 0;
        public Label GetLabel;
        //chart data
        private string dataSteerAngle = "0";

        public string dataPWM = "0";
        public string XTEOUTT = "";
        private bool isAuto = true;

        public FormXTEGraph(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();

            this.label5.Text = "HE";
            this.label1.Text = "XTE";

            this.Text = "XTE Chart";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            {
                //word 0 - steerangle, 1 - pwmDisplay
                //dataSteerAngle = mf.mc.actualSteerAngleChart.ToString(CultureInfo.InvariantCulture);

                dataPWM = ((int)(mf.vehicle.modeActualXTE * 1000)).ToString(CultureInfo.InvariantCulture);

                dataSteerAngle = (Math.Round(mf.vehicle.modeActualHeadingError, 1)).ToString(CultureInfo.InvariantCulture);

                lblSteerAng.Text = dataSteerAngle + "\u00B0";
                lblPWM.Text = dataPWM;

            }

            //chart data
            Series s = unoChart.Series["S"];
            Series w = unoChart.Series["PWM"];
            double nextX = 1;
            double nextX5 = 1;

            if (s.Points.Count > 0) nextX = s.Points[s.Points.Count - 1].XValue + 1;
            if (w.Points.Count > 0) nextX5 = w.Points[w.Points.Count - 1].XValue + 1;

            unoChart.Series["S"].Points.AddXY(nextX, dataSteerAngle);
            unoChart.Series["PWM"].Points.AddXY(nextX5, dataPWM);


            //if (isScroll)
            while (s.Points.Count > 120)
            {
                s.Points.RemoveAt(0);
            }
            while (w.Points.Count > 120)
            {
                w.Points.RemoveAt(0);
            }
            unoChart.ResetAutoValues();
        }

        private void FormSteerGraph_Load(object sender, EventArgs e)
        {

            comboBox3.SelectedIndex = 3;

            try
            {
                foreach (string port in SerialPort.GetPortNames())
                {
                    comboBox1.Items.Add(port);
                }
                //ComboBox2.SelectedIndex = 0;
                // Button1.BackCol or = Color.Green;
                // Button2.BackColor = Color.Green;
            }

            catch (Exception)
            {
                // Handle exception if needed
            }
            timer1.Interval = (int)((1 / mf.gpsHz) * 1000);

            unoChart.ChartAreas[0].AxisY.Minimum = -80;
            unoChart.ChartAreas[0].AxisY.Maximum = 80;
            unoChart.ResetAutoValues();

            lblMax.Text = ((int)(unoChart.ChartAreas[0].AxisY.Maximum)).ToString() + " cm";
            lblMin.Text = ((int)(unoChart.ChartAreas[0].AxisY.Minimum)).ToString() + " cm";

            isAuto = false;
            //lblMax.Text = "Auto";
            //lblMin.Text = "0";

        }

        private void btnGainUp_Click(object sender, EventArgs e)
        {
            if (isAuto)
            {
                unoChart.ChartAreas[0].AxisY.Minimum = -80;
                unoChart.ChartAreas[0].AxisY.Maximum = 80;
                unoChart.ResetAutoValues();
                lblMax.Text = (unoChart.ChartAreas[0].AxisY.Maximum).ToString() + " cm";
                lblMin.Text = (unoChart.ChartAreas[0].AxisY.Minimum).ToString() + " cm";
                isAuto = false;
                return;
            }

            if (unoChart.ChartAreas[0].AxisY.Maximum >= 5120)
            {
                unoChart.ChartAreas[0].AxisY.Minimum = -5120;
                unoChart.ChartAreas[0].AxisY.Maximum = 5120;
                unoChart.ResetAutoValues();
                lblMax.Text = (unoChart.ChartAreas[0].AxisY.Maximum).ToString() + " cm";
                lblMin.Text = (unoChart.ChartAreas[0].AxisY.Minimum).ToString() + " cm";
                return;

            }


            unoChart.ChartAreas[0].AxisY.Minimum *= 2;
            unoChart.ChartAreas[0].AxisY.Maximum *= 2;
            unoChart.ChartAreas[0].AxisY.Minimum = (int)unoChart.ChartAreas[0].AxisY.Minimum;
            unoChart.ChartAreas[0].AxisY.Maximum = (int)unoChart.ChartAreas[0].AxisY.Maximum;
            unoChart.ResetAutoValues();
            lblMax.Text = (unoChart.ChartAreas[0].AxisY.Maximum).ToString() + " cm";
            lblMin.Text = (unoChart.ChartAreas[0].AxisY.Minimum).ToString() + " cm";
        }

        private void btnGainAuto_Click(object sender, EventArgs e)
        {
            unoChart.ChartAreas[0].AxisY.Maximum = Double.NaN;
            unoChart.ChartAreas[0].AxisY.Minimum = Double.NaN;
            unoChart.ChartAreas[0].RecalculateAxesScale();
            unoChart.ResetAutoValues();
            lblMax.Text = "Auto";
            lblMin.Text = "";
            isAuto = true;
        }

        private void btnGainDown_Click(object sender, EventArgs e)
        {
            if (isAuto)
            {
                unoChart.ChartAreas[0].AxisY.Minimum = -80;
                unoChart.ChartAreas[0].AxisY.Maximum = 80;
                unoChart.ResetAutoValues();
                lblMax.Text = (unoChart.ChartAreas[0].AxisY.Maximum).ToString() + " cm";
                lblMin.Text = (unoChart.ChartAreas[0].AxisY.Minimum).ToString() + " cm";
                isAuto = false;
                return;
            }

            if (unoChart.ChartAreas[0].AxisY.Minimum >= -19.999999)
            {
                unoChart.ChartAreas[0].AxisY.Minimum = -10;
                unoChart.ChartAreas[0].AxisY.Maximum = 10;
                unoChart.ResetAutoValues();
                lblMax.Text = (unoChart.ChartAreas[0].AxisY.Maximum).ToString() + " cm";
                lblMin.Text = (unoChart.ChartAreas[0].AxisY.Minimum).ToString() + " cm";
                return;
            }

            unoChart.ChartAreas[0].AxisY.Minimum *= 0.5;
            unoChart.ChartAreas[0].AxisY.Maximum *= 0.5;
            unoChart.ChartAreas[0].AxisY.Minimum = (int)unoChart.ChartAreas[0].AxisY.Minimum;
            unoChart.ChartAreas[0].AxisY.Maximum = (int)unoChart.ChartAreas[0].AxisY.Maximum;
            unoChart.ResetAutoValues();
            lblMax.Text = (unoChart.ChartAreas[0].AxisY.Maximum).ToString() + " cm";
            lblMin.Text = (unoChart.ChartAreas[0].AxisY.Minimum).ToString() + " cm";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {  

       if (VerbindBtn.Text == "Verbinden") 

            try
            {

                SerialPort1.PortName = comboBox1.Text;
                SerialPort1.BaudRate = int.Parse(comboBox2.Text);
                SerialPort1.Open();
                VerbindBtn.BackColor = Color.Red;
                VerbindBtn.Text = "Verbreken";
                timer2.Interval = int.Parse(comboBox3.Text);
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        else
            {
                if (SerialPort1.IsOpen)
                {
                    timer2.Stop();
                    SerialPort1.Close();
                    VerbindBtn.Text = "Verbonden";
                   VerbindBtn.BackColor = Color.Red;
                }
                VerbindBtn.BackColor = Color.Green;
                VerbindBtn.Text = "Verbinden";
            }
        }

    
           
           
        

     


        public void BuildXTE()
        {

            string XTEin = dataPWM;
            int XTEOUT1 = int.Parse(XTEin );
           
            string stringXTE1 = Math.Abs(XTEOUT1 * 0.001).ToString("0.000");

            label3.Text = stringXTE1;
            string nmeaXTE = "";

            nmeaXTE += "$GPXTE,";

            nmeaXTE += "A,A,";

            //double metersXTE = Math.Abs(dataPWM).ToString(CultureInfo.InvariantCulture);
            string stringXTE = label3.Text;
            nmeaXTE += stringXTE + ",";

            string numberString = dataPWM;
            int number = int.Parse(numberString);

            
            


            if (number < 0)
            {
                nmeaXTE += "R,";
            }
            else
            {
                nmeaXTE += "L,";
            }

            nmeaXTE += "N*";

            CalculateChecksum1(ref nmeaXTE);

            nmeaXTE += "\r\n";

            // Assuming you are sending the NMEA message via a serial port named "Serial5"
            //SerialPort1.Write(nmeaXTE);
            //Serial5.WriteLine(nmeaXTE);
            XTEOUTT = nmeaXTE;
        }

        public void CalculateChecksum1(ref string nmeaXTE)
        {
            int sum = 0;
            char tmp;

            // The checksum calc starts after '$' and ends before '*'
            for (int inx = 1; inx < nmeaXTE.Length; inx++)
            {
                tmp = nmeaXTE[inx];

                // * Indicates end of data and start of checksum
                if (tmp == '*')
                {
                    break;
                }

                sum ^= Convert.ToInt32(tmp); // Build checksum using XOR operation
            }

            int chk = sum >> 4;
            char hex = asciiHex[chk];
            nmeaXTE += hex;

            chk = sum % 16;
            hex = asciiHex[chk];
            nmeaXTE += hex;
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            if (VerbindBtn.Text == "Verbreken")
            {
                try
                {
                    if (SerialPort1.IsOpen)
                    {
                        timer2.Start();
                        Counter = 1;
                        ZendBtn.Text = "Zenden";
                        ZendBtn.BackColor = Color.Red;
                    }
                    else
                    {
                        MessageBox.Show("Poort is niet open!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (timer2.Enabled)
                {
                    timer2.Stop();
                }
                ZendBtn.Text = "Begin";
                ZendBtn.BackColor = Color.Green;
                Counter = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                BuildXTE();
                SerialPort1.Write(XTEOUTT + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SerialPort1.Write("$GPGGA,104732.000,5100.001,N,00400.000,E,4,04,3,100,M,-34,M,0.0,0000*47" + Environment.NewLine);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }


}