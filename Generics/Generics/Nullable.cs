namespace Generics
{
    //8. As we know Value types cannot be null. Using this Constraint will allow our values to be null & not null.
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        //If Object Has a Value...
        public bool HasValue
        {
            get { return _value != null;}
        }

        //If Number has a Value Return it, or send back a default value.
        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}