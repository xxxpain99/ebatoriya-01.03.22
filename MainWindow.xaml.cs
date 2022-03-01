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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int totalPageCount = 0;
        private int currentPageCount = 0;
        public sql.user_10Entities connectdb = new sql.user_10Entities();
        public MainWindow()
        {
            InitializeComponent();
            var ml = connectdb.Material.ToList(); 
            foreach(var m in ml)
            {
                Border border = new Border();
                border.Margin = new Thickness(20, 10, 20, 10);
                border.BorderThickness = new Thickness(1);
                border.BorderBrush = Brushes.Black;

                StackPanel stack1 = new StackPanel();
                stack1.Orientation=Orientation.Horizontal;
                stack1.Margin = new Thickness(10);

                Label label = new Label();
                label.Content = "Остаток" + a.Count + "  " + a.Unit;
                label.FontSize = 18;

                
                MaterialList.Children.Add(border);
                border.Child = stack1;

                stack1.Children.Add(label);

                Image image = new Image();
                image.Width = 140;
                image.Margin = new Thickness(0, 0, 10, 0);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                if (material.Image == null)
                {
                    bitmap.UriSource = new Url("/material/picture.png", UrlKind.Relative);
                }
                else
                {
                    bitmap.UriSource = new Url(material.Image, UrlKind.Relative);
                }

                bitmap.EndInit();
                ImageSource=bitmap;

                stack1.Children.Add(image);
                stack1.Children.Add(label);
                border.Child = stack1;
                MaterialList.Children.Add(border);

            }

        }
    }
}
