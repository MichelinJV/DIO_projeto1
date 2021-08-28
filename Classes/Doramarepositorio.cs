using System;
using System.Collections.Generic;
using Doramadex.Interfaces;

namespace Doramadex
{
    public class Doramarepositorio : IRepositorio<Dorama>
    {
        private List<Dorama> listaSerie = new List<Dorama>();
		public void Atualiza(int id, Dorama objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Assistir(int id)
		{
			listaSerie[id].Assistir();
		}

		public void Insere(Dorama objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Dorama> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Dorama RetornaPorId(int id)
		{
			return listaSerie[id];
		}
    }
}