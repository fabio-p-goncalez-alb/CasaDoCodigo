using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
	public class BuscaProdutosViewModel
	{
		public BuscaProdutosViewModel(IList<Produto> produtos, string pesquisa = null)
		{
			Produtos = produtos;

			Pesquisa = pesquisa;
		}

		public IList<Produto> Produtos { get; }

		public string Pesquisa { get; }
	}
}
