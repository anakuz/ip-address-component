using System;
using System.Net;
using System.Windows.Forms;

namespace Task4_3_IPControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            _myIpControl1.MyIpAddress = IPAddress.Parse("12.0.54.4");
        }
    }
}
