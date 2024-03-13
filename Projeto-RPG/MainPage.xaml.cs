namespace Projeto_RPG;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

//------------------------------------------------------------------------
	private void ClicouBotaoSobre( object sender, EventArgs args)
	{
		FrameSobre.IsVisible= true;
	}

	private void ClicouBotaoVoltar( object sender, EventArgs args) 
	{
		FrameSobre.IsVisible= false;
	}

//------------------------------------------------------------------------

	private void ClicouBotaoIniciar( object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}

//------------------------------------------------------------------------

	private void ClicouBotaoResumo(object sender, EventArgs args)
	{
		FrameResumo.IsVisible= true;
	}

	private void ClicouBotaoResumoVoltar(object sedender, EventArgs args)
	{
		FrameResumo.IsVisible= false;
	}


}



