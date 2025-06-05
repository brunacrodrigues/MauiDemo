using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiDataBinding.Models
{
    public class Produto : INotifyPropertyChanged
    {
        private string _nome;
        private decimal _preco;
        private int _stock;

        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged();
            } 
        }

        public decimal Preco
        {
            get => _preco;
            set
            {
                _preco = value;
                OnPropertyChanged();
            }
        }


        public int Stock
        {
            get => _stock;
            set
            {
                _stock = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
