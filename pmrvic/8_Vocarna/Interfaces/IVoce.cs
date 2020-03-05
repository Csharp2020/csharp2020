namespace _8_Vocarna
{
    internal interface IVoce
    {
        string Boja { get; set; }

        event Voce.del_promjena_boje PromjenaBoje;
    }
}