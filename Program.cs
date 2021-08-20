using System;

namespace ProjetoLetsCode2
{
    class Program
    {
        static void Main(string[] args)
        {
        Menu menu = new Menu(); //Instaciado o Menu pra que o mesmo funcione pois nao foi declarado
        int opcao = menu.menu(); // como static.

       Console.WriteLine($"A opção do menu é : {opcao}");

      
       
        }
    }
}
