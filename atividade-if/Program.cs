See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva dois números e eu direi qual é o maior.");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());
int segundoNumero = Convert.ToInt32(Console.ReadLine());

if (primeiroNumero > segundoNumero)
{
    Console.WriteLine(primeiroNumero + " é o maior número.");
}
else
{
    Console.WriteLine(segundoNumero + " é o maior número.");
}

Console.WriteLine("Estamos em tempo de campanha eleitoral, e nosso site te diz se você poderá votar ou não? Quer descobrir? \n \nResponda com sim ou não");
string resposta = Console.ReadLine();
if (resposta == "sim")
{
    Console.WriteLine("Digite o ano do seu nascimento, por favor.");
    int anoDeNascencia = Convert.ToInt32(Console.ReadLine());
    if (anoDeNascencia <= 2003)
    {
        Console.WriteLine("O voto é obrigatorio para você, fique atento as recomendações do Governo Federal sobre essas informações.");
    }
    else if (anoDeNascencia == 2004 || anoDeNascencia == 2005)
    {
        Console.WriteLine("Good news! Você já pode ajudar o Brasil a eleger seus politicos, mas ainda não é obrigatorio, aconselhamos esperar as recomendações do Governo Federal sobre essas informações");
    }
    else if (anoDeNascencia > 2005)
    {
        Console.WriteLine("Infelizmente você não pode votar, mas, fique tranquilo, pode acompanhar sobre os informações sobre as eleições no site https://governofederal.com");
    }
}
else
{
    Console.WriteLine("Agradecemos a atenção, muito obrigada.");
}

Console.WriteLine("Olá usuário X, pode colocar a sua senha.");

int senha = 1234;
int confSenha = Convert.ToInt32(Console.ReadLine());

if (senha == confSenha)
{
    Console.WriteLine("ACESSO PERMITIDO \n \nAPERTE ENTER");
    Console.ReadKey();
    while (true)
    {
        Console.WriteLine("Lorem ipsum dolor sit amet. Est repudiandae sunt est quia pariatur ea esse iusto sed eius impedit et consequatur veniam qui velit animi hic voluptate illo. Aut molestias voluptatem ab accusamus numquam et temporibus velit et aliquid doloremque ut deleniti eveniet. In nemo harum non nemo voluptate et labore deserunt! Qui iure libero quo corrupti debitis ut dolorem itaque! Hic dicta doloribus non aliquid assumenda et consequatur aperiam ex repellendus galisum ut tenetur iure. In recusandae delectus et error porro hic itaque quia id voluptatibus earum non enim voluptatem a sunt odit. Ut debitis voluptas ut galisum dolores non quibusdam fugiat est corporis sapiente et laudantium sunt. Sit facere totam ab libero suscipit et delectus ipsum aut libero rerum ut natus culpa. \nVel alias earum eum quidem quae aut iusto provident. Consequatur aspernatur et rerum molestiae 33 perferendis ducimus id voluptatem harum sit quasi consequatur cum architecto quia. Qui maiores consequatur sit nemo earum et blanditiis ipsum et voluptate commodi in culpa voluptatibus nam magni doloribus sit dignissimos voluptate. Sit aspernatur alias ut eligendi quasi quo nulla aliquid sed dignissimos galisum et  autem. Aut placeat facilis non minima natus ut sunt fugiat  quis laborum et dolorem dolorum et fugiat dolores? Ab consequuntur velit aut voluptatibus fugiat ut eligendi ratione. In unde internos sit officiis vero ea galisum galisum! Non quia rerum est illo laborum id illo corrupti. \nDolores sequi aut alias totam rem recusandae quaerat. Et porro velit est harum quisquam aut incidunt reiciendis nam veniam accusamus sed impedit quos ex internos assumenda. Et sequi internos quo corrupti molestiae vel magni repellat et dolor cupiditate id voluptas mollitia et voluptates voluptates. In minus tempora et tempore ipsa et consectetur doloremque in debitis dolorem. Aut cumque possimus sit quae porro et iste maiores non officiis ratione qui quidem ullam? Et quia officiis est voluptatibus veniam cum voluptatem magnam At voluptatem expedita ut sunt quaerat ut quia animi ut iste corrupti. Eum eveniet porro quo rerum sapiente non laborum repellendus et eveniet beatae sit laboriosam temporibus et molestiae porro id odit tempora. Et similique voluptatum At ipsum voluptatum ea ducimus tempora sit nostrum dignissimos.");
    }
}
else
{
    Console.WriteLine("ACESSO NEGADO");
}

Console.WriteLine("Olá usuário, somos a MercaX, seu mercado do futuro, a promoção de hoje é maçã, deseja comprar alguma? \n \nResponda com sim ou não.");

string resposta = Console.ReadLine();

if (resposta == "sim")
{
    Console.WriteLine("Quantas maçãs você deseja?");
    int quantidadeDeMacas = Convert.ToInt32(Console.ReadLine());
    double valor;
    if (quantidadeDeMacas >= 12)
    {
        valor = quantidadeDeMacas * 0.25;
        Console.WriteLine("Esse é o valor a se pagar R$" + valor);
    }
    else
    {
        valor = quantidadeDeMacas * 0.30;
        Console.WriteLine("Esse é o valor a se pagar R$" + valor);
    }
}
else
{
    Console.WriteLine("Agradecemos sua atenção, tenha um bom dia.");
}

Console.WriteLine("Insira um número");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 0)
{
    Console.WriteLine("Maior que 0");
}
else
{
    Console.WriteLine("Menor que 0");
}

Console.WriteLine("insira uma letra");
string letraDigitada = Console.ReadLine();

if (letraDigitada == "a" || letraDigitada == "e" || letraDigitada == "i" || letraDigitada == "o" || letraDigitada == "u")
{
    Console.WriteLine("A letra que você digitou é uma vogal");
}
else
{
    Console.WriteLine("A letra que você digitou é uma consoante");
}

Console.WriteLine("insira sua média");
double media = Convert.ToDouble(Console.ReadLine());

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media == 10)
{
    Console.WriteLine("Aprovado com distinção");
}
else
{
    Console.WriteLine("Reprovado");
}





