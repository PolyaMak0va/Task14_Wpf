using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task14_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();

            products =  new ObservableCollection<Product>();

            products.Add(new Product()
            {
                ProductName = "Бананы",
                Price = 60,
                ImagePath = "Data/bananas.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Миксер",
                Price = 10000,
                ImagePath = "Data/mixer.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Кофеварка",
                Price = 50000,
                ImagePath = "Data/dripper.jpg",

                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Мороженое",
                Price = 100,
                ImagePath = "Data/icecream.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Сыры фермерские",
                Price = 1500,
                ImagePath = "Data/cheese.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Фен",
                Price = 20000,
                ImagePath = "Data/hair_dryer.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Магнитофон",
                Price = 5000,
                ImagePath = "Data/cd_player.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                Price = 100,
                ImagePath = "Data/milk.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                Price = 1500,
                ImagePath = "Data/owen.jpg",
                ProductCategory = ProductCategories.Appliances
            });
        }
    }
}
