using CasaDoCodigo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
	public interface ICategoriaRepository
	{
		Categoria GetCategoria(string categoria);
		Task SaveCategoria(Categoria categoria);
	}
	public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
	{
		public CategoriaRepository(ApplicationContext contexto) : base(contexto)
		{
			
		}

		public Categoria GetCategoria(string categoria)
		{
			return
			dbSet
				.Where(c => c.Nome == categoria)
				.SingleOrDefault();
		}

		public async Task SaveCategoria(Categoria categoria)
		{
			if (GetCategoria(categoria.Nome) == null)
			{
				dbSet.Add(categoria);
			}

			await contexto.SaveChangesAsync();
		}

		

	}
}
