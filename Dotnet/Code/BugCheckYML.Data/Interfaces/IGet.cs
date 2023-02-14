using System.Collections.Generic;

namespace  BugCheckYML.Data.Interfaces
{
    public interface IGet<T,TKey> where T : class
    {
        T Get(TKey id) ;
    }
}
