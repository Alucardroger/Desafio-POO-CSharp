namespace desafio_poo

{
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo, string imei, int memoria) : base(numero,modelo, imei, memoria)
        {
            Console.WriteLine("Nokia Cadastrado!");
        }
        public  override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo: " + nomeApp + " está sendo instalado no Nokia!");

        }
    }
}