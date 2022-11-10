namespace CTDay3
{
    internal class CatAgeException : Exception
    {
        public CatAgeException() { }
        public CatAgeException(string message) : base(message) { }
        public CatAgeException(string message, Exception inner) : base(message, inner) { }
    }
}
