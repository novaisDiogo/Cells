using Cell.Modelo;
using Cell.Paginas.Detalhe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cell.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.Add(new Funcionario { Nome = "Diogo", Cargo = "Presidente" });
            funcionarios.Add(new Funcionario { Nome = "Janaina", Cargo = "Gerente Vendas" });
            funcionarios.Add(new Funcionario { Nome = "Pamela", Cargo = "Gerente Financeira" });
            funcionarios.Add(new Funcionario { Nome = "Guilherme", Cargo = "Estagiario" });
            funcionarios.Add(new Funcionario { Nome = "Luciano", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = funcionarios;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario funcionario = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new DetailPage(funcionario));
        }
        private void FeriasAction(object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario funcionario = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: " + funcionario.Nome, "Mensagem: " + funcionario.Nome + " - " + funcionario.Cargo, "OK");
        }
        private void AbonoAction(object sender, EventArgs args)
        {
            
        }
    }
}