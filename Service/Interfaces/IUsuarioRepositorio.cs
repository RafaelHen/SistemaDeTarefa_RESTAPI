using SistemaDeTarefa.Models;

namespace SistemaDeTarefa.Service.Interfaces
{
    public interface IUsuarioRepositorio
    {

        //task porque quero assincrono.
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel model);
        Task<UsuarioModel> Atualizar(UsuarioModel model, int id);
        Task<Boolean> Apagar(int id);

    }
}
