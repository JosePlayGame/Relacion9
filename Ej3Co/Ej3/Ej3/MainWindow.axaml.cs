using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Ej3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void btnCalcular_Click(object? sender, RoutedEventArgs e){
        if(sender!= null){
            Calcular();
        }
    }
    public void Calcular(){
        int.TryParse(tbinput.Text, out int min);
        int.TryParse(tbinput2.Text, out int max);
        int suma=0;
        for (int i = min; i <= max; i++)
        {
            suma+=i;
        }
        tbSalida.Text = $"La suma desde {min} hasta {max} es {suma}";
    }
}