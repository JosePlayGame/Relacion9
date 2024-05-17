using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using HarfBuzzSharp;

namespace Craps;

public partial class MainWindow : Window
{
    private string img;
    private string img2;
    private bool perder = false;
    private int numdado1;
    private int numdado2;
    private int turno;
    private int punto;
    private int suma;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CargarDado()
    {
        string[] listado = Directory.GetFiles("Assets");
        var rnd = new Random();
        img = listado[rnd.Next(listado.Length)];
        img2 =  listado[rnd.Next(listado.Length)];
        ImgDado1.Source = new Bitmap(img);
        ImgDado2.Source = new Bitmap(img2);
        int.TryParse(Path.GetFileNameWithoutExtension(img), out numdado1);
        int.TryParse(Path.GetFileNameWithoutExtension(img2), out numdado2);
        Craps();
    }

    private void Perder()
    {
        ImgDado1.Opacity = 0;
        ImgDado2.Opacity = 0;
        BtnTirar.Opacity = 0;
        StPTurno.Opacity = 0;
        BtnReiniciar.Opacity = 100;
        BtnSalir.Opacity = 100;
    }
    private void Craps()
    {
        suma = numdado1 + numdado2;
        if (turno==1)
        {
            punto = suma;
        }
        if (turno==1 && suma==7 || suma==11)
        {
            TbResultado.Text = "HAS GANADO";
            perder = true;
            Perder();
        }
        else if (turno==1 && suma==2 || suma==3 || suma==12){
            TbResultado.Text = "HAS PERDIDO";
            perder = true;
            Perder();
        }
        if (suma==7 && turno>1 && perder!=true){
            TbResultado.Text = "HAS PERDIDO";
            perder = true;
            Perder();
        }else if (suma == punto && turno > 1 && perder!=true)
        {
            TbResultado.Text = "HAS GANADO";
            Perder();
            perder = true;
        }
    }
    private void BtnTirar_OnClick(object? sender, RoutedEventArgs e)
    {
        
        turno++;
        TblTurno.Text = $"{turno}";
        CargarDado();
    }

    private void BtnSalir_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void BtnReiniciar_OnClick(object? sender, RoutedEventArgs e)
    {
        turno = 0;
        BtnSalir.Opacity = 0;
        BtnReiniciar.Opacity = 0;
        TbResultado.Text = "";
        ImgDado1.Opacity = 100;
        ImgDado2.Opacity = 100;
        BtnTirar.Opacity = 100;
        StPTurno.Opacity = 100;
    }
}