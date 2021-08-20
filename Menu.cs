using System;
namespace ProjetoLetsCode2
{
    public class Menu
    {
       public int menu() {
            Console.WriteLine("Bem vindo ao sistema de markteplace");
            Console.WriteLine();
            Console.WriteLine("Digite o número para opção desejada: ");
            Console.WriteLine("01 - Cadastrar Novo Usuário");
            Console.WriteLine("02 - Cadastrar Novo Vendendor");
            Console.WriteLine("03 - Cadastrar Novo Cliente");
            Console.WriteLine("04 - Buscar Usuário");
            Console.WriteLine("05 - Buscar Vendendor");
            Console.WriteLine("06 - Buscar Cliente");
            Console.WriteLine("07 - Atualizar Dados Usuário");
            Console.WriteLine("08 - Atualizar Dados Vendendor");
            Console.WriteLine("09 - Atualizar Dados Cliente");
            Console.WriteLine("10 - Deletar Dados Usuário");
            Console.WriteLine("11 - Deletar Dados Vendendor");
            Console.WriteLine("12 - Deletar Dados Cliente");
            Console.WriteLine("13 - Sair");
            Console.WriteLine("Opção: ");
            int opcao = Int32.Parse(Console.ReadLine());
            return opcao;
        }
    }
            
}
