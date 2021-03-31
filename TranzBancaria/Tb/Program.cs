using System;
using System.Collections.Generic;

namespace Tb
{
    class Program
    {
        static  void Main(string[] args)
        {
           
     
            List<Metodos>listadeContas=new List<Metodos>();
    String opcao;
    int indice=0;
    int i=0;
    Double valorSaque=0.0;
    Double valorDeposito=0.0;
    Double valorTransferencia=0.0;
    Metodos list;

           while((opcao=obterOpcaoUsuario()).ToUpper() !="X"){

switch(opcao){

    case "1"://Cadastrar

   Console.WriteLine("Digite o usuário:");
    String nome=Console.ReadLine();
    Console.WriteLine("Digite o saldo:");
    Double saldo=Double.Parse(Console.ReadLine());
     Console.WriteLine("Digite crédito:");
    Double credito=Double.Parse(Console.ReadLine());

    Metodos novaConta=new Metodos(nome,saldo,credito);
    listadeContas.Add(novaConta);
     Console.WriteLine("Conta cadastrada com sucesso.");
     Console.WriteLine(" ");
    break;

    case "2"://Depositar

    Console.WriteLine("Digite o numero da conta:");
    indice=int.Parse(Console.ReadLine());
     Console.WriteLine("Conta para depósito:");
list=listadeContas[indice];
Console.Write("Conta {0}",indice);
Console.WriteLine(list);
    Console.WriteLine("Digite o valor do deposito:");
    valorDeposito=Double.Parse(Console.ReadLine());
    listadeContas[indice].Depositar(valorDeposito);
    Console.WriteLine("depósito efetuado com sucesso.");
    break;

    case "3":// Sacar
    
    Console.WriteLine("Digite o numero da conta:");
    indice=int.Parse(Console.ReadLine());
     Console.WriteLine("Conta para saque:");
list=listadeContas[indice];
Console.Write("Conta {0}",indice);
Console.WriteLine(list);
    Console.WriteLine("Digite o valor do saque:");
    valorSaque=Double.Parse(Console.ReadLine());
   
     listadeContas[indice].Sacar(valorSaque);
     Console.WriteLine("Saque efetuado com sucesso");
    break;

    case "4"://Transferir

    Console.WriteLine("Digite o numero da conta debitada:");
    int indiceA=int.Parse(Console.ReadLine());
     Console.WriteLine("Conta a ser  debitada.");
list=listadeContas[indiceA];
Console.Write("Conta {0}",indiceA);
Console.WriteLine(list);
    Console.WriteLine("Digite o numero da conta creditada:");
    int indiceB=int.Parse(Console.ReadLine());
     Console.WriteLine("Conta a ser creditada:");
list=listadeContas[indiceB];
Console.Write("Conta {0}",indiceB);
Console.WriteLine(list);
    Console.WriteLine("Digite o valor da transferência:");
    valorTransferencia=Double.Parse(Console.ReadLine());
    valorDeposito=valorTransferencia;
    valorSaque=valorTransferencia;
    listadeContas[indiceA].Sacar(valorSaque);
    listadeContas[indiceB].Depositar(valorDeposito);
   Console.WriteLine("Transferência efetuada com sucesso");

    break;

    case "5": //consultar

    Console.WriteLine("(1) Para consultar todas as contas:");
    Console.WriteLine("(2) Para consultar pelo número da conta:");
  String consulta=Console.ReadLine();
  if(consulta.Equals("1")){
  for(i =0; i<listadeContas.Count;i++){
  list=listadeContas[i];
 Console.Write("Conta {0} ",i);
 Console.WriteLine(list);
}
}
else if(consulta.Equals("2")){
 Console.WriteLine("Digite o numero da conta:");
 indice=int.Parse(Console.ReadLine());
list=listadeContas[indice];
Console.Write("Conta {0} ",indice);
Console.WriteLine(list);
}
else{
    Console.WriteLine("Opção inválida!");
}
    break;
    

    case "X":

    Sair();
    return;
}


           }
        }
        
static string obterOpcaoUsuario(){
    Console.WriteLine(" ");
Console.WriteLine("Digite a opção desejada:");
Console.WriteLine("(1)Para cadastrar conta.");
Console.WriteLine("(2)Para depositar.");
Console.WriteLine("(3)Para sacar.");
Console.WriteLine("(4)Para transferir.");
Console.WriteLine("(5)Para consultar lista de contas.");
Console.WriteLine("(x)Para cadastrar sair.");

string opcao=Console.ReadLine().ToUpper();
return opcao;
}   

   public static void Sair(){
Console.WriteLine("Volte sempre!");
return ;
}

 
    

    }
}      

    
    

