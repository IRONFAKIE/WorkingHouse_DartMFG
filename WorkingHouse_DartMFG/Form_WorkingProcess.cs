using System;
using System.Threading;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_WorkingProcess : Form
    {
        public int X = 0, Y = 0, Z = 0;
        private bool isWorking = false;

        public Form_WorkingProcess()
        {
            InitializeComponent();

            Request(ref X, ref Y, ref Z);
            timer1.Interval = 1000;
            timer1.Enabled = false;
            timer1.Tick += timer1_Tick;
            button_Working.MouseDown += Button_Working_MouseDown;
            this.FormClosing += Form_WorkingProcess_FormClosing;

            trackBar_Parametr1.Minimum = 0;
            trackBar_Parametr1.Maximum = 10;
            trackBar_Parametr2.Minimum = 0;
            trackBar_Parametr2.Maximum = 10;
            trackBar_Parametr3.Minimum = 0;
            trackBar_Parametr3.Maximum = 10;

            progressBar_WorkInProcess.Minimum = 0;
            progressBar_WorkInProcess.Maximum = 100;
            progressBar_WorkInProcess.Value = 0;
        }

        private void Form_WorkingProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            isWorking = false; // Останавливаем работу при закрытии формы
        }

        private void progressBar_WorkInProcess_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button_Working_Click(object sender, EventArgs e)
        {
            
        }

        public void Request(ref int X, ref int Y, ref int Z)
        {
            Random random = new Random();
            X = random.Next(10);
            Y = random.Next(10);
            Z = random.Next(10);
            label_Request.Text = $"Текущий заказ: {X} {Y} {Z}";
        }

        public void MadeInChina(int X, int Y, int Z)
        {
            if (trackBar_Parametr1.Value == X &&
                trackBar_Parametr2.Value == Y &&
                trackBar_Parametr3.Value == Z)
            {
                MessageBox.Show("Заказ сделан правильно!", "[TERMINAL-79]", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ошибка при выполнении заказа!", "[TERMINAL-79]", MessageBoxButtons.OK);
            }
        }

        private void Button_Working_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isWorking)
            {
                isWorking = true;
                progressBar_WorkInProcess.Value = 0;

                
                Thread workThread = new Thread(() =>
                {
                    while (isWorking && progressBar_WorkInProcess.Value < 100)
                    {
                        this.Invoke((MethodInvoker)delegate {
                            if (progressBar_WorkInProcess.Value <= 90)
                            {
                                progressBar_WorkInProcess.Value += 10;
                            }
                        });
                        Thread.Sleep(500);
                    }

                    this.Invoke((MethodInvoker)delegate {
                        if (progressBar_WorkInProcess.Value == 100)
                        {
                            MadeInChina(X, Y, Z);
                            this.Close();
                        }
                    });
                });

                workThread.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Таймер для дополнительной логики
        }
    }
}