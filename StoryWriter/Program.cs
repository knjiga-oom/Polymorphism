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
                Story story = new Story(new PlainTextFormatter());
                story.AddHeading("Naslov", 1);
                story.AddParagraphs(new string[]{ "Ovo je prvi odlomak", "Ovo je drugi odlomak"});
                story.AddHeading("Podnaslov", 2);
                story.Hyperlink("Ovo je link na", "www.amazon.com");
                story.AddParagraphs(new string[] { "Ovo je treći odlomak" });

                writer.Write(story.ToString());

                Console.WriteLine(story.ToString());
            }
        }
    }
}
