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
    /// Логика взаимодействия для ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        public ChatWindow()
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

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            ObmenWindow obmenWindow = new ObmenWindow();
            obmenWindow.Show();
            this.Close();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            ProfilWindow profilWindow = new ProfilWindow();
            profilWindow.Show();
            this.Close();
        }
    }
}
