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

namespace mercearia_seu_joao.View
{
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FazerLogin(object sender, RoutedEventArgs e)
        {
            if (VerificarCampos() == true)
            {
                string email = txtEmail.Text;
                string senha = txtSenha.Password;

                Usuario usuario = cUsuario.ObterUsuarioPeloEmailSenha(email, senha);
                if (usuario != null)
                {
                   //AbrirTelaMenu();
                }

                else
                {
                    MessageBoxResult result = MessageBox.Show(
                        "Email ou senha incorretos!",
                        "Atenção",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning
                    );
                }

            }
        }

        private bool VerificarCampos()
        {
            if (txtEmail.Text != "" && txtSenha.Password != "")
            {
                return true;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                    "Preencha todos os campos",
                    "Atenção",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            return false;
        }
        private void AbrirTelaMenu()
        {
            //FrmMenu frmMenu = new FrmMenu();
           // frmMenu.Show();
          //  Close();
        }

        private void EsqueceuSenha(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Por gentileza, contate seu gerente.",
                            "Informação",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }
    }
}
