/*
// Exercício 1
// Passo 2
Console.WriteLine("===================");
Console.WriteLine("AVENTURA DO CONSOLE");
Console.WriteLine("===================");
Console.WriteLine("Encontre o artefato e saia da cidade.");

// Exercício 2
Console.WriteLine("Nome do jogo: Amores Improváveis");
Console.WriteLine("Gênero: RPG");
Console.WriteLine("Local: Universidade");
Console.WriteLine("Personagem principal:Hannah");
Console.WriteLine("Objetivo: fazer a sua própria história de amor");
Console.WriteLine("Mensagem: Olá, seja bem vindo ao campus, se direcione a primeira aula ");

// Etapa 2
// Exercicio 3
Console.WriteLine("Digite o nome do personagem:");
string nome  = Console.ReadLine();
Console.WriteLine("Bem - Vindo, " +  nome + "!");
Console.WriteLine("Sua aventura vai começar.");

// Exercício 4
Console.WriteLine("Qual será o nome do seu personagem?");
string nome2  = Console.ReadLine();

Console.WriteLine("Qual classe irá pertercer?");
string classe  = Console.ReadLine();

Console.WriteLine("Qual será seu mundo?");
string mundo  = Console.ReadLine();

Console.WriteLine("Qual será o objetivo da sua missão?");
string objetivo  = Console.ReadLine();

// Exercício 5
string nome3 = "Isabella";
Console.WriteLine("Nome: " + nome3);
string classe2 = "Arqueiro";
Console.WriteLine("Classe;" + classe2);

int vida = 100;
Console.WriteLine("Vida:" + vida);
int energia = 80;
Console.WriteLine("Energia:" +  energia);
int moedas = 25;
Console.WriteLine("Moedas: " +  moedas);

float velocidade = 5.5f;
Console.WriteLine("Velocidade: " + velocidade);

bool temChave = false;
Console.WriteLine("Tem chave:" + temChave);

// Exercício 6
string nome4 = "Anna Júlia";
string classe3 = "Sereia";
int vida2 = 10;
int energia2 = 20;
float força = 30.5f;
float velocidade2 = 40.9f;
int moedas2 = 1000;
bool temConchas = false;

Console.WriteLine("-" + nome4 + "," +
    "\n-" + classe3 + "," +
    "\n-" + vida2 + "," +
    "\n-" + energia2 + "," +
    "\n-" + força + "," +
    "\n-" + velocidade2 + "," +
    "\n-" + moedas2 + "," +
    "\n" + temConchas + ".");

// Etapa 4
//Exercício 7
Console.WriteLine("Digite a vida do personagem:");
int vida3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a energia do personagem:");
int energia3 = int.Parse(Console.ReadLine());

Console.WriteLine("Vida: " + vida3);
Console.WriteLine("Energia:" + energia3);

// Exercício 8
Console.WriteLine("Digite a vida do seu personagem:");
int vida4 = int.Parse(Console.ReadLine());
Console.WriteLine("Vida: " + vida4);

Console.WriteLine("Digite a energia do seu personagem:");
int energia4 = int.Parse(Console.ReadLine());
Console.WriteLine("Energia: " + energia4);

Console.WriteLine("Digite a força do seu personagem:");
int força = int.Parse(Console.ReadLine());
Console.WriteLine("Força: " + força);

Console.WriteLine("Digite a defesa do seu personagem:");
int defesa = int.Parse(Console.ReadLine());
Console.WriteLine("Defesa: " + defesa);

Console.WriteLine("Digite a quatidade de moedas do seu personagem:");
int moedas  = int.Parse(Console.ReadLine());
Console.WriteLine("Moedas: " + moedas);

Console.WriteLine("Digite o nível do seu personagem:");
int nível =  int.Parse(Console.ReadLine());
Console.WriteLine("Nível: " + nível);

// Etapa 5
// Exercício 9 
int dinheirosoma = 100;
int recompensasoma = 200;
dinheirosoma = dinheirosoma + recompensasoma;
Console.WriteLine("Dinheiro: " + dinheirosoma);

int vida = 50;
int dano = 20;
vida = vida - dano;
Console.WriteLine("vida:" + vida);

int ataque = 250;
int danocrítico = ataque * 2;
Console.WriteLine("Dano Crítico: " + danocrítico);

int moedastotais = 1000;
int jogadores = 5;
int moedasPorJogador = moedastotais / jogadores;
Console.WriteLine("Cada jogador recebeu:" + moedasPorJogador );

// Exercício 10 
Console.WriteLine("Quanto de vida você tem?");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de dano você recebeu?");
int dano = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de cura recebida?");
int cura = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos pontos por inimigo foi recebido?");
int pontosPorInimigo = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de inimigos derrotados");
int inimigosDerrotados = int.Parse(Console.ReadLine());

int vidaRestante = vida - dano;
int VidaRestaurada = vida + cura;
int pontuacaoTotal = inimigosDerrotados * pontosPorInimigo;
int pontuacaoEspecial = pontuacaoTotal * 2;

Console.WriteLine("Vida restante: " + vidaRestante);
Console.WriteLine("Vida restaurada: " + VidaRestaurada);
Console.WriteLine("Pontuação Total: " + pontuacaoTotal);
Console.WriteLine("Pontuação Especial:  " +pontuacaoEspecial);

// Etapa 6
// Exercício 11
Console.WriteLine("Digite a vida do personagem");
int vida = int.Parse(Console.ReadLine());  
if (vida > 0 )
{
    Console.WriteLine("O personagem está vivo");
}
else
{
    Console.WriteLine("Game Over.");

// Exercício 12
Console.WriteLine("Escreva a energia para usar a habilidade:" );
int energia = int.Parse( Console.ReadLine() );
Console.WriteLine("Informe o custo da habilidade:");
int custo = int.Parse( Console.ReadLine() );
int restante = energia - custo;

if  ( energia > custo )
{
    Console.WriteLine( "Você pode usar a hablidade");
    Console.WriteLine("Energia restante: " + restante );
}
else
{
    Console.WriteLine("Você não pode usar a habilidade.");
}

//ETAPA 7
// Exercício 14
Console.WriteLine( "Digite a sua vida");
int vida = int.Parse(Console.ReadLine());

if (vida >= 500) {
    Console.WriteLine( "Seu ESTADO é saudavel");
}
else if (vida >= 200)
{
    Console.WriteLine("Seu ESTADO é FERIDO");
}
else if (vida > 0)
{
    Console.WriteLine("Seu ESTADO é CRÍTICO");
}
else if (vida <= 0 )
{
    Console.WriteLine("Você MORREU");
}

// ETAPA 8
//Exercício 15
int vida = 90;
int energia = 80;
int nivel = 20;

if (vida > 0 && energia >= 80 && nivel >= 20)
{
    Console.WriteLine("Você pode entrar na missão");
}
else
{
    Console.WriteLine("Você não está pronto.");
}

bool temChave = false;
bool temaSenha = true;
if (temChave == true || temaSenha == true)
{
    Console.WriteLine( "A porta abriu.");
}
else
{
    Console.WriteLine( "A porta continua fechada");
}

// Exercício 16
Console.WriteLine("Quanto de energia você tem?");
int energia = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de nível você tem?");
int nível = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de vida você tem?");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Você tem um item especial?");
string itemEspecial = Console.ReadLine();

if (energia >= 50 && nível > 10 && vida > 0 || itemEspecial == "Sim")
{
    Console.WriteLine("Você pode usar a habilidade especial.");
}

else
{
    Console.WriteLine("Você não pode usar a habilidade especial.");
}
*/

// Etapa 9
// Exercício 18

Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Arqueiro");
Console.WriteLine("3 - Mago");
Console.WriteLine("4 - Andre");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Nome: Guerreiro" +
            "\nVida Inicial: 100" +
            "\nEnergia Inicial: 100" +
            "\nForça Inicial: 50" +
            "\nHabilidade Especial: Berserker");
        break;
    case 2:
        Console.WriteLine("Nome: Arqueiro" +
            "\nVida Inicial: 70" +
            "\nEnergia Inicial: 120" +
            "\nForça Inicial: 30" +
            "\nHabilidade Especial: Sniper");
        break;
    case 3:
        Console.WriteLine("Nome: Mago" +
            "\nVida Inicial: 500" +
            "\nEnergia Inicial: 200" +
            "\nForça Inicial: 10" +
            "\nHabilidade Especial: Bruxaria");
        break;
    case 4:
        Console.WriteLine("Nome: Andre" +
            "\nVida Inicial: 10" +
            "\nEnergia Inicial: 5" +
            "\nForça Inicial: 0" +
            "\nHabilidade Especial: Computaria");
        break;
    default: Console.WriteLine("Não tem essa opção seu burro do caralho");
        break;
}

