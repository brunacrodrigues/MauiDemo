using MauiDataBinding.Models;

namespace MauiDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
	Produto produto = new Produto();

	public NotifyBinding()
	{
		InitializeComponent();
		produto = new Produto
		{
			Nome = "Iphone 5",
			Preco = 5000.00m,
			Stock = 5
		};

		BindingContext = produto;
    }

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
		produto.Nome = "Galaxy Samsung 10";
		produto.Preco = 6000.00m;
		produto.Stock = 3;

		await DisplayAlert("Produto Atualizado", $"{produto.Nome} - {produto.Preco} - {produto.Stock}", "OK");
    }
}