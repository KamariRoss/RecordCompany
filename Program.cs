using System;
using RecordCompany.Models;
using System.Linq;

namespace RecordCompany.Models
{
    class Program
    {
        static void Main(string[] args)
        {

            var manager = new RecordManager();
            Console.WriteLine("“Welcome to your record management system. What would you like to do?");

            var SelectOption = true;
            while (SelectOption)
            {
                Console.WriteLine("Your options are , (SIGN), (PRODUCE ALBUM), (NEGOTIATE))");
                Console.WriteLine("(VIEW ALBUMS BY BAND), (VIEW ALBUMS BY REALEASE ), (VIEW ALBUMS BY SONG),");
                Console.WriteLine("(SIGNED BANDS), (UNSIGNED BANDS), (QUIT)");
                var input = Console.ReadLine().ToLower();
                if (input == "sign")
                {
                    // Add a band
                    manager.AddBand();
                }
                else if (input == "produce album")
                {
                    manager.AddAlbum();
                }
                else if (input == "negotiate")
                {
                    manager.ChangeEsign();
                }
                else if (input == "quit")
                {
                    Console.WriteLine("Have a nice day ");
                    SelectOption = false;
                }
                else if (input == "signed bands")
                {
                    manager.ViewSignedBands();
                }
                else if (input == "unsigned bands")
                {
                    manager.ViewDroppedBands();
                }
                else if (input != "sign" && input != "produce" && input != "let band go" && input != "resign band" && input != "view albums by band" && input != "view albums by release" && input != "view albums by song" && input != "view signed bands" && input != "view signed bands" && input != "quit") ;
                {
                    //Console.WriteLine("You entered a incorrect answer please try again");
                }
            }


        }
    }
}
