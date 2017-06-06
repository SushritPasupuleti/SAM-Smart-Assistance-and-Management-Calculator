using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SAM_Calculator
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer SAM = new SpeechSynthesizer();
        string Username = Environment.UserName;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Pink;
            TransparencyKey = Color.Pink;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        private void calcbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
                sc.Language = "VBScript";
                string expression = calcbox.Lines[calcbox.Lines.Length - 1];
                try
                {
                    calcbox.AppendText("\r\n" + sc.Eval(expression));
                    SAM.Speak(calcbox.Lines[calcbox.Lines.Length - 1]);
                }
                catch
                {
                    calcbox.AppendText("\r\nInvalid entry!");
                    SAM.Speak("System failure");
                }

            }
        }

        private void Closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SinT_Click(object sender, EventArgs e)
        {
            if (RadiansT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double SinAn = Math.Sin(An);
                ResultText.Text = SinAn.ToString();
            }
            if (DegreeT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double SinAn = Math.Sin(An * Math.PI / 180);
                ResultText.Text = SinAn.ToString();
            }
        }

        private void CosecT_Click(object sender, EventArgs e)
        {
            if (RadiansT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double SinAn = 1 / Math.Sin(An);
                ResultText.Text = SinAn.ToString();
            }
            if (DegreeT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double SinAn = 1 / Math.Sin(An * Math.PI / 180);
                ResultText.Text = SinAn.ToString();
            }
        }

        private void CosT_Click(object sender, EventArgs e)
        {
            if (RadiansT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double CosAn = Math.Cos(An);
                ResultText.Text = CosAn.ToString();
            }
            if (DegreeT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double CosAn = Math.Cos(An * Math.PI / 180);
                ResultText.Text = CosAn.ToString();
            }
        }

        private void SecT_Click(object sender, EventArgs e)
        {
            if (RadiansT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double CosAn = 1 / Math.Cos(An);
                ResultText.Text = CosAn.ToString();
            }
            if (DegreeT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double CosAn = 1 / Math.Cos(An * Math.PI / 180);
                ResultText.Text = CosAn.ToString();
            }
        }

        private void TanT_Click(object sender, EventArgs e)
        {
            if (RadiansT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double TanAn = Math.Tan(An);
                ResultText.Text = TanAn.ToString();
            }
            if (DegreeT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double TanAn = Math.Tan(An * Math.PI / 180);
                ResultText.Text = TanAn.ToString();
            }
        }

        private void CotT_Click(object sender, EventArgs e)
        {
            if (RadiansT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double TanAn = 1 / Math.Tan(An);
                ResultText.Text = TanAn.ToString();
            }
            if (DegreeT.Checked == true)
            {
                double An = Double.Parse(AngleText.Text);
                double TanAn = 1 / Math.Tan(An * Math.PI / 180);
                ResultText.Text = TanAn.ToString();
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double X = Double.Parse(XText.Text);
            double XP = Math.Sqrt(X);
            ResultText.Text = XP.ToString();
        }

        private void XY_Click(object sender, EventArgs e)
        {
            double XT = Double.Parse(XText.Text);
            double YT = Double.Parse(YText.Text);
            double XP = Math.Pow(XT, YT);
            ResultText.Text = XP.ToString();
        }

        private void XFacT_Click(object sender, EventArgs e)
        {
            int i, number, fact;
            number = int.Parse(XText.Text);
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
                ResultText.Text = fact.ToString();
            }
        }

        private void X2_Click(object sender, EventArgs e)
        {
            double XT = Double.Parse(XText.Text);
            double XP = Math.Pow(XT, 2);
            ResultText.Text = XP.ToString();
        }

        private void PiT_Click(object sender, EventArgs e)
        {
            ResultText.Text = Math.PI.ToString();
        }

        private void X3_Click(object sender, EventArgs e)
        {
            double XT = Double.Parse(XText.Text);
            double XP = Math.Pow(XT, 3);
            ResultText.Text = XP.ToString();
        }

        private void ClearT_Click(object sender, EventArgs e)
        {
            XText.Text = "";
            YText.Text = "";
            AngleText.Text = "";
            ResultText.Text = "";
        }

        private void ListenB_Click(object sender, EventArgs e)
        {
            if (Dumb.Checked == true)
            {
                Dumb.Checked = false;
                ListenB.Text = "Mute";
            }
            else
            {
                Dumb.Checked = true;
                ListenB.Text = "Muted";
            }
        }

        private void HelpMe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sam-by-sushrit-teknologies.blogspot.com/");
        }



    }
}
