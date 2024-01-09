namespace desafio_poo

{
    public class Iphone : Smartphone
    {
        public Iphone(string numero,string modelo, string imei, int memoria) : base(numero,modelo, imei, memoria)
        {
            Console.WriteLine("Iphone cadastrado!");
        }
    
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo: " + nomeApp + " está sendo instalado no iphone!");
        }

    }
}