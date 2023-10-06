using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void AyudaNombre_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.Key == Key.F1) {
                if(ayudaNombre.Text == "") {
                    ayudaNombre.Text = "Nombre del cliente";
                    
                }
                 else if(ayudaNombre.Text == "Nombre del cliente") {
                    ayudaNombre.Text = "";
                }       
       
            }
            
                
        }

        private void AyudaApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (ayudaApellido.Text == "")
                {
                    ayudaApellido.Text = "Apellido del cliente";

                }
                else if (ayudaApellido.Text == "Apellido del cliente")
                {
                    ayudaApellido.Text = "";
                }

            }
        }

        private void validarEdad_KeyDown(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+?");

            if(e.Key == Key.F2)
            {
                if (!regex.IsMatch(recuadroEscrituraEdad.Text)) {
                    validarEdad.Text = "Edad Incorrecta";
                    validarEdad.Foreground = Brushes.Red;
                }
                else
                {
                    validarEdad.Text = "";
                }
            }
        }
    }
}
