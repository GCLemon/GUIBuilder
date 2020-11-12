namespace Altseed2
{
    public abstract class GUIInput<T> : GUIItem
    {
        public T InputValue => _InputValue;
        protected T _InputValue;
    }
}