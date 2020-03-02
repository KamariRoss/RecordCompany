using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RecordCompany.Models
{
    // this all going to be a class that interacts with the database
    // List<Things> => DataContext
    public class RecordManager
    {

        public DatabaseContext db { get; set; } = new DatabaseContext();
        public void AddBand()
        {

            // get the band 
            Console.WriteLine("What is your band name?");
            var BandName = Console.ReadLine();
            Console.WriteLine("What country are they from?");
            var BandCountry = Console.ReadLine().ToLower();
            Console.WriteLine("How many members are in the band?");
            var BandMembers = int.Parse(Console.ReadLine());
            // validate intagar output
            Console.WriteLine("What is their website");
            var BandWebsite = Console.ReadLine().ToLower();
            Console.WriteLine("What is their style (genre)");
            var BandStyle = Console.ReadLine().ToLower();
            Console.WriteLine("Are they signed with the company? y/n");
            var BandSigned = Console.ReadLine().ToLower();
            if (BandSigned != "yes" && BandSigned != "no")
            {
                var Signed = true;
                while (Signed)
                {
                    Console.WriteLine(" Please enter the correct answer");
                    BandSigned = Console.ReadLine().ToLower();
                    if (BandSigned == "yes" || BandSigned == "no")
                    {
                        Signed = false;
                    }
                    else if (BandSigned != "yes" || BandSigned != "no")
                    {
                        Console.WriteLine("Please try again");
                    }
                }
            }
            Console.WriteLine("Who is the person of contact");
            var BandContact = Console.ReadLine().ToLower();
            Console.WriteLine("What is their contact number");
            var BandNumber = Console.ReadLine();
            // validate intagar output

            // If the value in the string BandSigned is the word yes,
            // then isThisBandSigned will be true. If it is anything
            // else then isThisBandSigned will be false
            bool isThisBandSigned;
            if (BandSigned == "yes")
            {
                isThisBandSigned = true;
            }
            else
            {
                isThisBandSigned = false;
            }
            // bool isThisBandSignedOneLiner = (BandSigned == "yes");

            // create a new band by assigning the blueprint classes to values
            var band = new Band
            {
                Name = BandName,
                CountryOfOrigin = BandCountry,
                NumbersOfMembers = BandMembers,
                Website = BandWebsite,
                Style = BandStyle,
                IsSigned = isThisBandSigned,
                ContactPhoneNumber = BandNumber,
                PersonOfContact = BandContact
            };
            /*var totalBands = db.Band.Where(b => b.Album == null);
            // check to see what numbers have been taken
            //give it a number that is not reapeated
            foreach (var bandId in totalBands)
            {

            }
            */
            db.Band.Add(band);
            db.SaveChanges();

        }
        public void ChangeEsign()
        {
            // ask for user input which band would they like to change ?
            Console.WriteLine("Which band contract would you like to change?");
            // ask for user input
            // turn user input into a value
            var FindBand = Console.ReadLine();
            // create a function using the value and the where method to locate band
            var BandContract = db.Band.First(p => p.Name == ($"{FindBand}"));
            // ask user do they want there band signed or unsigned?
            Console.WriteLine("Do you want to sign or drop?");
            // user information is turned into a variable 
            var ContractDecision = Console.ReadLine().ToLower();
            // variable is compared to boolean and changed to true and false
            bool FinalDecision;
            if (ContractDecision == "sign")
            {
                FinalDecision = true;
            }
            else
            {
                FinalDecision = false;
            }
            BandContract.IsSigned = FinalDecision;
            db.SaveChanges();

            // save changes in data base

        }
        public void AddAlbum()
        {
            // Ask what the title of the album is
            Console.WriteLine("What is the title of the album?");
            // Turn the input of the user into a variable
            var albumName = Console.ReadLine();
            // Ask if the album is explicit
            Console.WriteLine("Is the Album explicit? yes or no?");
            // Turn user input into a value 
            var albumRating = Console.ReadLine();
            // use boolean to determine is explixcit
            bool albumExplicit;
            if (albumRating == "yes")
            {
                albumExplicit = true;
            }
            else
            {
                albumExplicit = false;
            }
            // ask the user what band the belong to
            Console.WriteLine("Which band does the album belong to?");
            var allbands = db.Band.OrderByDescending(b => b.Id);
            foreach (var band in allbands)
            {
                Console.WriteLine($"Your current bands are {band.Name} with the id of {band.Id}.");
            }
            Console.WriteLine("Please enter the Band ID number the album belongs to.");
            var albumToBand = int.Parse(Console.ReadLine());
            // add the album to the artist
            var albumToBandId = db.Band.Where(b => b.Id == albumToBand);
            var bandsAndAlbums = db.Band.Include(band => band.Albums);

            var album = new Album
            {
                Title = albumName,
                IsExplicit = albumExplicit,
                Album.BandID = albumToBandId,

            };

            // add songs to band
            // use add song method to insert into a method
            // attache db  to band
            // save changes to album in db
        }
        public void AddSong()
        {

        }
        public void ViewSignedBands()
        {
            var signedBands = db.Band.Where(b => b.IsSigned == true);
            foreach (var band in signedBands)
            {
                Console.WriteLine($"{band.Name} is signed with your label");
            }
        }
        public void ViewDroppedBands()
        {
            // create a Varible that will find all the bands whos signed equals false
            var droppedBands = db.Band.Where(b => b.IsSigned == false);
            foreach (var band in droppedBands)
            {
                Console.WriteLine($"{band.Name} is not signed with your label.");
            }


        } // print evey band that is dropped to user 

    }
}




// add the values to database
// save database









