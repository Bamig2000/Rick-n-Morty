using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2__BBF_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label6.Text = Form1.playername;
        }

        Random R = new Random();
        Random bombrnd = new Random();
        Random picture_box = new Random();
        int counter = 0;
        int score = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_choice2;
            pictureBox1.Location = new Point(419, 163);
            pictureBox1.Visible = true;


            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                timer1.Start();
                counter = 30;

            }
            else if (checkBox2.Checked == true)
            {
                timer1.Start();
                counter = 20;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;

            }
            else if (checkBox3.Checked == true)
            {

                this.BackgroundImage = Properties.Resources.confusing_background2;
                timer1.Start();
                counter = 15;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {

                MessageBox.Show("Please choose difficulty");
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label4.Text = counter.ToString();
            counter--;


            if ((checkBox1.Checked == true)&&(counter == 0))
            {
                timer1.Stop();
                pictureBox1.Visible = false;
                this.BackgroundImage = Properties.Resources.background_choice4;
                label7.Text = "Game Over! \n Your score is: " + label5.Text;
                label7.Location = new Point(369,190);
                button3.Location = new Point(392, 368);
                label7.Visible = true;
                button3.Visible = true;
                score = 0;
            }

            else if(checkBox2.Checked == true)

            {

                if (counter == 0)
                {
                    timer1.Stop();
                    pictureBox1.Visible = false;
                    this.BackgroundImage = Properties.Resources.background_choice4;
                    label7.Text = "Game Over! \n Your score is:" + label5.Text;
                    label7.Visible = true;
                    button3.Visible = true;
                    score = 0;

                }

                if (counter == 10)
                {
                    this.BackgroundImage = Properties.Resources.confusing_background;
                    this.Size = new System.Drawing.Size(955, 620);
                    groupBox2.Size = new Size(92, 370);
                    pictureBox1.Image = Properties.Resources.pngkey_com_faces_png_2290507;
                    pictureBox1.Size = new Size(80, 80);
                }
            }
            else if (checkBox3.Checked==true)
            {
                this.Size = new Size(1159, 620);
                pictureBox1.Size = new Size(80, 80);
                groupBox2.Size = new Size(92, 370);
                int pnew = picture_box.Next(104, 1061);
                int py = picture_box.Next(0, 494);
                pictureBox1.Location = new Point(pnew, py);

                if (counter == 0)
                {
                    timer1.Stop();
                    pictureBox1.Visible = false;
                    this.BackgroundImage = Properties.Resources.background_choice4;
                    label7.Text = "Game Over! \n Your score is:" + label5.Text;
                    label7.Location = new Point(471,267);
                    button3.Location = new Point(493,472);
                    label7.Visible = true;
                    button3.Visible = true;
                    score = 0;
                  

                }


            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label5.Text = score.ToString();
            int x = R.Next(104, 882);
            int y = R.Next(0, 312);
            pictureBox1.Location = new Point(x, y);
            score++;

            if ((checkBox2.Checked == true) && (counter == 10))
            {
                int xx = R.Next(104, 858);
                int yy = R.Next(0, 494);
                pictureBox1.Location = new Point(xx, yy);

            }


            else if ((checkBox3.Checked == true) && (counter == 5))
            {
                int xxx = R.Next(104, 1061);
                int yyy = R.Next(0, 494);
                pictureBox1.Location = new Point(xxx, yyy);
            }


        }

        


        

        private void button3_Click(object sender, EventArgs e)
        {

            this.Size = new Size(955, 465);
            groupBox2.Size = new Size(92, 197);
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            button2.Enabled = true;
            this.BackgroundImage = Properties.Resources.background_choice2;
            label7.Visible = false;
          
            button3.Visible = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
