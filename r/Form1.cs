using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace r
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch1 = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();
        Stopwatch stopwatch3 = new Stopwatch();
        int turn = -1;
        int p;
        Button[] btns;
        int[] Stage1;
        int[] Stage2;
        int[] Stage3;
        int[] Stage4;
        int[] Stage5;
        int[] Stage6;
        int[] queue;
        int[] arrival;
        Random rnd = new Random();
  
       

        public Form1()
        {
            InitializeComponent();
            btns = new Button[] { b1, b2, b3 };
            Stage1 = new int[] { 0, 0, 1 };
            Stage2 = new int[] { 0, 1, 1 };
            Stage3 = new int[] { 1, 1, 1 };
            Stage4 = new int[] { 0, 1, 0 };
            Stage5 = new int[] { 1, 0, 1 };
            Stage6 = new int[] { 1, 1, 0 };

            arrival=new int []{5,5,5};

            queue = new int[] { 0, 1, 2 };
        }
        void LightGlow(int[] arr)
        {
            queuemtd();
            stopwatch1.Stop(); stopwatch2.Stop(); stopwatch3.Stop();
           // MessageBox.Show(stopwatch3.Elapsed.Seconds.ToString());
            txtb1.Text = stopwatch1.Elapsed.Seconds.ToString();
            txtb2.Text = stopwatch2.Elapsed.Seconds.ToString();
            txtb3.Text = stopwatch3.Elapsed.Seconds.ToString();
            queue[0] = (queue[0] - (stopwatch1.Elapsed.Seconds/2));
            queue[1] = (queue[1] - (stopwatch2.Elapsed.Seconds/2));
            queue[2] = (queue[2] - (stopwatch3.Elapsed.Seconds/2));

            stopwatch1.Reset();
            stopwatch2.Reset();
            stopwatch3.Reset();

            for (int i = 0; i < 3; i++)
            {
                

                if (arr[i] == 1)
                {
                   // stopwatch1.Reset();
                   if (i == 0) { stopwatch1.Start();}
                   else if (i == 1) { stopwatch2.Start(); }
                   else { stopwatch3.Start(); }


                    btns[i].BackColor = Color.Green;
                  // queue[i] = queue[i] - 2;  
                }   
                else
                {
                    btns[i].BackColor = Color.Red;                
                }
               
                btns[i].Text = queue[i].ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            turn = turn + 1;
            p = (turn % 6) + 1;
            s.Text = p.ToString();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void s_TextChanged_1(object sender, EventArgs e)
        {
            switch (p)
            {
                case 1: LightGlow(Stage1); break;
                case 2: LightGlow(Stage2); break;
                case 3: LightGlow(Stage3); break;
                case 4: LightGlow(Stage4); break;
                case 5: LightGlow(Stage5); break;
                case 6: LightGlow(Stage6); break;
                default: break;
            }
        }
        

        public void timer2_Tick(object sender, EventArgs e)
        {
           
        }
        
        public void queuemtd()
        {

            for (int i = 0; i < 3; i++)
            {
               // int n = rnd.Next(1, 3);
                queue[i] = (queue[i] + 3);
                // MessageBox.Show(queue[i].ToString() + "sd  " + i.ToString());
                if (queue[i] > 10)
                {
                    queue[i] = 10;
                }
                btns[i].Text = queue[i].ToString();
                //MessageBox.Show(queue[i].ToString() + "sd  " + i.ToString());
                if (queue[i] == 0)
                {
                    arrival[i] = 0;
                }
                else
                    if (btns[i].BackColor == Color.Green)
                    {
                        arrival[i] = 0;
                    }
                    else
                    {
                        arrival[i] = 1;
                    }
               // MessageBox.Show(queue[i].ToString() + arrival[i].ToString());
            }
        }

        private void s_Click(object sender, EventArgs e)
        {

        }

       
    }
}
