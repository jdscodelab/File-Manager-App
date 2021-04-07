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
    /// Interaction logic for CRow.xaml
    /// </summary>
    public partial class CRow : UserControl
    {
        public CRow()
        {
            InitializeComponent();
        }



        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(CRow));



        public string DocName
        {
            get { return (string)GetValue(DocNameProperty); }
            set { SetValue(DocNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DocName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DocNameProperty =
            DependencyProperty.Register("DocName", typeof(string), typeof(CRow));



        public string FileSize
        {
            get { return (string)GetValue(FileSizeProperty); }
            set { SetValue(FileSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FileSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileSizeProperty =
            DependencyProperty.Register("FileSize", typeof(string), typeof(CRow));



        public string LastEdit
        {
            get { return (string)GetValue(LastEditProperty); }
            set { SetValue(LastEditProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastEdit.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastEditProperty =
            DependencyProperty.Register("LastEdit", typeof(string), typeof(CRow));


    }
}
