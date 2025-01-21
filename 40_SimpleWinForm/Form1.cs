using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40_SimpleWinForm
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            //this.myButton.Click += this.ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.myTextBox.Text = "Hello, World!";
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            this.myTextBox.Text = "Hello, Formssss!";
        }
    }
}
