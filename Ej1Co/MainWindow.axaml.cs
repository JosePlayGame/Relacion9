using Avalonia.Controls;
using Avalonia.Markup;
using Avalonia.Interactivity;
namespace Relacion_9;

public partial class MainWindow : Window
{
    int sumannumeros;
    public MainWindow()
    {
        InitializeComponent();
    }
    public void BtnCalcular_Click(object sender, RoutedEventArgs e){
        if (TBInput.Text!=null)
        {
            TBOutput.Text="";
            int.TryParse(TBInput.Text, out int value);
            for (int i = 0; i <= value; i++)
            {
                sumannumeros+=i;
            }
            TBOutput.Text+=sumannumeros.ToString();
        }
    }
    public void BtnSalir_Click(object sender, RoutedEventArgs e){
        this.Close();
    }
}