using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotionLogger;
using System.Threading;
using System.Timers;

namespace GUITest
{
    public partial class Main_Form : Form
    {
        private static System.Timers.Timer aTimer;
        public Main_Form()
        {
            InitializeComponent();
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\MotionLogger.exe");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Train_Form f = new Train_Form();
            f.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(label1.Text);
            label1.Text="Emoji has been copyied.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var startTime = DateTime.UtcNow;
            label1.Text = "Move your head!";
            setTimer();


        }

        private  void setTimer() {
            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            setEmoji();
            aTimer.Stop();
            aTimer.Dispose();
        }

        private void setEmoji()
        {
            MotionLogger.Program x = new MotionLogger.Program();
            switch (x.getHeadRotation())
            {
                case "L":
                    this.SetText(":(");
                    break;
                case "R":
                    this.SetText(":)");
                    break;
                default:
                    this.SetText("Start again");
                    break;
            }
        }
        delegate void StringArgReturningVoidDelegate(string text);
        private void SetText(string text)
        {
            
            if (this.label1.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label1.Text = text;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
