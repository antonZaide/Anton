using Anton.Areas.Identity.Data;
using Anton.Models;
using System;
using System.Linq;

namespace Anton.Areas.Identity.Data
{
    public static class Dbintializer
    {
        public static void Initialize(AntonContextDb context)
        {
            context.Database.EnsureCreated();

            if (context.Companies.Any())
            {
                return;
            }

            var companies = new Company[]
            {
                new Company {CompanyName = "Sue Records", Supervisor = "Juggy Murray" },
                new Company {CompanyName = "Sub Pop", Supervisor = "Bruce Pavitt" },
                new Company {CompanyName = "Warner Records", Supervisor = "Jack L. Warner" }
            };

            context.Companies.AddRange(companies);
            context.SaveChanges();

            var songs = new Song[]
{
                new Song {Title = "Along the Watchtower", DateReleased = DateTime.Parse("1968-07-22")},
                new Song {Title = "Come As You Are", DateReleased = DateTime.Parse("1991-04-29")},
                new Song {Title = "In the End", DateReleased = DateTime.Parse("2002-11-14")},
                new Song {Title = "Hey Joe", DateReleased = DateTime.Parse("1969-02-26")},
                new Song {Title = "Something In The Way", DateReleased = DateTime.Parse("1994-08-01")},
                new Song {Title = "What I've Done", DateReleased = DateTime.Parse("2005-04-11")},
                new Song {Title = "Purple Haze", DateReleased = DateTime.Parse("1970-09-12")},
                new Song {Title = "In the Bloom", DateReleased = DateTime.Parse("2001-02-27")},
                new Song {Title = "Little Wing", DateReleased = DateTime.Parse("1969-07-19")},
                new Song {Title = "Smells Like A Teen Spirit", DateReleased = DateTime.Parse("1993-08-18")},
                new Song {Title = "Points of Authority", DateReleased = DateTime.Parse("2002-09-14")},
                new Song {Title = "Voodoo Chile", DateReleased = DateTime.Parse("1970-11-19")},
                new Song {Title = "Who Knows", DateReleased = DateTime.Parse("1992-06-20")},
                new Song {Title = "Somewhere I Belong", DateReleased = DateTime.Parse("2004-04-17")},
                new Song {Title = "The Wind Cries Mary", DateReleased = DateTime.Parse("1968-04-13")},
                new Song {Title = "You know you are right", DateReleased = DateTime.Parse("1991-01-22")},
                new Song {Title = "New Divide", DateReleased = DateTime.Parse("2005-11-29")},
                new Song {Title = "All Apologies", DateReleased = DateTime.Parse("1969-12-19")},
                new Song {Title = "About A Girl", DateReleased = DateTime.Parse("1970-05-27")}
};

            context.Songs.AddRange(songs);
            context.SaveChanges();

            var artists = new Artist[]
            {
                new Artist {CompanyID = 1, ArtistID = 1, firstName = "Jimi", lastName = "Hendrix", band = "The Jimi Hendrix Experience", roles = "Lead Singer", ReportsToID = 5, street = "New Orleans", DOB = DateTime.Parse("1942-11-27")},
                new Artist {CompanyID = 1, ArtistID = 2, firstName = "Mitch", lastName = "Mitchell", band = "The Jimi Hendrix Experience", roles = "Drummer", ReportsToID = 1, street = "New Orleans", DOB = DateTime.Parse("1946-01-24")},
                new Artist {CompanyID = 1, ArtistID = 3, firstName = "Noel", lastName = "Redding", band = "The Jimi Hendrix Experience", roles = "Guitarist", ReportsToID = 5, street = "New Orleans", DOB = DateTime.Parse("1945-12-09")},
                new Artist {CompanyID = 1, ArtistID = 4, firstName = "Billy", lastName = "Cox", band = "The Jimi Hendrix Experience", roles = "Bassit", ReportsToID = 2, street = "New Orleans", DOB = DateTime.Parse("1939-10-12")},
                new Artist {CompanyID = 1, ArtistID = 5, firstName = "Micheal", lastName = "Jeffery", band = "The Jimi Hendrix Experience", roles = "Manager", ReportsToID = 1, street = "New Orleans", DOB = DateTime.Parse("1933-04-15")},
                new Artist {CompanyID = 2, ArtistID = 6, firstName = "Kurt", lastName = "Cobain", band = "Nirvana", roles = "Lead Singer", ReportsToID = 10, street = "Seattle", DOB = DateTime.Parse("1967-12-04")},
                new Artist {CompanyID = 2, ArtistID = 7, firstName = "Dave", lastName = "Grohl", band = "Nirvana", roles = "Drummer", ReportsToID = 6, street = "Seattle", DOB = DateTime.Parse("1969-07-02")},
                new Artist {CompanyID = 2, ArtistID = 8, firstName = "Kris", lastName = "Novoselic", band = "Nirvana", roles = "Guitarist", ReportsToID = 6, street = "Seattle", DOB = DateTime.Parse("1965-05-29")},
                new Artist {CompanyID = 2, ArtistID = 9, firstName = "Pat", lastName = "Smear", band = "Nirvana", roles = "Bassit", ReportsToID = 10, street = "Seattle", DOB = DateTime.Parse("1959-01-16")},
                new Artist {CompanyID = 2, ArtistID = 10, firstName = "Danny", lastName = "Goldberg", band = "Nirvana", roles = "Manager", ReportsToID = 6, street = "Seattle", DOB = DateTime.Parse("1950-11-07")},
                new Artist {CompanyID = 3, ArtistID = 11, firstName = "Chester", lastName = "Bennington", band = "Linkin Park", roles = "Lead Singer", ReportsToID = 16, street = "Phoenix", DOB = DateTime.Parse("1976-09-11")},
                new Artist {CompanyID = 3, ArtistID = 12, firstName = "Mike", lastName = "Shinoda", band = "Linkin Park", roles = "Drummer", ReportsToID = 16, street = "Phoenix", DOB = DateTime.Parse("1977-02-16")},
                new Artist {CompanyID = 3, ArtistID = 13, firstName = "Joe", lastName = "Hahn", band = "Linkin Park", roles = "Guitarist", ReportsToID = 11, street = "Phoenix", DOB = DateTime.Parse("1977-05-19")},
                new Artist {CompanyID = 3, ArtistID = 14, firstName = "Rob", lastName = "Bourbon", band = "Linkin Park", roles = "Bassit", ReportsToID = 11, street = "Phoenix", DOB = DateTime.Parse("1978-11-12")},
                new Artist {CompanyID = 3, ArtistID = 15, firstName = "Dave", lastName = "Farrell", band = "Linkin Park", roles = "Turntable", ReportsToID = 16, street = "Phoenix", DOB = DateTime.Parse("1976-07-02")},
                new Artist {CompanyID = 3, ArtistID = 16, firstName = "Rob", lastName = "McDermott", band = "Linkin Park", roles = "Manager", ReportsToID = 11, street = "Phoenix", DOB = DateTime.Parse("1968-03-10")}
            };

            context.Artists.AddRange(artists);
            context.SaveChanges();
        }
    }
}
