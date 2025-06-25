using AudioDevices1.Tracks;

namespace Tester
{
    namespace AudioDevices1.Tracks
    {
        public class Program
        {
            Track t1 = new Track(1, "Nelly Furtado", "Maneater");
            t1.AlbumSource = "Loose";
            t1.Length = new TimeSpan(0, 4, 31);
            t1.Style = Category.Pop;

            Console.WriteLine(t1.DisplayName);
            Console.WriteLine(t1.DisplayLength);
            Console.WriteLine("Tijd in seconden: {0}", t1.GetLengthInSeconds());
            Console.WriteLine("Category: {0}", t1.Style.ToString());
            Console.ReadLine();
        }
    }
}
