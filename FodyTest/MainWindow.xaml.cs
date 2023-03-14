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

namespace FodyTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Data dt = new Data()
        {
            Name = "dd",
            Age = 12,
        };
        public MainWindow()
        {
            InitializeComponent();
           
            DataContext = dt;
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
             dt.Name= "xx";
       
        }
    }
}
