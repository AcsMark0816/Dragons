namespace jk
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Place> DragonPlace = FileManager.ReadPlace("places.csv");
            foreach(var d in DragonPlace)
            {
                Console.WriteLine(d);
            }
        }
    }
}
