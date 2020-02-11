using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens
{
    public partial class FirstScreen : UserControl
    {
        public FirstScreen()
        {
            InitializeComponent();
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;


            label1.Text = ("Username:");
            label2.Text = ("Password:");
            label3.Text = ("Wrong Username. Try Again.");
            label3.BackColor = Color.Gray;
            label3.ForeColor = Color.Gray;

            button1.Text = ("Log In");
            BackColor = Color.Gray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.inputString = textBox1.Text;
            string userName = textBox1.Text;
            string PassWord = textBox2.Text;
           // textBox2.Text;

            if (Form1.name == userName && Form1.pass == PassWord)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                SecondScreen ss = new SecondScreen();
                f.Controls.Add(ss);

            }
            else //if (userName)
            {

               
                label3.ForeColor = Color.Black;
               // System.Threading.Thread.Sleep(1000);
               // label3.ForeColor = Color.Gray;





            }

            
        }
        
    }
}
