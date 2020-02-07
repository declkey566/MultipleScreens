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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.inputString = textBox1.Text;


            Form f = this.FindForm();
            f.Controls.Remove(this);

            SecondScreen ss = new SecondScreen();
            f.Controls.Add(ss);
        }
    }
}
