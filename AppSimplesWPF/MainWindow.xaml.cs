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

namespace AppSimplesWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void btCalcular(object sender, RoutedEventArgs e)
        {
            double altura = double.Parse(txtAltura.Text);
            double peso = double.Parse(txtPeso.Text);
            double imc = peso / Math.Pow(altura, 2);

            tbkResultado.Text = ""+ imc;
            txtAltura.Clear();
            txtPeso.Clear();


            if (imc < 18.5)
            {
                tbkClassificacao.Text = "MAGREZA ";
            }

            if ((imc >= 18.5) && (imc <= 24.9))
            {
                tbkClassificacao.Text = "NORMAL ";

            }

            if ((imc >= 25) && (imc <= 24.9))
            {
                tbkClassificacao.Text = "SOBREPESO";
            }

            if ((imc >= 30) && (imc <= 39.9))
            {
                tbkClassificacao.Text = "OBESIDADE ";

            }

            if (imc > 40)
            {
                tbkClassificacao.Text = "OBESIDADE GRAVE";

            }
        }
    }
}
