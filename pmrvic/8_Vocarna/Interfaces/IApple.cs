namespace _8_Vocarna
{
    internal interface IApple
    {
        double Tezina { get; set; }

        event Apple.del_promjena_tezine PromjenaTezine;
    }
}