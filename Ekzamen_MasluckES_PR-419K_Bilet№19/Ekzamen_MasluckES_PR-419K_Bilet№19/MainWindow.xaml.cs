using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Ekzamen_MasluckES_PR_419K_Bilet_19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (fullNameTextBox.Text.Length < 10 || fullNameTextBox.Text.Length > 60)
            {
                MessageBox.Show("Некорректное значение поля \"Фио");
                return;
            }

            if (!Regex.IsMatch(emailTextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Некорректное значение поля \"Электронная почта");
                return;
            }

            Regex phoneRegex = new Regex(@"^\+\d{1}-\d{3}-\d{3}-\d{2}-\d{2}$");
            if (!phoneRegex.IsMatch(phoneTextBox.Text))
            {
                MessageBox.Show("Некорректное значение поля \"Номер телефона");
                return;
            }

            else
            {
                MessageBox.Show("Введенные данные корректны");
            }
        }
    }
}
