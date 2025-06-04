using System.Threading.Tasks;

namespace MauiControls;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
		InitializeComponent();
	}

    private async void btnDemo1_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 2000);
        await DisplayAlert("Button", "Tarefa concluída", "OK");
    }

    private async void btnDemo2_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 2000);
        await DisplayAlert("Button", "Tarefa concluída", "OK");
    }

    private async void btnImgDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(500, 2000);
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);
        if (lblPets2 != null)
        {
            lblPets2.Text = $"Selecionou: {selectedRadioButton.Value}";
            lblPets2.FontSize = 20;
        }
    }

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        await DisplayAlert("Pesquisando...", $"{searchBar.Text}", "Ok");

    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Elemento tocado", "Ok");
    }
}