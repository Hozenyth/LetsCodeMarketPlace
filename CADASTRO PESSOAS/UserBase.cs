using System;
namespace ProjetoLetsCode2
{
    public class UserBase //Atributos que serão utilizados pra ser cadastrado.
    {

    
        public int id { get; set;}
        public string name { get; set;}
        public string deliveryAddress { get; set;}
        public string billingAddress { get; set;}
        public string user {get; set;}
        public string password {get; set;}
        public DateTime birthDate {get; set;}
       
        public  People people  { get; set; }
       
        
    }
}