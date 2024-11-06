namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
		try 
		{
            Navigation.PopAsync();

        } catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
		
    }
}