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
    public partial class SecondScreen : UserControl
    {
        public SecondScreen()
        {
            InitializeComponent();
            label1.Text = "Welcome back Declan!";
            
        }
    }
}
