using CRUD_mob_app.ViewModels;

namespace CRUD_mob_app;

public partial class Car : ContentPage
{
	public Car(CarViewModel car)
	{
		InitializeComponent();
		BindingContext = car;
	}
}