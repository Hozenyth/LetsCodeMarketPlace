namespace ProjetoLetsCode2
{
    public class Producter : ProductBase
    {
        private bool Excluido {get; set;}// Vai falar se o registro ta excluido ou nao.
      
       
        public Producter(int id, string name, string descricao, ProductType categoria)
        {
            base.id= id;
            base.name= name;
            base.descricao= descricao;
            base.categoria = categoria;
         
           

        } // fim Construtor


        public override string ToString() //função de retorno após alguma ação ser executada.
        {
            string retorno = "";
             retorno += "Nome do Produto: " + this.name + "\n";
             retorno += "Descrição do Produto: " + this.descricao + "\n";
             retorno += "Categoria do Produto: " + this.categoria + "\n";
             retorno += "Excluido: " + this.Excluido + "\n";
           
            
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

        public ProductType TipoProduto()
        {
           return this.categoria;
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
    