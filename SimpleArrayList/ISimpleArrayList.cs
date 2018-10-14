using System;

namespace SimpleArrayList
{
    interface ISimpleArrayList
    {
        // Toevoegen aan het einde van de lijst, mits de lijst niet vol is
        void Add(int n);

        // Haal de waarde op van een bepaalde index
        int Get(int index);

        // Wijzig een item op een bepaalde index
        void Set(int index, int number);

        // Print de inhoud van de list
        void Print();

        // Maak de list leeg
        void Clear();

        // Tel hoe vaak het gegeven getal voorkomt
        int CountOccurrences(int number);
    }
}