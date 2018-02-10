using System.Windows;
using FontAwesome.WPF;

namespace _01_CSharp_Vasylenko
{
    public partial class CalculateAgeView : Window
    {
        private ImageAwesome _loader;
        public CalculateAgeView()
        {
            InitializeComponent();
            DataContext = new CalculateAgeViewModel(DisplayResult, ShowLoader);
        }
        private void DisplayResult()
        {
            string age = ((CalculateAgeViewModel)DataContext).Age;
            string wZodiac = ((CalculateAgeViewModel)DataContext).WesternSign;
            string cZodiac = ((CalculateAgeViewModel)DataContext).ChineseSign;
            ((CalculateAgeViewModel)DataContext).Age = "You are " + age + " years old";
            ((CalculateAgeViewModel)DataContext).WesternSign = "Your western zodiac sign is " + wZodiac;
            ((CalculateAgeViewModel)DataContext).ChineseSign = "Your chinese zodiac sign is " + cZodiac;
        }

        public void ShowLoader(bool isShow)
        {
            LoaderHelper.OnRequestLoader(Main, ref _loader, isShow);
        }
    }
}
