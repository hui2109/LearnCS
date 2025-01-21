using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _41_SimpleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllButtonsClicked(object sender, RoutedEventArgs e)  // 多个事件挂接一个事件处理器
        {
            if (sender == this.button1)
            {
                this.myTB.Text = "Hello";
            }

            if (sender == this.button2)
            {
                this.myTB.Text = "World";
            }

            if (sender == this.button3)
            {
                this.myTB.Text = "WPF!";
            }
        }
    }
}
