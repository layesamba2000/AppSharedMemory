using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSharedMemory
{
    public partial class Form1 : Form
    {
        ServiceMetier.Service1Client servise;
        public Form1()
        {
            servise = new ServiceMetier.Service1Client();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
