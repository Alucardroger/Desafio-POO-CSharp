namespace desafio_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone I14 = new Iphone("37998423312", "Iphone 14 pro max", "001970-01-010000-0", 8);
            I14.Ligar();
            I14.ReceberLigacao();
            I14.InstalarAplicativo("Whatsapp");
            Smartphone noki = new Nokia ("37922223312", "Nokia C01 Plus", "001975-41-010200-6", 6);
            noki.Ligar();
            noki.ReceberLigacao();
            noki.InstalarAplicativo("Instagram");
        }
    }  
}

// TODO: Realizar os testes com as classes Nokia e Iphone
