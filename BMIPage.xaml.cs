namespace MauiApp3;

public partial class BMIPage : ContentPage
{
	public BMIPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string mytext = editor.Text;
        float mytextNum = float.Parse(mytext);

        string mytext1 = editor1.Text;
        float mytextNum1 = float.Parse(mytext1);

        double calculatedValue = mytextNum1 / Math.Pow(mytextNum, 2);
        double roundedCaculatedValue = Math.Round(calculatedValue, 2);
        string caculatedValueRev = Convert.ToString(roundedCaculatedValue);

        DisplayValue.Text = $"BMI: {caculatedValueRev}";

        SemanticScreenReader.Announce(DisplayValue.Text);

        double BMIValue = roundedCaculatedValue;
        if (BMIValue < 18.5)
        {
            WeightStatus.Text = "Weight Status: Underweight";
        }
        else if (BMIValue > 18.5 && BMIValue < 24.9)
        {
            WeightStatus.Text = "Weight Status: Healty Weight";
        }
        else if (BMIValue > 25.0 && BMIValue < 29.9)
        {
            WeightStatus.Text = "Weight Status: Overweight";
        }
        else if (BMIValue > 30.0)
        {
            WeightStatus.Text = "Weight Status: Obesity";
        }

        SemanticScreenReader.Announce(WeightStatus.Text);

    }
}