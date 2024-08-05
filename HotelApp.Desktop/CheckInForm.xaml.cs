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
using HotelAppLibrary.Data;
using HotelAppLibrary.Models;

namespace HotelApp.Desktop
{
    /// <summary>
    /// Interaction logic for CheckInForm.xaml
    /// </summary>
    public partial class CheckInForm : Window
    {
        private BookingFullModel _info = null;
        private readonly IDatabaseData _db;

        public CheckInForm(IDatabaseData db)
        {
            InitializeComponent();
            _db = db;
        }

        public void PopulateCheckInInfo(BookingFullModel info)
        {
            _info = info;
            firstNameText.Text = _info.FirstName;
            lastNameText.Text = _info.LastName;
            titleText.Text = _info.Title;
            roomNumberText.Text = _info.RoomNumber;
            totalCostText.Text = string.Format("{0:C}", _info.TotalCost);
        }

        private void CheckInUser_Click(object sender, RoutedEventArgs e)
        {
            _db.CheckInGuest(_info.Id);
            this.Close();
        }
    }
}
