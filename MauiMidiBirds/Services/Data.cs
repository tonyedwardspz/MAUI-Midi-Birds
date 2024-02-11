using MauiMidiBirds.Models;

namespace MauiMidiBirds.Services;

internal class Data
{
    public static List<Bird> Birds { get; } = new List<Bird>
    {
        new() {
            Id = 48,
            CommonName = "Robin",
            ImageCredit = "Tony Edwards",
            SongCredit = "RSPB",
            Sightings = 37
        },
        new() {
            Id = 49,
            CommonName = "Gray Heron",
            ImageCredit = "Sophie",
            SongCredit = "Tony Edwards",
            Sightings = 1
        },
        new() {
            Id = 50,
            CommonName = "Jackdaw",
            ImageCredit = "Hedera Baltica",
            SongCredit = "Tony Edwards",
            Sightings = 20
        },
        new() {
            Id = 51,
            CommonName = "Blackbird",
            ImageCredit = "Manx John",
            SongCredit = "Tony Edwards",
            Sightings = 9
        },
        new() {
            Id = 52,
            CommonName = "Wood Pigeon",
            ImageCredit = "Sophie",
            SongCredit = "RSPB",
            Sightings = 14
        },
        new() {
            Id = 53,
            CommonName = "House Sparrow",
            ImageCredit = "Lip Kee",
            SongCredit = "Tony Edwards",
            Sightings = 76
        },
        new() {
            Id = 54,
            CommonName = "Great Tit",
            ImageCredit = "Sergey Yeliseev",
            SongCredit = "Tony Edwards",
            Sightings = 18
        },
        new() {
            Id = 55,
            CommonName = "Herring Gull",
            ImageCredit = "Tony Edwards",
            SongCredit = "Tony Edwards",
            Sightings = 22
        },
        new() {
            Id = 56,
            CommonName = "Raven",
            ImageCredit = "Martin Pilát",
            SongCredit = "Tony Edwards",
            Sightings = 4
        },
        new() {
            Id = 57,
            CommonName = "Collared Dove",
            ImageCredit = "Peter O'Connor",
            SongCredit = "RSPB",
            Sightings = 26
        },
        new() {
            Id = 58,
            CommonName = "Wren",
            ImageCredit = "Koshyk",
            SongCredit = "Tony Edwards",
            Sightings = 12
        },
        new() {
            Id = 59,
            CommonName = "Tawny Owl",
            ImageCredit = "Sue Crow",
            SongCredit = "Tony Edwards",
            Sightings = 3
        },
        new() {
            Id = 60,
            CommonName = "Buzzard",
            ImageCredit = "Ferran Pestaña",
            SongCredit = "RSPB",
            Sightings = 4
        },
        new() {
            Id = 61,
            CommonName = "Firecrest",
            ImageCredit = "Mike Prince",
            SongCredit = "It's Tony!",
            Sightings = 3
        },
        new() {
            Id = 62,
            CommonName = "Starling",
            ImageCredit = "Bernard Spragg",
            SongCredit = "RSPB",
            Sightings = 1
        },
        new() {
            Id = 63,
            CommonName = "Rook",
            ImageCredit = "foxypar4",
            SongCredit = "RSPB",
            Sightings = 18
        },
        new() {
            Id = 64,
            CommonName = "Long Tailed Tit",
            ImageCredit = "Sergey Yeliseev",
            SongCredit = "Tony Edwards",
            Sightings = 19
        },
        new() {
            Id = 65,
            CommonName = "Loon",
            ImageCredit = "Keith Carver",
            SongCredit = "It's Tony!",
            Sightings = 2
        },
        new() {
            Id = 66,
            CommonName = "Chaffinch",
            ImageCredit = "foxypar4",
            SongCredit = "Tony Edwards",
            Sightings = 4
        },
        new() {
            Id = 67,
            CommonName = "Blue Tit",
            ImageCredit = "Keith Ellwood",
            SongCredit = "Tony Edwards",
            Sightings = 21
        },
        new() {
            Id = 68,
            CommonName = "Spotted Flycatcher",
            ImageCredit = "Imran Shah",
            SongCredit = "It's Tony!",
            Sightings = 1
        },
        new() {
            Id = 69,
            CommonName = "Coal Tit",
            ImageCredit = "Andy Morffew",
            SongCredit = "RSPB",
            Sightings = 1
        },
        new() {
            Id = 70,
            CommonName = "Ruddy Turnstone",
            ImageCredit = "Tony Edwards",
            SongCredit = "Tony Edwards",
            Sightings = 1
        },
        new() {
            Id = 71,
            CommonName = "Dunnock",
            ImageCredit = "Steve Higgins",
            SongCredit = "Tony Edwards",
            Sightings = 37
        },
        new() {
            Id = 72,
            CommonName = "Goldfinch",
            ImageCredit = "Kev Chapman",
            SongCredit = "Tony Edwards",
            Sightings = 11
        }
    };
}
