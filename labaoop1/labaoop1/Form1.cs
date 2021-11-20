using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaoop1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int tick = 30;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                int Height = ClientSize.Height;
                int Width = ClientSize.Width;
                this.BackColor = System.Drawing.Color.FromArgb((e.X * 255 / Width)%255, (e.Y * 255 / Height)%255, e.Y * 127 / Height + e.X * 127 / Width);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value= e.End;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::labaoop1.Properties.Resources.a01eb920157d569f0c214bc48ef1dec4;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            Pagetext.Text = "вы на странице 2";
            webBrowser1.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            Pagetext.Text = "вы на странице гайда";
        }

        private void indexlist_ValueChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex= (int)indexlist.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1) 
            { 
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 99) 
            { 
                panel1.Size = new System.Drawing.Size(panel1.Size.Width-tick, panel1.Size.Height-tick);
                tick = -tick;
                panel1.BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }else progressBar1.Value++;
            
        }

        private void timerstart_CheckedChanged(object sender, EventArgs e)
        {
          timer1.Enabled = true;
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Location = new System.Drawing.Point(random.Next(0,Width),random.Next(0,Height));
            btn.BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            this.Controls.Add(btn);
        }
    }
}
