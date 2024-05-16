using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Ej7;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void CambiarColor(){
        byte rojo = (byte)red.Value;
        byte green = (byte)Green.Value;
        byte azul = (byte)blue.Value;
        if (rojo==0 && green==0 && azul==0)
            stpColor.Background = new SolidColorBrush(Colors.Black);
        
        else if(rojo==255 && green==255 && azul==255)
            stpColor.Background = new SolidColorBrush(Colors.White);
        else
            stpColor.Background = new SolidColorBrush(Color.FromRgb(rojo,green,azul));
    }

    private void BtnCambiarColor_OnClick(object? sender, RoutedEventArgs e)
    {
        CambiarColor();
    }
}