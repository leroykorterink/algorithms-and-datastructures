namespace SimpleLinkedList
{
    internal interface ISimpleLinkedList<T>
    {
        /// <summary>
        /// Voeg een item toe aan het begin van de lijst
        /// </summary>
        /// <param name="data"></param>
        void AddFirst(T data);
        
        /// <summary>
        /// Haalt de lijst leeg
        /// </summary>
        void Clear();
        
        /// <summary>
        /// Print de huidige lijst
        /// </summary>
        void Print();
        
        /// <summary>
        /// Voeg een item in op een bepaalde index (niet overschrijven!)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        void Insert(int index, T data);
        
        /// <summary>
        /// verwijder het eerste item
        /// </summary>
        void RemoveFirst();

        /// <summary>
        /// geeft het eerste item terug
        /// </summary>
        /// <returns></returns>
        T GetFirst();
    }

}