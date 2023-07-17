using Controle_de_contatos.Models;

namespace Controle_de_contatos.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> ListarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
