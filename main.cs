using System;

class Program
{
  public static void Main (string[] args)
  {
  
     string  cpf;
    int numero = 0;
      string nome;
    string idade;
    string logradouro;
    string bairro;
    string nu;
    string complemento;
    
    Console.WriteLine ("Digite seu Nome Completo :");
    nome = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("digite sua idade :");
      idade = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine ("Digite seu logradouro :");
    logradouro = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("digite seu bairro");
    bairro = Console.ReadLine();
    Console.WriteLine("");

        Console.WriteLine("digite o numero da sua residencia");
        nu = Console.ReadLine();
    Console.WriteLine("");

        Console.WriteLine("Digite um complemento (opcional)");
        complemento = Console.ReadLine();
    Console.WriteLine("");
    
      
    Console.WriteLine("Digite seu CPF");
    cpf = Console.ReadLine();
    Console.WriteLine("");
    
      cpf = cpf.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

    
    int soma = 0;

   for (int i = 0; i < 11; i++)
       soma += int.Parse(cpf[i].ToString());
    
    if  (cpf.Length >= 11)
    {
      Console.WriteLine("CPF Valido");
    }
    
    else 
    {
      
      Console.WriteLine("cpf invalido");
    }
    
  }
}
