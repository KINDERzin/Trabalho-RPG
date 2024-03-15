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
		TextoDaResposta01 = "Dante vai pela linha ferroviária.",
		TextoDaResposta02 = "Dante vai pela marginal.",
		TextoDaResposta03 = "Dante vai à procura de gasolina."
	});

//-----------------------------------------------------------------

	historia.Add(new HistoryStep()
	{
		Id = 1,
		Texto="Ao decorrrer do caminho ele encontra um trem parado e decide investigar, enquanto ele procurava oisas pelo trem, ele encontrou alguns suprimentos médicos e um taco com pregos cravados, 10 minutos depois ele chega à cidade e vai a procura de um abrigo.",
		TemResposta = true,
		TextoDaResposta01 = "Ele vai passar a noite em um hotel.",
		TextoDaResposta02 = "Ele dorme em um carro.",
		TextoDaResposta03 = "Ele decide explorar a cdade durante a noite."

	});
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