using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static attribute is a shows all that is shared by the objects of that class
            //its an attribute onn the class itself not on the individuals member of that class, it s about the class
            Songs holiday = new Songs("Holiday", "Green Day", 200);
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;
        
        public static int songCount = 0; // declaration of the static attribute
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++; //increment each time a song is added
        }

    }
}
