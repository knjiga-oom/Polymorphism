using System;
using System.IO;

namespace Vsite.Oom.Polymorhism
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = new StreamWriter("MojText.txt"))
            {
                StoryWriter story = new StoryWriter(writer);
                story.WriteHeading("Naslov");
                story.WriteParagraph("Ovo je prvi odlomak");
                story.WriteHyperlink("Ovo je link na", "www.amazon.com");
                story.WriteParagraph("Ovo je drugi odlomak");

                Console.WriteLine(writer.ToString());
            }
        }
    }
}
