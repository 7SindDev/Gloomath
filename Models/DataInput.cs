namespace Gloomath.Models
{
    public class DataInput
    {
        public string Value { get; set; } = string.Empty;
    }

    public class DataInput<T>
    {
        public T Value { get; set; } = default(T);
    }
}