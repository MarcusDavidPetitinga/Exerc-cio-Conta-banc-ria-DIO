using System;
 

namespace Tb
{
    public  class Metodos
    {  
      


        private string nome{get ; set;}
        private  double saldo{get ; set;}
        private  double credito{get ; set;}
  public  Metodos( string nome,  double saldo, double credito)
        {
           this.nome = nome;
           this.saldo = saldo;
           this.credito = credito;
        }

	
  

public override string ToString(){
string retorno="";
retorno += " Nome: "+this.nome+", ";
retorno +="Saldo atual: R$ "+(string.Format("{0:0.00 }",this.saldo))+" ";
retorno +="Crédito atual: R$ "+(string.Format("{0:0.00 }",this.credito))+"";
return retorno;
}

        public double Sacar(double valorSaque)
        { 
              if(saldo< valorSaque) {
                Double retiradadeCredito =valorSaque-saldo;
                this.credito = credito - retiradadeCredito;
                this.saldo =saldo+retiradadeCredito-valorSaque;
			
			}		
		 else if(saldo>valorSaque) {
			this.saldo=saldo-valorSaque;
			
		}
         else if(saldo==valorSaque) {
			this.saldo=0;
			
		}
       
            return this.saldo;	 
}

        public double Depositar(double valorDeposito)
        {
		 
           return saldo=saldo+valorDeposito;

	}
    
           
    }
    }
