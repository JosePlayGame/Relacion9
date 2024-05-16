using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Ej11;

public partial class MainWindow : Window
{
    private List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17,18,19,20 };
    public int count=0;
    int item1;
    int item2;
    public MainWindow()
    {
        InitializeComponent();
        Inicializar();
    }
    private void Inicializar()
    {
        foreach (var item in Numbers)
        {
            CbPadre.Items.Add(item);
            CbPadre2.Items.Add(item);
        }
    }

    private void DarTamañoGrid()
    {
        
        string columnas = "";
        string filas = "";
        int.TryParse(CbPadre.SelectionBoxItem.ToString(),out item1);
        int.TryParse(CbPadre2.SelectionBoxItem.ToString(),out item2);
        for (int i = 0; i < item1 ; i++)
        {
            filas += "Auto,";
        }
        for (int j = 0; j < item2; j++)
        {
            columnas += "Auto,";
        }

        columnas = columnas.Remove(columnas.Length-1, 1);
        filas = filas.Remove(filas.Length-1, 1);
        GrMatriz.RowDefinitions = RowDefinitions.Parse(filas);
        GrMatriz.ColumnDefinitions = ColumnDefinitions.Parse(columnas);
    }
    private void Matriz()
    {
        DarTamañoGrid();
        count = 0;
        for (int i = 0; i < item1; i++)
        {
            for (int j = 0; j < item2; j++)
            {
                Button btn = new Button();
                GrMatriz.Children.Add(btn);
                btn.Content = $"[{i},{j}]";
                btn.Background = Brushes.LightBlue;
                btn.Margin= Avalonia.Thickness.Parse("1");
                btn.MinWidth = 45;
                btn.MaxWidth = 45;
                btn.MinHeight = 1;
                btn.FontSize = 10;
                btn.FontWeight = FontWeight.Bold;
                Grid.SetRow(btn,i);
                Grid.SetColumn(btn,j);
                count++;
            }
        }
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Matriz();
    }
}