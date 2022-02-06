﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItsMyConsole.Tools.Template.Example
{
    /// <summary>
    /// Outils pour SWAPI
    /// </summary>
    public class SwapiTools
    {
        private readonly SwapiOption _swapiOption;

        internal SwapiTools(SwapiOption swapiOption) {
            _swapiOption = swapiOption;
        }

        /// <summary>
        /// Récupération du nombre de résultat maximum pour une recherche de personne
        /// </summary>
        public int GetMaxResultSearchPeople() {
            return _swapiOption.MaxResultSearchPeople;
        }

        /// <summary>
        /// Recherche des personnes à partir d'un nom
        /// </summary>
        /// <param name="name">Le nom de personne à chercher</param>
        public async Task<List<People>> SearchPeople(string name) {
            await Task.Delay(0);
            return null;
        }
    }
}
