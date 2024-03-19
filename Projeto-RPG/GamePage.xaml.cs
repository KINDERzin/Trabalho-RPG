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
		TextoDaResposta01 = "Dante segue pela linha ferroviária",
		TextoDaResposta02 = "Dante vai pela marginal",
		TextoDaResposta03 = "Dante vai à procura de gasolina",
		IdLevelResposta01 = 1,
		IdLevelResposta02 = 2,
		IdLevelResposta03 = 3
	});

	historia.Add(new HistoryStep()
	{
		Id = 1,
		Texto="Dante anda pela linha até chegar na cidade e aproveita para olhar o que tem nos vagões, após uma breve busca ele encontra alguns suprimentos médicos e um taco com pregos cravados e então decide seguir caminho até a cidade (10 minutos depois ele chega à cidade). Está escurecendo e ele precisa encontra um local seguro para descançar.",
		TemResposta = true,
		TextoDaResposta01 = "Ele vai em busca de um hotel",
		TextoDaResposta02 = "Ele dorme em um carro",
		TextoDaResposta03 = "Ele decide explorar a cdade durante a noite",
		IdLevelResposta01 = 9999,
		IdLevelResposta02 = 1000,
		IdLevelResposta03 = 9999,
	});

	historia.Add(new HistoryStep()
	{
		Id = 2,
		Texto="25 minutos se passam e ele encontra uma lanterna com bateria e alguns alimentos enlatados em um carro abandonado, anoitece e ele ainda não chegou na cidade. (Ele avista um posto a frente)",
		TemResposta = true,
		TextoDaResposta01 = "Dante dorme no posto",
		TextoDaResposta02 = "Ele segue caminho até a cidade,",
		TextoDaResposta03 = "Ele enche dois galões de combustível e volta para o carro.",
		IdLevelResposta01 = 9999,
		IdLevelResposta02 = 2200,
		IdLevelResposta03 = 9999
		
	});

	historia.Add(new HistoryStep()
	{
		Id = 3,
		Texto="Após uma procura de 30 minutos ele encontra um carro com o tanque cheio e um bunker aberto com alguns corpos, ele verifica e não nota algo de errado. (Dante ouve um barulho do lado de fora)",
		TemResposta = true,
		TextoDaResposta01 = "Dante dorme no bunker",
		TextoDaResposta02 = "Dante junta os suprimentos e volta para o carro",
		TextoDaResposta03 = "Dante vai investigar o lado de fora",
		IdLevelResposta01 = 9999,
		IdLevelResposta02 = 9999,
		IdLevelResposta03 = 9999,
		
	});

	historia.Add(new HistoryStep()
	{
		Id = 1000,
		Texto="(Durante a madrugada  Dante sofre um ataque dos Sussurrates que o cercam dentro do carro)",
		HeroIsDead = true
	});

	historia.Add(new HistoryStep()
	{
		Id = 2200,
		Texto="(É atacado pela orda de Sussurrantes)",
		HeroIsDead = true
	});

	historia.Add(new HistoryStep()
	{
		Id = 9999,
		Texto="CABO",
		HeroIsDead = true
	});

	 Iniciar();
	}

//-----------------------------------------------------------------	

	void Iniciar()
  {
    TrocaHistoryStepAtual(0);
  }

//-----------------------------------------------------------------	

	void PreencherPagina()
	{
		LabelHistoria.Text = HistoryStepAtual.Texto;

		if(HistoryStepAtual.HeroIsDead)
			FrameMorte.IsVisible = true;
    	else
      		FrameMorte.IsVisible = false;

		if (HistoryStepAtual.TemResposta)
		{
		BotaoContinua.IsVisible = false;
		Botao_1.IsVisible = true;
		Botao_2.IsVisible = true;
		Botao_3.IsVisible = true;
		Botao_1.Text = HistoryStepAtual.TextoDaResposta01;
		Botao_2.Text = HistoryStepAtual.TextoDaResposta02;
		Botao_3.Text = HistoryStepAtual.TextoDaResposta03;
		}
		else
		{
		BotaoContinua.IsVisible = true;
		Botao_1.IsVisible = false;
		Botao_2.IsVisible = false;
		Botao_3.IsVisible = false;
		}
	}



//-----------------------------------------------------------------	

	void TrocaHistoryStepAtual(int id)
	{
		HistoryStepAtual = historia.Where(d => d.Id == id).First();
		PreencherPagina();
	}

//-----------------------------------------------------------------	

	void ClicouBotaoContinua(object sender, EventArgs args)
	{

	}

//-----------------------------------------------------------------

	void ClicouBotao1(object sender, EventArgs args)
	{
		TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta01);
	}

//-----------------------------------------------------------------

	void ClicouBotao2(object sender, EventArgs args)
	{
		TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta02);
	}

//-----------------------------------------------------------------

	void ClicouBotao3(object sender, EventArgs args)
	{
		TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta03);
	}

//-----------------------------------------------------------------
	void ClicouBotaoGameOver(object sender, EventArgs args)
  {
    Iniciar();
  }
}