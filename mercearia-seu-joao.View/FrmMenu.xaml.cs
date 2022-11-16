using mercearia_seu_joao.Controller;
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
using System.Windows.Shapes;

namespace mercearia_seu_joao.View
{
    /// <summary>
    /// Lógica interna para FrmMenu.xaml
    /// </summary>
    public partial class FrmMenu : Window
    {
        
        public FrmMenu(string tipoUsuario)
        {
            InitializeComponent();

            if (tipoUsuario == "gerente")
            {
                btnGerente();
            }
            else
            {
                btnCaixa();
            }
        }

        private void click_btnProdutos(object sender, RoutedEventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
            Close();

        }

        private void click_btnUsuarios(object sender, RoutedEventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
            Close();
        }

        private void click_btnVenda(object sender, RoutedEventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.Show();
            Close();
        }

        private void click_btnSair(object sender, RoutedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();


        }

        private void btnGerente()
        {
            btnUsuarios.Visibility = Visibility.Visible;
            btnProdutos.Visibility = Visibility.Visible;
            btnEfetuarVenda.Visibility = Visibility.Visible;
            btnSair.Visibility = Visibility.Visible;    
        }

        private void btnCaixa()
        {
            btnEfetuarVenda.Visibility = Visibility.Visible;
            btnProdutos.Visibility = Visibility.Hidden;
            btnUsuarios.Visibility = Visibility.Hidden;
            btnSair.Visibility = Visibility.Visible;
        }






    }
}
