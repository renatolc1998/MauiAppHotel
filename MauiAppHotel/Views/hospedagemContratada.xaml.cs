namespace MauiAppHotel.Views;

public partial class hospedagemContratada : ContentPage
{
	public hospedagemContratada()
	{
		InitializeComponent();
	}

    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}