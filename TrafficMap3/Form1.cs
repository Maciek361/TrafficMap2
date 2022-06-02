using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace TrafficMap3
{
    public partial class Form1 : Form
    {
        PictureBox[] car2_ = new PictureBox[29];

        public Form1()
        {
            InitializeComponent();

            car2_[0] = car2_0;
            car2_[1] = car2_1;
            car2_[2] = car2_2;
            car2_[3] = car2_3;
            car2_[4] = car2_4;
            car2_[5] = car2_5;
            car2_[6] = car2_6;
            car2_[7] = car2_6;
            car2_[8] = car2_7;
            car2_[9] = car2_8;
            car2_[10] = car2_9;
            car2_[11] = car2_10;
            car2_[12] = car2_11;
            car2_[13] = car2_12;
            car2_[14] = car2_13;
            car2_[15] = car2_14;
            car2_[16] = car2_15;
            car2_[17] = car2_16;
            car2_[18] = car2_17;
            car2_[19] = car2_18;
            car2_[20] = car2_19;
            car2_[21] = car2_20;
            car2_[22] = car2_21;
            car2_[23] = car2_22;
            car2_[24] = car2_23;
            car2_[25] = car2_24;
            car2_[26] = car2_25;
            car2_[27] = car2_26;
            car2_[28] = car2_27;



            Thread thr1 = new Thread(auto_prawa_strona1);
            thr1.Start();
            Thread thr2 = new Thread(auto_prawa_strona2);
            thr2.Start();

        }

        public void auto_prawa_strona1()
        {
            for (; ; )
            {
                for (int i = 0; i < 29; i++)
                {

                    if (car2_[i] == car2_8 || car2_[i] == car2_9 || car2_[i] == car2_10 || car2_[i] == car2_11 || car2_[i] == car2_12 || car2_[i] == car2_13 || car2_[i] == car2_14 || car2_[i] == car2_15 || car2_[i] == car2_16 || car2_[i] == car2_17)
                    {
                        car2_[i].Image = Properties.Resources.car2Right;
                        Thread.Sleep(200);
                        car2_[i].Image = null;
                    }
                    else
                    {
                        car2_[i].Image = Properties.Resources.car2;
                        Thread.Sleep(200);
                        car2_[i].Image = null;
                    }

                }
            }
        }

        public void auto_prawa_strona2()
        {

            Random rand1 = new Random();
            int number1 = rand1.Next(2000, 5000);

            for (; ; )
            {

                Thread.Sleep(number1);

                for (int i = 0; i < 29; i++)
                {

                    if (car2_[i] == car2_9 || car2_[i] == car2_10 || car2_[i] == car2_11 || car2_[i] == car2_12 || car2_[i] == car2_13 || car2_[i] == car2_14 || car2_[i] == car2_15 || car2_[i] == car2_16 || car2_[i] == car2_17 || car2_[i] == car2_18)
                    {
                        car2_[i].Image = Properties.Resources.car3Right;
                        Thread.Sleep(400);
                        car2_[i].Image = null;
                    }
                    else
                    {
                        car2_[i].Image = Properties.Resources.car3;
                        Thread.Sleep(400);
                        car2_[i].Image = null;
                    }

                }


            }

        }



        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void car2_0_Click(object sender, EventArgs e)
        {

        }
    }
}
