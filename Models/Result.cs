using Gloomath.Models.FractionsCalculator;

namespace Gloomath.Models
{
    public class Result
    {
        public double Data { get; set; }
        public IDetails Details { get; set; }
    }

    public class Result<TData>
    {
        public TData Data { get; set; }
        public IDetails Details { get; set; }
    }

    public class Result<TData, TDetails> where TDetails : IDetails
    {
        public TData Data { get; set; }
        public TDetails Details { get; set; }
    }

}