Rhythm's gonna get you
For the past few lessons, we have chatted about and worked with data; for this project, we continue our journey into data and modeling a database. We are starting a record label company, and we a place to store our bands, albums, and songs. You are creating a console app that stores our companies information in a database.

Objectives
Practice working with SQL
Practice working with ORMs (EF Core)
Requirements
Create a console that allows a user to store and manage the company's bands, albums, and songs.

You can use the template we have been using, but you can also use the one we talked about today. You can install it by using the following command:

dotnet new --install SDG.templates.Console.Database::1.0.0
Also, feel free to use the package we talked about during the with me at 3 to help with the menu system.

Explorer Mode
Create a database that stores Albums, Bands, and Songs. They should have at least the following properties, use your best judgment for types. (I have left off the Foreign keys intentionally)

Album

Id
Title
IsExplicit
ReleaseDate
Band

Id
Name
CountryOfOrigin
NumberOfMembers
Website
Style
IsSigned
PersonOfContact
ContactPhoneNumber
Song

Id
Title
Lyrics
Length
Genre
For the relationships, add keys are needed to fulfill the following

1 Album has many Songs
1 Band has many Albums
Create an interface to let the user :

Sign a band (add a new band)
Produce and album (add a album, and add a few songs to that album)
Let go a band (update isSigned to false)
Resign a band (update isSigned to true)
View all albums for a band
View all the albums, ordered by ReleaseDate
View and Albums song
View All bands that signed
View all bands that are not signed
