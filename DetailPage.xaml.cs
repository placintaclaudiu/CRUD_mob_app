using CommunityToolkit.Mvvm.ComponentModel;
using CRUD_mob_app.ViewModels;
using System.Runtime.Intrinsics.Arm;

namespace CRUD_mob_app;


public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel dp)
	{
		InitializeComponent();
		BindingContext = dp;
    }
	
}