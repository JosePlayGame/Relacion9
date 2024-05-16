using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Ej;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    int desplazamiento;
    private void BtnEncriptar_Click(object? sender, RoutedEventArgs e){
        TbOriginal.Text ="Original:";
        TbDesencriptada.Text ="Desencriptada:";
        TbEncriptada.Text = "Encriptada:";
        if (int.TryParse(TbDesplazamiento.Text,out desplazamiento)==true){
            if (TbFrase.Text!= null)
            {
                TbOriginal.Text += " " + TbFrase.Text;
                TbEncriptada.Text += " "+ Encriptacion(TbFrase.Text,desplazamiento);
                TbDesencriptada.Text += " "+ TbFrase.Text;  
            }
        }
        else
            TbFrase.Text = "Desplazamiento invalido";
        
    }
    private string Encriptacion(string encriptar, int algo){
        string str = "";
        char caracter;
        for (int i = 0; i < encriptar.Length; i++)
        {
            caracter = encriptar[i];
            if (char.IsLower(caracter))
            {
                caracter = (char)('a' + (caracter - 'a' + algo) % 27);
            }
            else
            {
                caracter = (char)('A' + (caracter - 'A' + algo) % 27);
            }
            str += caracter;
        }
        return str;
    }
    private void BtnAumentar_Click(object? sender, RoutedEventArgs e){
        desplazamiento++;
        TbDesplazamiento.Text = $"{desplazamiento}";
    }
    private void BtnDisminuir_Click(object? sender, RoutedEventArgs e){
        if (desplazamiento!=0)
        {
            desplazamiento--;
            TbDesplazamiento.Text = $"{desplazamiento}";
        }
    }
}