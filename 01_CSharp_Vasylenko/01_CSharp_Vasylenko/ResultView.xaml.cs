using System.Windows;
using System.Windows.Controls;

namespace _01_CSharp_Vasylenko
{
    /// <summary>
    /// Логика взаимодействия для ResultView.xaml
    /// </summary>
    public partial class ResultView : UserControl
    {
        public ResultView()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty PropertyAgeProperty = DependencyProperty.Register
        (
            "PropertyAge",
            typeof(string),
            typeof(ResultView),
            new PropertyMetadata(string.Empty)
        );

        public static readonly DependencyProperty PropertyWestProperty = DependencyProperty.Register
        (
            "PropertyWest",
            typeof(string),
            typeof(ResultView),
            new PropertyMetadata(string.Empty)
        );

        public static readonly DependencyProperty PropertyChinaProperty = DependencyProperty.Register
        (
            "PropertyChina",
            typeof(string),
            typeof(ResultView),
            new PropertyMetadata(string.Empty)
        );
        public string PropertyAge
        {
            get { return (string)GetValue(PropertyAgeProperty); }
            set { SetValue(PropertyAgeProperty, value); }
        }

        public string PropertyWest
        {
            get { return (string)GetValue(PropertyWestProperty); }
            set { SetValue(PropertyWestProperty, value); }
        }

        public string PropertyChina
        {
            get { return (string)GetValue(PropertyChinaProperty); }
            set { SetValue(PropertyChinaProperty, value); }
        }
    }
}
