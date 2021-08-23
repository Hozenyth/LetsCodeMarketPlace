using System;
using System.Linq;

namespace ProjetoLetsCode2
{
    class Program
    {
        static User user = new User();
        static Product produto = new Product();
        static void Main(string[] args)
        {
      
       string opcaoUsuario = ObterOpcaousuario();

 
        while(opcaoUsuario.ToUpper() != "X")
         { //Inicio While

             switch (opcaoUsuario)
         { //Inicio SWitch
         
         case "1":
         InserirDados();
         break;

         case "2":
         ListarDados();
         break;

         case "3":
        VisualizarCadastro();
         break;

         case "4":
        AtualizarCadastro();
         break;

         case "5":
         ExcluirSeller();
         break;

         case "6":
         InserirProdutos();
         break;
         
         case "7":
         ListarProdutos();
         break;
        
         case "8":
         VisualizarProduto();
         break;

         case "9":
         AtualizarProduto();
         break;

         case "10":
         ExcluirProduto();
         break;
         
         case "C":
         Console.Clear();
         break;
        
         default:
          Console.WriteLine("Opção Inválida, tente novamente");                    
          break;



         } //Fim Switch

         

        opcaoUsuario = ObterOpcaousuario();
               

         } //Fim While
 

         Console.WriteLine("Obrigado por utilizar nossos serviços.");
         Console.ReadKey();

 
        
         } //Fim main
          
           private static void ExcluirSeller()
        {
            Console.WriteLine("Digite o Id que deseja excluir");
            int indiceUsuario = int.Parse(Console.ReadLine());

            user.Exclui(indiceUsuario);
            Console.WriteLine(" Pessoa excluida com sucesso!");
           Console.WriteLine();
        
        }

        private static void VisualizarCadastro()
        {
            Console.WriteLine("Digite o Id da pessoa que deseja visualizar");
            int indiceUsuario = int.Parse(Console.ReadLine());

            var usuario = user.RetornaPorId(indiceUsuario);
            Console.WriteLine(usuario);
            Console.WriteLine();
           
        
        }

        private static void AtualizarCadastro()

        {
             Console.WriteLine("Digite o Id da pessoa que deseja atualizar");
             int indiceUsuario = int.Parse(Console.ReadLine());

            foreach( int i in Enum.GetValues(typeof(People))) //vai varrer no enum todas as opções e retornar
            {
                Console.WriteLine("#ID {0}: {1}" , i, Enum.GetName(typeof(People), i));
            }

            Console.WriteLine("Digite o tipo de cadastro entre as opções acima: ");
            int entradaCadastro = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite o Nome: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o Endereço: ");
            string entradaEndereco = (Console.ReadLine());

            Console.WriteLine("Digite o Endreço de Cobrança: ");
            string entradaCobranca = Console.ReadLine();  

            Console.WriteLine("Digite um user : ");
            string entradaUser = Console.ReadLine(); 

            Console.WriteLine("Digite uma senha : ");
            string entradaSenha = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento : ");
            DateTime entradaNascimento = Convert.ToDateTime(Console.ReadLine()); 

            Seller atualizarSeller = new Seller(id: user.ProximoId(),
                                        people: (People)entradaCadastro,
                                        name: entradaNome,
                                        deliveryAddress: entradaEndereco,
                                        billingAddress: entradaCobranca,
                                        user: entradaUser,
                                        password: entradaSenha,
                                        birthDate: entradaNascimento); 
           
            user.Atualizar(indiceUsuario, atualizarSeller);                              
        
         Console.WriteLine("Seu cadastro foi atualizado com sucesso!");
         Console.WriteLine();
             
        }
        

      
       private static void ListarDados()
        {
           
    
         Console.WriteLine("Pessoas cadastradas: ");
         Console.WriteLine();
           var lista = user.Lista();
           
            if (lista.Count == 0)
            {
               Console.WriteLine("Nenhuma pessoa cadastrada");
                return;
            }
           
           
            foreach ( var pessoa in lista)
            {
                
               var excluido = pessoa.retornaExcluido();
            
            Console.WriteLine("#ID {0}: {1} {2}" , pessoa.retornaId(), pessoa.nome(), pessoa.TipoCadastro(), (excluido ? "*Excluido*": "") );
            }
           
              Console.WriteLine();
        }

        private static void InserirDados()
        {
            Console.WriteLine("Digite o tipo de cadastro entre as opções abaixo:");

            foreach( int i in Enum.GetValues(typeof(People))) //vai varrer no enum todas as opções e retornar
            {
                Console.WriteLine("#ID {0}: {1}" , i, Enum.GetName(typeof(People), i));
           }

          
            int entradaPessoa = Int32.Parse(Console.ReadLine()); 

           
            Console.WriteLine("Digite o nome: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o endereço: ");
            string entradaEndereco =(Console.ReadLine());

            Console.WriteLine("Digite o endereço de cobrança: ");
            string entradaBilling = Console.ReadLine();  

            Console.WriteLine("Digite um user : ");
            string entradaUser = Console.ReadLine(); 

            Console.WriteLine("Digite uma senha : ");
            string entradaSenha = Console.ReadLine();

               Console.WriteLine("Digite a data de nascimento : ");
            DateTime entradaNascimento = Convert.ToDateTime(Console.ReadLine()); 

            Seller novoSeller = new Seller(id: user.ProximoId(),
                                        people: (People)entradaPessoa,
                                        name: entradaNome,
                                        deliveryAddress: entradaEndereco,
                                        billingAddress: entradaBilling,
                                        user: entradaUser,
                                        password: entradaSenha,
                                        birthDate: entradaNascimento); 
           
            user.Insere(novoSeller);                              
          Console.WriteLine();
         
         Console.WriteLine("Seu cadastro foi realizado com sucesso!");
         Console.WriteLine();
        }

// ********************** TODOS OS MÉTODOS DE PRODUTOS *******************************************************************

            private static void InserirProdutos()
        {
            Console.WriteLine("Digite a categoria do produto:");

            foreach( int i in Enum.GetValues(typeof(ProductType))) //vai varrer no enum todas as opções e retornar
            {
                Console.WriteLine("#ID {0}: {1}" , i, Enum.GetName(typeof(ProductType), i));
           }

          
            int entradaProduto = Int32.Parse(Console.ReadLine()); 

           
            Console.WriteLine("Digite o nome do produto: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite a descrição do produto: ");
            string entradaDescricao =(Console.ReadLine());

            Producter novoProduto = new Producter(id: produto.ProximoId(),
                                        categoria: (ProductType)entradaProduto,
                                        name: entradaNome,
                                        descricao: entradaDescricao); 
           
          produto.Insere(novoProduto);                              
          Console.WriteLine();
         
         Console.WriteLine("Seu cadastro de produto foi realizado com sucesso!");
         Console.WriteLine();
        }

         
          private static void ListarProdutos()
        {
           
    
         Console.WriteLine("Produtos Cadastrados: ");
         Console.WriteLine();
           var lista = produto.Lista();
           
            if (lista.Count == 0)
            {
               Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
           
           
            foreach ( var product in lista)
            {
                
               var excluido = product.retornaExcluido();
            
            Console.WriteLine("#ID {0}: {1} {2}" , product.retornaId(), product.nome(), product.TipoProduto(), (excluido ? "*Excluido*": "") );
            }
           
           Console.WriteLine();
             
        } 
         private static void VisualizarProduto()
        {
            Console.WriteLine("Digite o Id do produto");
            int indiceProduto = int.Parse(Console.ReadLine());

            var product = produto.RetornaPorId(indiceProduto);
            Console.WriteLine(product);
            Console.WriteLine();
           
        
        }



         private static void AtualizarProduto()

        {
             Console.WriteLine("Digite o Id do prodito que deseja atualizar");
             int indiceUsuario = int.Parse(Console.ReadLine());

            foreach( int i in Enum.GetValues(typeof(ProductType))) //vai varrer no enum todas as opções e retornar
            {
                Console.WriteLine("#ID {0}: {1}" , i, Enum.GetName(typeof(ProductType), i));
            }

            int entradaProduto = Int32.Parse(Console.ReadLine()); 

           
            Console.WriteLine("Digite o nome do produto: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite a descrição do produto: ");
            string entradaDescricao =(Console.ReadLine());

            Producter novoProduto = new Producter(id: produto.ProximoId(),
                                        categoria: (ProductType)entradaProduto,
                                        name: entradaNome,
                                        descricao: entradaDescricao); 
           
            produto.Insere(novoProduto);                              
          Console.WriteLine();
         
         Console.WriteLine("Seu produto foi atualizado com sucesso!");
         Console.WriteLine();
             
        }

         private static void ExcluirProduto()
        {
            Console.WriteLine("Digite o Id do produto que deseja excluir");
            int indiceProduto = int.Parse(Console.ReadLine());

            produto.Exclui(indiceProduto);
            Console.WriteLine(" Produto excluido com sucesso!");
            Console.WriteLine();
           
        
        }

//*********************************************MENU PRINCIPAL ***************************************************************
        private static string ObterOpcaousuario()
        {
            Console.WriteLine("Bem Vindo ao Sistema de Markteplace");
            Console.WriteLine();
            Console.WriteLine("Digite o número para opção desejada: ");
            Console.WriteLine("01 - Cadastrar Pessoa ");
            Console.WriteLine("02 - Listar Cadastros");
            Console.WriteLine("03 - Visualizar Cadastro de Pessoa");
            Console.WriteLine("04 - Atualizar Cadastro ");
            Console.WriteLine("05 - Deletar Cadastro");
            Console.WriteLine("06 - Cadastrar Produto");
            Console.WriteLine("07 - Listar Produtos");
            Console.WriteLine("08 - Visualizar Produto");
            Console.WriteLine("09 - Atualizar Produto");
            Console.WriteLine("10 - Deletar Produto");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }



    }
}
