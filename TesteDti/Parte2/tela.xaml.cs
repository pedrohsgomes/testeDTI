using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TesteDti.Parte2;

namespace TesteDti
{
    /// <summary>
    /// Interação lógica para tela.xam
    /// </summary>
    public partial class Tela : UserControl
    {
        private TelaViewModel viewModel;

        public Tela()
        {
            InitializeComponent();
            dados.ItemsSource = Dados.CarregarDados;
        }
    }
}
