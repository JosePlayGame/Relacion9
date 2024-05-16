using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace Reloj;

public partial class MainWindow : Window
{
    private DispatcherTimer _reloj = new();
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Inicializar()
    {
        LblFecha.Content = DateTime.Today.ToString("D");
        _reloj.Start();
        _reloj.Tick += RelojOnTick; 

    }

    private void RelojOnTick(object? sender, EventArgs e)
    {
        LblReloj.Content = $"{DateTime.Now.Hour:D2} : {DateTime.Now.Minute:D2} : {DateTime.Now.Second:D2}";
        
    }


    private void BtnIniciar_OnClick(object? sender, RoutedEventArgs e)
    {
        
        Inicializar();
    }
    private void BtnParar_OnClick(object? sender, RoutedEventArgs e)
    {
        _reloj.Stop();
    }

    private void BtnSalir_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}