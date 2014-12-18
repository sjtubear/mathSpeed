using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace mathSpeed
{
    public partial class mathSpeed : Form
    {
        private Random rd = new Random();
        private Random operation = new Random();
        //private Random lower = new Random();

        private record recClass = null;

        //the upper and lower bound of operation numbers.
        private int upper;
        private int lower;
        //store the answer
        private int answer;
        //the first and second operations
        private int firstOper;
        private int secOper;
        // time countDown
        private int count;
        // wintimes
        private int winCount;
        // opreration type,0 for +,1 for -. 2 for * 3 for /
        private int op;
        // time-limit
        private int timeLimit;
        // Record
        private int recordcount = 0;

        public mathSpeed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winCount = 0;

            count = timeLimit;
            showMath();
            butStart.Enabled = false;
            butStart.Text = count.ToString();
            tiCount.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mathSpeed_Load(object sender, EventArgs e)
        {
            timeLimit = 6;
            count = timeLimit;
            upper = 10;
            lower = 1;
            winCount = 0;
            if(File.Exists("record.cfg"))
            {
                using(FileStream fs = new FileStream("record.cfg",FileMode.Open))
                {
                    IFormatter ft = new BinaryFormatter();
                    recClass = ft.Deserialize(fs) as record;
                    recordcount = recClass.userRecord;
                }
            }
            lblRecord.Text = recordcount.ToString();
        }

        private void showMath()
        {
            firstOper = rd.Next(lower, upper);
            secOper = rd.Next(lower, upper);
            op = operation.Next(0, 3);
            label1.Text = winCount.ToString();
            switch (op)
            {
                case 0:
                    {
                        answer = firstOper + secOper;
                        lblTest.Text = firstOper.ToString() + '+' + secOper.ToString() + '=';
                        break;
                    }
                case 1:
                    {
                        answer = firstOper - secOper;
                        lblTest.Text = firstOper.ToString() + '-' + secOper.ToString() + '=';
                        break;
                    }
                case 2:
                    {
                        answer = firstOper * secOper;
                        lblTest.Text = firstOper.ToString() + '*' + secOper.ToString() + '=';
                        break;
                    }
                default: break;
            }
        }
   
        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(tbAnswer.Text == answer.ToString())
                {
                    winCount++;
                    lblInstru.Text = "";
                    if(winCount % 5 == 0)
                    {
                        if (timeLimit > 2)
                        {
                            timeLimit--;
                            lblInstru.ForeColor = System.Drawing.Color.Red;
                            lblInstru.Text ="加速!";
                        }
                        timeLimit = (timeLimit > 2) ? timeLimit : 2;
                    }
                    if(winCount % 20 == 0)
                    {
                        lblInstru.ForeColor = System.Drawing.Color.Green;
                        lblInstru.Text = "变难咯！";
                        timeLimit = 6;
                        upper+=5;
                    }
                    count = timeLimit;
                    butStart.Text = count.ToString();
                    showMath();
                    tbAnswer.Text = "";
                    tiCount.Stop();
                    tiCount.Start();
                }
                else
                {
                    tiCount.Stop();
                    MessageBox.Show("LOOSE!");
                    butStart.Enabled = true;
                    butStart.Text = "START";
                    if(winCount > recordcount)
                    {
                        recordcount = winCount;
                    }
                    lblRecord.Text = recordcount.ToString();
                    timeLimit = 6;
                }
            }
        }

        private void tiCount_Tick(object sender, EventArgs e)
        {
            count--;
            butStart.Text = count.ToString();
            if(count == 0)
            {
                tiCount.Stop();
                if (winCount > recordcount)
                {
                    recordcount = winCount;
                }
                MessageBox.Show("Time is up~~");
                butStart.Enabled = true;
                butStart.Text = "START";
                lblRecord.Text = recordcount.ToString();
                timeLimit = 6;
            }
        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void mathSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            recClass = new record();
            recClass.userRecord = recordcount;
            using (FileStream fs = new FileStream("record.cfg",FileMode.Create))
            {
                IFormatter ft = new BinaryFormatter();
                ft.Serialize(fs, recClass);
            }
        }

        private void lblRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
