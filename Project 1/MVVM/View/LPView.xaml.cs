using System.Collections.ObjectModel;
using Project_1.MVVM.Model;
using Project_1.MVVM.Services;
using Project_1.MVVM.ViewModel;
using PropertyChanged;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.PullToRefresh;

namespace Project_1.MVVM.View;
public partial class LPView : ContentPage
{
   
    public LPView()
	{
		InitializeComponent();
        BindingContext = new LPViewModel();
    }

    #region Navigation Satck Debug
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }



    #endregion
    #region SearchBar
    private void OnFilterTextChanged(object sender, TextChangedEventArgs e)
    {
        searchBar = (sender as SearchBar);
        if (listView.DataSource != null)
        {
            this.listView.DataSource.Filter = FilterProducts;
            this.listView.DataSource.RefreshFilter();
        }
    }
    private bool FilterProducts(object obj)
    {
        if (searchBar == null || string.IsNullOrWhiteSpace(searchBar.Text))
            return true;

        var inventory = obj as LPModel;
        if (inventory == null || inventory.Products == null)
            return false;
        return inventory.Products.ToLower()
            .Contains(searchBar.Text.ToLower());
    }

    #endregion
    #region ListView logic -_-
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var category = sender as Label;
       if(category.Text == "Dairy")
        {
            listView.ItemsSource = ((LPViewModel)BindingContext).Dairy;
        }
        else if (category.Text == "Bakery")
        {
            listView.ItemsSource = ((LPViewModel)BindingContext).Bakery;
        }
        else if (category.Text == "Fruits")
        {
            listView.ItemsSource = ((LPViewModel)BindingContext).Fruits;
        }
        else if (category.Text == "Meat")
        {
            listView.ItemsSource = ((LPViewModel)BindingContext).Meat;
        }
        else if (category.Text == "Snacks")
        {
            listView.ItemsSource = ((LPViewModel)BindingContext).Snacks;
        }
    }


    #endregion


}