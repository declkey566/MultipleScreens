using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens
{
    public partial class Form1 : Form
    {
        public static string inputString;

        public Form1()
        {
            InitializeComponent();
            FirstScreen fs = new FirstScreen();
            this.Controls.Add(fs);
        }
    }
}
