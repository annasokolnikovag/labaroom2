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
using RoomLibrary;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Room room = new Room();
        LivingRoom livingroom = new LivingRoom();
        Office office = new Office();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            
            livingroom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingroom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingroom.NumWin = Convert.ToInt32(TBNumW.Text);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            ListRooms.Content += room.Info() + "\n";
            ListRooms.Content += livingroom.Info() + "\n";
            ListRooms.Content += office.Info();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            TBLengthR.Text = "";
            TBWidthR.Text = "";
            TBLengthL.Text = "";
            TBWidthL.Text = "";
            TBNumW.Text = "";
            TBLengthO.Text = "";
            TBWidthO.Text = "";
            TBNumS.Text = "";
        }
    }
}
