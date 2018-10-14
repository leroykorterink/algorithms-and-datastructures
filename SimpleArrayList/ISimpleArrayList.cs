using System;

namespace SimpleArrayList
{
    internal interface ISimpleArrayList
    {
        /// <summary>
        /// Toevoegen aan het einde van de lijst, mits de lijst niet vol is
        /// </summary>
        /// <param name="n"></param>
        void Add(int n);

        /// <summary>
        /// Haal de waarde op van een bepaalde index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        int Get(int index);

        /// <summary>
        /// Wijzig een item op een bepaalde index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        void Set(int index, int number);

        /// <summary>
        /// Print de inhoud van de list
        /// </summary>
        void Print();

        /// <summary>
        /// Maak de list leeg
        /// </summary>
        void Clear();

        /// <summary>
        /// Tel hoe vaak het gegeven getal voorkomt
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int CountOccurrences(int number);
    }
}