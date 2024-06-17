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
using System.Windows.Shapes;

namespace Golovin.Nikita
{
    /// <summary>
    /// Логика взаимодействия для ProfilWindow.xaml
    /// </summary>
    public partial class ProfilWindow : Window
    {
        public ProfilWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GlavnayaWindow glavnayaWindow = new GlavnayaWindow();
            glavnayaWindow.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            IzbrWindow izbrWindow = new IzbrWindow();
            izbrWindow.Show();
            this.Close();
        }
        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            ObmenWindow obmenWindow = new ObmenWindow();
            obmenWindow.Show();
            this.Close();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow();
            chatWindow.Show();
            this.Close();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PredlozWindow predlozWindow = new PredlozWindow();
            predlozWindow.Show();
            this.Close();
        }
    }
}
