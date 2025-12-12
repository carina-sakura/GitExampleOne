using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        private int clickCounter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCounter_Click(object sender, EventArgs e)
        {

            clickCounter++;
            lblAnzahlClicker.Text = $"Clicks: {clickCounter}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClick(object sender, EventArgs e)
        {

        }
    }
}
