using EmployeetLib;
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

namespace EmployeetWPF
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

        private void generateIdBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            generatedId.Text = employeeManager.GetEmployeeId(firstnameBox.Text, lastnameBox.Text);
        }
    }
}
