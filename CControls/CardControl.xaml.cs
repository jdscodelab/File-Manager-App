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

namespace FileManagerApp.CControls
{
    /// <summary>
    /// Interaction logic for CardControl.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }



        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(Uri), typeof(CardControl));




        public string DriveName
        {
            get { return (string)GetValue(DriveNameProperty); }
            set { SetValue(DriveNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DriveName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DriveNameProperty =
            DependencyProperty.Register("DriveName", typeof(string), typeof(CardControl));



        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(CardControl));



        public string LastChange
        {
            get { return (string)GetValue(LastChangeProperty); }
            set { SetValue(LastChangeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastChange.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastChangeProperty =
            DependencyProperty.Register("LastChange", typeof(string), typeof(CardControl));


    }
}
