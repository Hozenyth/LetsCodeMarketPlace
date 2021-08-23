using System;
using System.Collections.Generic;

namespace ProjetoLetsCode2
{
    public class Seller : UserBase //Referencia é o UserBase para conseguir reutilizar as implementações.
    {

        private bool Excluido {get; set;}// Vai falar se o registro ta excluido ou nao.
      
       
        public Seller(int id, string name, string deliveryAddress, string billingAddress,
        string user, string password, DateTime birthDate, People people)
        {
            base.id= id;
            base.name= name;
            base.deliveryAddress= deliveryAddress;
            base.billingAddress = billingAddress;
            base.user = user;
            base.password = password;
            base.birthDate= birthDate;
            base.people = people;
           

        } // fim Construtor


        public override string ToString() //função de retorno após alguma ação ser executada.
        {
            string retorno = "";
             retorno += "Pessoa: " + this.people + "\n";
            retorno += "Nome: " + this.name + "\n";
            retorno += "Endereço de Entrega: " + this.deliveryAddress + "\n";
            retorno += "Endreço de Cobrança: " + this.billingAddress + "\n";
            retorno += "User: " + this.user + "\n";
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

       

        public int retornaId()
        {
            return this.id;
        }

         public string nome()
        {
            return this.name;
        }

        public People TipoCadastro()
        {
          
           return this.people;
        }


        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

      
    }// fim public Class
}// fim namespace
