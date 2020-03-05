namespace _8_Vocarna
{
    internal interface IApples
    {
        Apple this[int index] { get; }
        string MjenjajBoju(string boja);
    }
}