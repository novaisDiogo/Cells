using Cell.Modelo;
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
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
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

        private void FeriasAction(object sender, EventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario funcionario = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Ferias", "Funcionario: " + funcionario.Nome, "OK");
        }
    }
}