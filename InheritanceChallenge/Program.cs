namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi(70, "black", "A4");
            BMW bmw = new BMW(80, "white", "Z3");
            Car myCar = new Car(90, "gray");

            audi.ShowDetails();
            bmw.ShowDetails();
            myCar.ShowDetails();

            audi.Repair();
            bmw.Repair();
            myCar.Repair();
        }
    }
}