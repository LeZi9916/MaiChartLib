namespace MaiChartLib.Exceptions;

public class NoteTypeException : Exception
{
    public NoteTypeException(string s) : base(s)
    { }
    public NoteTypeException(string s,Exception innerException) : base(s,innerException)
    { }
}