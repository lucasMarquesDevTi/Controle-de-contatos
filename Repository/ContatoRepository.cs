using Controle_de_contatos.Data;
using Controle_de_contatos.Models;

namespace Controle_de_contatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {

        private readonly BancoContext _bancoContext;

        public ContatoRepository(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> ListarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

      
    }
}
