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

namespace CheckTimePicker2.UserControls
{
    /// <summary>
    /// Interaction logic for CustomPopup.xaml
    /// </summary>
    public partial class CustomPopup : UserControl
    {
        public int[] hours = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        public int[] minutes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23,
            24,25,26,27,28,29,30,31,32,33,34,35,46,47,48,49,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59
        };

        public event EventHandler OkClicked;
        public event EventHandler CancelClicked;

        public static readonly DependencyProperty HourProperty =
            DependencyProperty.Register(nameof(Hour), typeof(int), typeof(CustomPopup), new PropertyMetadata(0));
        public static readonly DependencyProperty MinuteProperty =
            DependencyProperty.Register(nameof(Minute), typeof(int), typeof(CustomPopup), new PropertyMetadata(0));
        public int Hour 
        { 
            get => (int)GetValue(HourProperty);
            set => SetValue(HourProperty, value);
        }
        public int Minute
        {
            get => (int)GetValue(MinuteProperty);
            set => SetValue(MinuteProperty, value);
        }
        public CustomPopup()
        {
            InitializeComponent();

            HourOptions.ItemsSource = hours;
            MinuteOptions.ItemsSource = minutes;

            DataContext = this;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            OkClicked?.Invoke(this, e);
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            CancelClicked?.Invoke(this, e);
        }
    }
}
