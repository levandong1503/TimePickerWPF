using CheckTimePicker2.UserControls;
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

namespace CheckTimePicker2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Hour { set;get; }
        public int Minute { set;get; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ShowMessage_Click(object sender, RoutedEventArgs e)
        {
            contentPopup.Hour = Hour;
            contentPopup.Minute = Minute;
            if (!popup.IsOpen)
                popup.IsOpen = true;
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);

            if (popup.IsOpen && !IsMouseOverPopup(e))
                popup.IsOpen = false;
        }

        private bool IsMouseOverPopup(MouseButtonEventArgs e)
        {
            var popupPosition = popup.PointToScreen(new Point(0, 0));
            var popupRect = new Rect(popupPosition.X, popupPosition.Y, popup.ActualWidth, popup.ActualHeight);
            return popupRect.Contains(e.GetPosition(this));
        }

        private void contentPopup_OkClicked(object sender, EventArgs e)
        {
            Hour = contentPopup.Hour; Minute = contentPopup.Minute;
            Time.Text = $"{Hour}:{Minute}";
            popup.IsOpen = false;
        }

        private void contentPopup_CancelClicked(object sender, EventArgs e)
        {
            popup.IsOpen = false;
        }
    }
}
