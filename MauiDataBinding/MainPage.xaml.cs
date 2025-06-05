using MauiDataBinding.Models;

namespace MauiDataBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //    private void OnCounterClicked(object? sender, EventArgs e)
        //    {
        //        //count++;

        //        //if (count == 1)
        //        //    CounterBtn.Text = $"Clicked {count} time";
        //        //else
        //        //    CounterBtn.Text = $"Clicked {count} times";

        //        //SemanticScreenReader.Announce(CounterBtn.Text);

        //        var produto = new Produto
        //        {
        //            Nome = "Iphone 5",
        //            Preco = 5000.00m,
        //            Stock = 10
        //        };

        //        //Binding produtoBinding = new Binding();
        //        //produtoBinding.Source = produto;
        //        //produtoBinding.Path = "Nome";

        //        Binding nomeBinding = new Binding
        //        {
        //            Source = produto,
        //            Path = "Nome",
        //            StringFormat = "Produto: {0}" 
        //        };
        //        lblNome.SetBinding(Label.TextProperty, nomeBinding);

        //        //lblNome.SetBinding(Label.TextProperty, produtoBinding);

        //        Binding precoBinding = new Binding
        //        {
        //            Source = produto,
        //            Path = "Preco",
        //            StringFormat = "Preço: {0}"
        //        };
        //        lblPreco.SetBinding(Label.TextProperty, precoBinding);

        //        Binding stockBinding = new Binding
        //        {
        //            Source = produto,
        //            Path = "Stock",
        //            StringFormat = "Stock: {0}"
        //        };
        //        lblStock.SetBinding(Label.TextProperty, stockBinding);
        //    }
        //}
    }
}
