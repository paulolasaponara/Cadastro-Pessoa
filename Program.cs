using System.Globalization;
using Cadastro_Pessoa.Classes;

// imprimi no console o hello world
// Console.WriteLine("Hello, World!");

//para instanciar precisa dizer qual tipo e depois o nome do objeto = MetodoConstrutor();
//instanciamos um objeto do tipo pessoa fisica, estamos criando um objeto

// Console.WriteLine(novaPessoaFisica.Nome);
// Console.WriteLine(novaPessoaFisica.Cpf);
// Console.WriteLine(novaPessoaFisica.DataNascimento);
// Console.WriteLine(novaPessoaFisica.Rendimento);

//imprimimos no console os valores dos objetos com a concatenaçao

// System.Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
// System.Console.WriteLine("CPF: " + novaPessoaFisica.Cpf);
// System.Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// System.Console.WriteLine("Rendimento: $ " + novaPessoaFisica.Rendimento);

//imprimimos no console os valores dos objetos com a interpolaçao

// System.Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// System.Console.WriteLine($"CPF: {novaPessoaFisica.Cpf}");
// System.Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.DataNascimento}");
// System.Console.WriteLine($"Rendimento: $ {novaPessoaFisica.Rendimento}");

PessoaFisica novaPessoaFisica = new PessoaFisica();

// //atribuimos um valor para as propriedades

novaPessoaFisica.Nome = "Lorenzo";
novaPessoaFisica.Cpf = "12345678910";
novaPessoaFisica.DataNascimento = new DateTime(2017,10,19);
novaPessoaFisica.Rendimento = 50000.50f;


PessoaFisica MetodosPF = new PessoaFisica();

//imprimimos no console os valores dos objetos com a interpolaçao com quebra de linhas

Console.WriteLine(@$"
Nome: {novaPessoaFisica.Nome}
CPF: {novaPessoaFisica.Cpf}
Data de Nascimento: {novaPessoaFisica.DataNascimento}
Rendimento: R${novaPessoaFisica.Rendimento}
Imposto a Pagar : {MetodosPF.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
");

// //instanciado um objeto do tipo pessoa juridica
PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

//instaciamos um objeto do tipo endereço
//atribuimos valores para os atributos

Endereco novoEndereco = new Endereco();

novoEndereco.Logradouro = "Av Interlagos";
novoEndereco.Numero = 1609;
novoEndereco.Complemento = "Interclube";
novoEndereco.Comercial = true;
novoEndereco.Cep = "04661100";

//atribuimos valores para os atributos do objeto pessoa juridica
novaPessoaJuridica.Nome = "Palmeiras";
novaPessoaJuridica.RazaoSocial = "S.E.Palmeiras";
novaPessoaJuridica.Cnpj = "22658312000177";
novaPessoaJuridica.Rendimento = 250000.99f;
novaPessoaJuridica.Endereco = novoEndereco;

//instanciamos um objeto do tipo pessoa juridica que servira para manipular os metodos
PessoaJuridica metodosPJ = new PessoaJuridica();

//imprimimos os valores do objeto pessoa juridica
Console.WriteLine(@$"
Nome Fantasia: {novaPessoaJuridica.Nome}
Razão Social: {novaPessoaJuridica.RazaoSocial}
CNPJ: {novaPessoaJuridica.Cnpj}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
Imposto a pagar :  {metodosPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}

Endereco : {novaPessoaJuridica.Endereco.Logradouro} 
Numero : {novaPessoaJuridica.Endereco.Numero}
Complemento : {novaPessoaJuridica.Endereco.Complemento}
Endereço Comercial : {novaPessoaJuridica.Endereco.Comercial}
CEP : {novaPessoaJuridica.Endereco.Cep}
");


//ToString transforma o numero (float) para texto (string)