namespace MyStack
{
    internal interface IStack<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        void Push(T data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        T Pop();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        T Top();
    }
}