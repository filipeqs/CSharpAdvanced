namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object Value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            Value = value;
        }

        public bool HasValue
        {
            get { return Value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)Value;

            return default(T);
        }
    }
}
