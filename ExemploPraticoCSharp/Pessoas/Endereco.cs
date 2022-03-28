namespace ExemploPraticoCSharp.Pessoas
{
    public class Endereco
    {
        private int _numero;
        public String Rua  { get; set; }
        public String  Bairro { get; set; }
        public String Cidade { get; set; }
        public int Numero {
            get
            {
                return _numero;
            }
            set
            {
                if (value >= 0)
                {
                    _numero = value;
                }
            }
        }
                
        public Endereco(string rua, String  bairro, int numero, String cidade)
        {
            Rua = rua;  
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
        }

        
    }
}