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
using imobiliaria;
namespace imobiliaria
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public string operacao;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            
            {
                cliente c = new cliente();
                //cadastro de cliente.
                c.nome_completo = txtNome.Text;
                c.cpf = txtCPF.Text;
                c.data_nascimento = dtanascimento.SelectedDate.Value.Date;
                c.sexo = radimasc.IsChecked == true ? "M" : "F";

                if (rbCliente.IsChecked == true)
                {
                    c.tipo_de_pessoa = "C";
                }
                else
                {
                    c.tipo_de_pessoa = "F";
                }

                c.login = txtusuario.Text;
                c.senha = txtsenha.Text;
                //gravando no banco de dados

                using (imobiliariaEntities1 ctx = new imobiliariaEntities1())
                {
                    
                    ctx.cliente.Add(c);
                    ctx.SaveChanges();

                }
               if (operacao == "alterar")
                {
                    // alterando cadastro de cliente.
                    c.nome_completo = txtNome.Text;
                    c.cpf = txtCPF.Text;
                    c.data_nascimento = dtanascimento.SelectedDate.Value.Date;
                    c.sexo = radimasc.IsChecked == true ? "M" : "F";

                    if (rbCliente.IsChecked == true)
                    {
                        c.tipo_de_pessoa = "C";
                    }
                    else
                    {
                        c.tipo_de_pessoa = "F";
                    }

                    c.login = txtusuario.Text;
                    c.senha = txtsenha.Text;
                }


            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Item da linha

            cliente c = new cliente();

            txtNome.Text = c.nome_completo;

            if (c.tipo_de_pessoa == "C")
            {
                rbCliente.IsChecked = true;
                rbFunc.IsChecked = false;
            }
            else
            {
                rbCliente.IsChecked = false;
                rbFunc.IsChecked = true;
            }
            
        }

        private void radiativo_Checked(object sender, RoutedEventArgs e)
        {
            var opcaoEscolhida = (RadioButton)sender;

        }

        private void True(object sender, RoutedEventArgs e)
        {

        }

        private void btnalterar_Click(object sender, RoutedEventArgs e)
        {
            operacao = "alterar";
        }

       
    }
}
