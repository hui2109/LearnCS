using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_EventSourceIsAField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.ShowDialog();
        }
    }

    class MyForm : Form
    {
        private TextBox textBox;  // 声明字段在构造函数外
        private Button button;  // 声明字段在构造函数外

        public MyForm()
        {
            this.textBox = new TextBox();  // 赋值变量在构造函数内
            this.button = new Button();  // 赋值变量在构造函数内
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);

            this.button.Click += this.ButtonClicked;
            this.button.Text = "Say Hello";
            this.button.Top = 100;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello, World!!";
        }
    }
}
