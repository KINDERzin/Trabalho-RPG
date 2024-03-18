namespace Projeto_RPG;

public partial class GamePage : ContentPage
{
	List<HistoryStep> historia = new List<HistoryStep>();
	HistoryStep HistoryStepAtual;

	public GamePage()
	{
		InitializeComponent();

		historia.Add(new HistoryStep()
	{
		Id = 0,
		Texto="Dante está chegando em Melione, quando acaba a gasolina, ele desce do carro e decide terminar o caminho a pé. 200 metros à frente ele encontra a linha ferroviária de Melione com alguns trens parados.",
		TemResposta = true,
		TextoDaResposta01 = "Dante segue pela linha ferroviária.",
		TextoDaResposta02 = "Dante vai pela marginal.",
		TextoDaResposta03 = "Dante vai à procura de gasolina."
	});

	historia.Add(new HistoryStep()
	{
		Id = 1,
		Texto="Dante anda pela linha até chegar na cidade e aproveita para olhar o que tem nos vagões, após uma breve busca ele encontra alguns suprimentos médicos e um taco com pregos cravados e então decide seguir caminho até a cidade (10 minutos depois ele chega à cidade). Está escurecendo e ele precisa encontra um local seguro para descançar.",
		TemResposta = true,
		TextoDaResposta01 = "Ele vai em busca de um hotel.",
		TextoDaResposta02 = "Ele dorme em um carro.",
		TextoDaResposta03 = "Ele decide explorar a cdade durante a noite."

	});



	}

//-----------------------------------------------------------------	

	void PreencherPgina()
	{
		LabelHistoria.Text = HistoryStepAtual.Texto;

		if(HistoryStepAtual.HeroIsDead)
			FrameMorte.IsVisible = true;
    	else
      		FrameMorte.IsVisible = false;
	}

//-----------------------------------------------------------------	

	void ClicouBotaoContinua(object sender, EventArgs args)
	{

	}

//-----------------------------------------------------------------

	void ClicouBotao1(object sender, EventArgs args)
	{

	}

//-----------------------------------------------------------------

	void ClicouBotao2(object sender, EventArgs args)
	{

	}

//-----------------------------------------------------------------

	void ClicouBotao3(object sender, EventArgs args)
	{

	}
}