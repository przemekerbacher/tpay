using System.Threading.Tasks;

namespace ObslugaTPay.Api
{
    public interface IPostable<T1, T2>
    {
        Task<T2> Post(T1 data, string url);
    }
}
