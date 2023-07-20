using Controle_de_contatos.Models;

namespace Controle_de_contatos.Repository
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> ListarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
