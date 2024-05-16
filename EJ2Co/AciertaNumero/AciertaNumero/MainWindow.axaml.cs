using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AciertaNumero;

public partial class MainWindow : Window
{
    private int num = 0;
    private int numaciertos = 0;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void CrearNumero()
    {
        numaciertos = 0;
        Random random = new();
        num = random.Next(1,1000);
    }

    private void BtnCalcular_OnClick(object? sender, RoutedEventArgs e)
    {
        if (CHBver_numero.IsChecked == true)
            TblSalida.Text = num.ToString();
        else
            TblSalida.Text = "";
        int numentrada;
        numaciertos++;
        int.TryParse(TbEntrada.Text,out numentrada);
        if (numentrada==num)
        {
            TblSalida.Text = $"HAS ACERTADO EL NUMERO EN {numaciertos} ACIERTOS";
        }else if (numentrada<num)
        {
            TblSalida.Text = "No, el numero es mayor";
        }else{
            TblSalida.Text = "No, el numero es menor";
        }
    }

    private void BtnGenerar_OnClick(object? sender, RoutedEventArgs e)
    {
        if (CHBver_numero.IsChecked==true)
        {
            TblSalida.Text = $"El numero es {num}";
        }
        CrearNumero();
    }

    private void CHBver_numero_OnChecked(object? sender, RoutedEventArgs e)
    {
        TblSalida.Text = $"El numero es {num}";
        
    }

    private void CHBver_numero_OnUnchecked(object? sender, RoutedEventArgs e)
    {
        TblSalida.Text = "";
    }
}