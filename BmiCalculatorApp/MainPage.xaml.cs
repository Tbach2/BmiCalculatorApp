using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BmiCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            int weight = Int32.Parse(Weight.Text);
            int height = Int32.Parse(Height.Text);
            int bmi = (weight * 703) / (height * height);
            TheLabel.Text = $"Your BMI is {bmi}.";
        }
    }
}
