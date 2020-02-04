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
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.Add(new Funcionario { Nome = "Diogo", Cargo = "Presidente", Foto = "https://pt.seaicons.com/wp-content/uploads/2015/10/Person-Male-Light-icon.png" });
            funcionarios.Add(new Funcionario { Nome = "Janaina", Cargo = "Gerente Vendas", Foto= "https://pt.seaicons.com/wp-content/uploads/2015/10/Person-Female-Light-icon.png" });
            funcionarios.Add(new Funcionario { Nome = "Pamela", Cargo = "Gerente Financeira", Foto= "https://pt.seaicons.com/wp-content/uploads/2015/10/Person-Female-Light-icon.png" });
            funcionarios.Add(new Funcionario { Nome = "Guilherme", Cargo = "Estagiario", Foto= "https://pt.seaicons.com/wp-content/uploads/2015/10/Person-Male-Light-icon.png" });
            funcionarios.Add(new Funcionario { Nome = "Luciano", Cargo = "Vendedor", Foto= "https://pt.seaicons.com/wp-content/uploads/2015/10/Person-Male-Light-icon.png" });

            ListaFuncionario.ItemsSource = funcionarios;
        }
    }
}