using System.Net.Http.Headers;
using BookRate.Data;
using BookRate.Models;
using Microsoft.EntityFrameworkCore;

namespace BookRate.Repositories
{
    public class UsuarioRepository(AppDbContext context)
    {
        public async Task<Usuario> CreateAsync(Usuario usuario, CancellationToken cancellationToken = default)
        {
            await context.Usuarios.AddAsync(usuario, cancellationToken);
            await context.SaveChangesAsync();

            return usuario;
        }

        public async Task<Usuario> UpdateAsync(Usuario usuario, CancellationToken cancellationToken = default)
        {
            context.Usuarios.Update(usuario);
            await context.SaveChangesAsync(cancellationToken);

            return usuario;
        }

        public async Task<List<Usuario>?> GetAllAsync(
            int skip = 0,
            int take = 25,
            CancellationToken cancellationToken = default)
        {
            return await context
                .Usuarios
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToListAsync(cancellationToken);
        }
    }
}
