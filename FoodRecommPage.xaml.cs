namespace MauiApp3;

public partial class FoodRecommPage : ContentPage
{
	public FoodRecommPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		string mytext = editor.Text;
		double mytextNum = double.Parse(mytext);

		if (mytextNum < 2000)
		{
			IntakeStatus.Text = "Intake Status: Underweight intake.";

			MealType.Text = "Meal type recommendation: A stable intake of Medium and Heavy Meals";

			var MealTypes = new List<CollectionFilipinoFood>
			{                
                new CollectionFilipinoFood {FoodName = "Medium Meals"},
                new CollectionFilipinoFood {FoodName = "Daing", CaloriePerServing = "199 kcal"},
                new CollectionFilipinoFood {FoodName = "Lugaw", CaloriePerServing = "181 kcal"},
                new CollectionFilipinoFood {FoodName = "Silog", CaloriePerServing = "215 kcal"},
                new CollectionFilipinoFood {FoodName = "Spaghetti", CaloriePerServing = "158 kcal"},
                new CollectionFilipinoFood {FoodName = "Taho", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Tapa", CaloriePerServing = "180 kcal"},
                new CollectionFilipinoFood {FoodName = "tocino", CaloriePerServing = "190kcal"},

                new CollectionFilipinoFood {FoodName = "Heavy Meals"},
                new CollectionFilipinoFood {FoodName = "Bicol Express", CaloriePerServing = "312kcal"},
                new CollectionFilipinoFood {FoodName = "Bulalo", CaloriePerServing = "374kcal"},
                new CollectionFilipinoFood {FoodName = "kare-kare", CaloriePerServing = "523kcal"},
                new CollectionFilipinoFood {FoodName = "Pancit Palabok", CaloriePerServing = "305 kcal"},
                new CollectionFilipinoFood {FoodName = "Pancit", CaloriePerServing = "341 kcal"}
            };
			MealTypeView.ItemsSource = MealTypes;
      
        }
		else if (mytextNum >= 2000 && mytextNum <= 2500)
		{
            IntakeStatus.Text = "Intake Status: Healthy intake.";

            MealType.Text = "Meal type recommendation: Stable intake of Light, Medium, and Heavy meals.";

            var MealTypes = new List<CollectionFilipinoFood>
            {
                new CollectionFilipinoFood {FoodName = "Light Meals"},
                new CollectionFilipinoFood {FoodName = "Biko", CaloriePerServing = "72 kcal"},
                new CollectionFilipinoFood {FoodName = "Champorado", CaloriePerServing = "113 kcal"},
                new CollectionFilipinoFood {FoodName = "Kanilaw", CaloriePerServing = "147 kcal"},
                new CollectionFilipinoFood {FoodName = "Kwek-Kwek", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Maruya", CaloriePerServing = "141 kcal"},
                new CollectionFilipinoFood {FoodName = "Pichi-Pichi", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Sorbetes", CaloriePerServing = "137 kcal"},

                new CollectionFilipinoFood {FoodName = "Medium Meals"},
                new CollectionFilipinoFood {FoodName = "Daing", CaloriePerServing = "199 kcal"},
                new CollectionFilipinoFood {FoodName = "Lugaw", CaloriePerServing = "181 kcal"},
                new CollectionFilipinoFood {FoodName = "Silog", CaloriePerServing = "215 kcal"},
                new CollectionFilipinoFood {FoodName = "Spaghetti", CaloriePerServing = "158 kcal"},
                new CollectionFilipinoFood {FoodName = "Taho", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Tapa", CaloriePerServing = "180 kcal"},
                new CollectionFilipinoFood {FoodName = "tocino", CaloriePerServing = "190kcal"},

                new CollectionFilipinoFood {FoodName = "Heavy Meals"},
                new CollectionFilipinoFood {FoodName = "Bicol Express", CaloriePerServing = "312kcal"},
                new CollectionFilipinoFood {FoodName = "Bulalo", CaloriePerServing = "374kcal"},
                new CollectionFilipinoFood {FoodName = "kare-kare", CaloriePerServing = "523kcal"},
                new CollectionFilipinoFood {FoodName = "Pancit Palabok", CaloriePerServing = "305 kcal"},
                new CollectionFilipinoFood {FoodName = "Pancit", CaloriePerServing = "341 kcal"}
            };
            MealTypeView.ItemsSource = MealTypes;
        }
		else if (mytextNum >= 2500 && mytextNum <= 4000)
		{
            IntakeStatus.Text = "Intake Status: Overweight intake.";

            MealType.Text = "Meal type recommendation: A stable intake of Light and Medium meals.";

            var MealTypes = new List<CollectionFilipinoFood>
            {
                new CollectionFilipinoFood {FoodName = "Light Meals"},
                new CollectionFilipinoFood {FoodName = "Biko", CaloriePerServing = "72 kcal"},
                new CollectionFilipinoFood {FoodName = "Champorado", CaloriePerServing = "113 kcal"},
                new CollectionFilipinoFood {FoodName = "Kanilaw", CaloriePerServing = "147 kcal"},
                new CollectionFilipinoFood {FoodName = "Kwek-Kwek", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Maruya", CaloriePerServing = "141 kcal"},
                new CollectionFilipinoFood {FoodName = "Pichi-Pichi", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Sorbetes", CaloriePerServing = "137 kcal"},

                new CollectionFilipinoFood {FoodName = "Medium Meals"},
                new CollectionFilipinoFood {FoodName = "Daing", CaloriePerServing = "199 kcal"},
                new CollectionFilipinoFood {FoodName = "Lugaw", CaloriePerServing = "181 kcal"},
                new CollectionFilipinoFood {FoodName = "Silog", CaloriePerServing = "215 kcal"},
                new CollectionFilipinoFood {FoodName = "Spaghetti", CaloriePerServing = "158 kcal"},
                new CollectionFilipinoFood {FoodName = "Taho", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Tapa", CaloriePerServing = "180 kcal"},
                new CollectionFilipinoFood {FoodName = "tocino", CaloriePerServing = "190kcal"}
            };
            MealTypeView.ItemsSource = MealTypes;
        }
		
		else if (mytextNum > 4000)
		{
            IntakeStatus.Text = "Intake Status: Obese intake.";

            MealType.Text = "Meal type recommendation: A stable intake of Light Meals.";

            var MealTypes = new List<CollectionFilipinoFood>
            {
                new CollectionFilipinoFood {FoodName = "Light Meals"},
                new CollectionFilipinoFood {FoodName = "Biko", CaloriePerServing = "72 kcal"},
                new CollectionFilipinoFood {FoodName = "Champorado", CaloriePerServing = "113 kcal"},
                new CollectionFilipinoFood {FoodName = "Kanilaw", CaloriePerServing = "147 kcal"},
                new CollectionFilipinoFood {FoodName = "Kwek-Kwek", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Maruya", CaloriePerServing = "141 kcal"},
                new CollectionFilipinoFood {FoodName = "Pichi-Pichi", CaloriePerServing = "150 kcal"},
                new CollectionFilipinoFood {FoodName = "Sorbetes", CaloriePerServing = "137 kcal"}
            };
            MealTypeView.ItemsSource = MealTypes;
        }

        SemanticScreenReader.Announce(IntakeStatus.Text);
        SemanticScreenReader.Announce(MealType.Text);
    }
}
