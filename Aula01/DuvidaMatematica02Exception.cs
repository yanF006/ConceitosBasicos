// See https://aka.ms/new-console-template for more information

[Serializable]
internal class DuvidaMatematica02Exception : Exception
{
    public DuvidaMatematica02Exception()
    {
    }

    public DuvidaMatematica02Exception(string? message) : base(message)
    {
    }

    public DuvidaMatematica02Exception(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}