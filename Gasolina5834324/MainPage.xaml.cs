namespace Gasolina5834324;

public partial class MainPage : ContentPage
{
    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL LABEL
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>

    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double galones = Convert.ToDouble(canGas.Text);

        double litros;

        litros = galones * 3.78541;

        cosTotal.Text = "El costo total es: $" + (litros * 1.168);
    }
}

