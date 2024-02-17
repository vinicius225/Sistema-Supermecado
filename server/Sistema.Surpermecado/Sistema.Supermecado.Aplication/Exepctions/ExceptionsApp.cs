
using Sistema.Supermecado.Aplication.Enuns;

namespace Sistema.Supermecado.Aplication.Exepctions
{
    public  class ExceptionsApp : Exception
    {
        public ErrosEnuns TipoErro { get; private set; }
        public ExceptionsApp() : base(){ }

        public ExceptionsApp(ErrosEnuns errosEnuns) : base()
        {
            TipoErro = errosEnuns;
        }

        public ExceptionsApp(string mensagaem, ErrosEnuns errosEnuns) : base()
        {
            TipoErro = errosEnuns;
        }

    }
}
