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

namespace City
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

        private void cbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int itemIndex = cbCity.SelectedIndex;
            BitmapImage image = new BitmapImage();

            switch (itemIndex)
            {
                case 0:
                    image.BeginInit();
                    image.UriSource = new Uri("C:/Users/Кирилл/Desktop/City/Ресурсы/амстердам.jpg");
                    image.EndInit();
                    imageBox.Source = image;
                    break;
                case 1:
                    image.BeginInit();
                    image.UriSource = new Uri("C:/Users/Кирилл/Desktop/City/Ресурсы/москва.jpg");
                    image.EndInit();
                    imageBox.Source = image;
                    break;
                case 2:
                    image.BeginInit();
                    image.UriSource = new Uri("C:/Users/Кирилл/Desktop/City/Ресурсы/адлер.jpg");
                    image.EndInit();
                    imageBox.Source = image;
                    break;
                case 3:
                    image.BeginInit();
                    image.UriSource = new Uri("C:/Users/Кирилл/Desktop/City/Ресурсы/екатеринбург.jpg");
                    image.EndInit();
                    imageBox.Source = image;
                    break;
            }
        }

    }
}
