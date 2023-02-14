using System.Collections.Generic;

namespace BugCheckYML.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
