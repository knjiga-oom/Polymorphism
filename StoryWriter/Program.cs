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
                // following lines MUST NOT be changed!
                story.AddHeading("Naslov", 1);
                story.AddParagraphs(new string[]{ "Ovo je prvi odlomak", "Ovo je drugi odlomak"});
                story.AddHeading("Podnaslov", 2);
                story.Hyperlink("Ovo je link na", "www.amazon.com");
                story.AddParagraphs(new string[] { "Ovo je treći odlomak" });

                writer.Write(story.ToString());

                Console.WriteLine(story.ToString());
            }

            using (TextWriter writer = new StreamWriter("MojStranica.html"))
            {
                // TODO: When everythin is done, following lines should be uncomented to generate a regular HTML page

                //Story story = new Story(new HtmlFormatter());
                //story.AddHeading("Naslov", 1);
                //story.AddParagraphs(new string[] { "Ovo je prvi odlomak", "Ovo je drugi odlomak" });
                //story.AddHeading("Podnaslov", 2);
                //story.Hyperlink("Ovo je link na", "www.amazon.com");
                //story.AddParagraphs(new string[] { "Ovo je treći odlomak" });

                //writer.Write(story.ToString());
            }
        }
    }
}
