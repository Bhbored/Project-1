using System.Collections.ObjectModel;
using Project_1.MVVM.Model;
using Project_1.MVVM.ViewModel;
using PropertyChanged;

namespace Project_1.MVVM.View;
public partial class LPView : ContentPage
{
   
    public LPView()
	{
		InitializeComponent();
        BindingContext = new LPViewModel();
    }

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

}