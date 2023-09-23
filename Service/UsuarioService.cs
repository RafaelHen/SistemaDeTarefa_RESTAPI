using Microsoft.EntityFrameworkCore;
using SistemaDeTarefa.Data;
using SistemaDeTarefa.Models;
using SistemaDeTarefa.Service.Interfaces;

namespace SistemaDeTarefa.Service
{
    public class UsuarioService : IUsuarioRepositorio
    {
        private readonly TarefasDBContext _dbContext;
        public UsuarioService(TarefasDBContext tarefasDBContext) {
            this._dbContext = tarefasDBContext;
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario); 
            _dbContext.SaveChanges();
            return usuario;
        }
        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário {id} não foi encontarado.");
            }
            usuarioPorId.nome = usuario.nome;
            usuarioPorId.email = usuario.email;

           _dbContext.Usuarios.Update(usuarioPorId);
           await _dbContext.SaveChangesAsync(); 
            
            return usuarioPorId; 
        }


        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário {id} não foi encontarado.");
            }
            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();  
            return true;

        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
    }
}
