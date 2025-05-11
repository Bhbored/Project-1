using Project_1.MVVM.Services;
using Project_1.MVVM.ViewModel;

namespace Project_1.MVVM.View;

public partial class Examples : ContentPage
{
	public Examples()
	{
		InitializeComponent();
        BindingContext = new LPViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Button category && BindingContext is LPViewModel viewModel)
        {
            switch (category.Text)
            {
                case "Dairy":
                    CollectionView.ItemsSource = viewModel.Dairy;
                    break;
                case "Bakery":
                    CollectionView.ItemsSource = viewModel.Bakery;
                    break;
                case "Fruits":
                    CollectionView.ItemsSource = viewModel.Fruits;
                    break;
                case "Meat":
                    CollectionView.ItemsSource = viewModel.Meat;
                    break;
                case "Snacks":
                    CollectionView.ItemsSource = viewModel.Snacks;
                    break;
                default:                 
                    break;
            }
        }
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
       ////need to figure it out

    }
}