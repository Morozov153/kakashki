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

namespace pro
{
    /// <summary>
    /// Логика взаимодействия для Pagemain.xaml
    /// </summary>
    public partial class Pagemain : Page
    {
        List<string> kolpar = new List<string>();
        public Pagemain()
        {
            InitializeComponent();
            kolpar.Add("1");
            kolpar.Add("2");
            kolpar.Add("3");
            kolpar.Add("4");
            kolpar.Add("5");
            Input.ItemsSource = kolpar;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = Input.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("И чо ты ничо не ввел? Давай говори скока пар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            int inputint = Convert.ToInt32(input);
            if (inputint >= 1 && inputint <= 5)
            {
                Random random = new Random();
                int para = random.Next(0, inputint + 1);
                string parast = Convert.ToString(para);
                if (para == 0)
                {
                    MessageBox.Show($"К большому сожалению завтра, комитетом ОАО 'Андерсерп', предпринято решение пойти на все пары :("
                    + "\n" + "\n" + "Передать всем участникам!", "ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (para == 1)
                {
                    parast = "первой";
                }
                if (para == 2)
                {
                    parast = "второй";
                }
                if (para == 3)
                {
                    parast = "третей";
                }
                if (para == 4)
                {
                    parast = "четвертой";
                }
                if (para == 5)
                {
                    parast = "пятой";
                }
                MessageBox.Show($"Завтра, комитетом ОАО 'Андерсерп', предпринято решение поехать за шаурмой на {para} паре (похуй+похуй)"
                    + "\n" + "\n" + "Передать всем участникам!", "ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show($"Да не может у тебя быть завтра стока пар, не неси хуйню"
                    + "\n" + "\n" + "Введи кол-во пар заново", "ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
