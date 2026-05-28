using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video
        {
            _name = "Me at the zoo",
            _author = "jawed",
            _length = 19,
            _comments = [
                new Comment("SanDiegoZoo","We're so honored that the first ever Youtube Video was filmed here!"),
                new Comment("kedsarama","Honestly so glad to hear that Jawed agrees that removing dislikes is stupid."),
                new Comment("theOGabishek12","Who is watching in 27 may 2026?"),
                new Comment("TapL","Seeing \"20 years ago\" on a YouTube video makes me feel a certain type of way"),
                ] // just for fun I included real comments that exist on this video (by the way it was the first video ever uploaded to the site by one of the creators of Youtube!)
        };

        Video video2 = new Video
        {
            _name = "Baby Shark Dance",
            _author = "Pinkfong Baby Shark - Kids' Songs & Stories",
            _length = 137,
            _comments = [
                new Comment("SoccorMom1985","BABY SHARK DOODOODOODOODOODOO"),
                new Comment("edgy_kid12","This song is lame"),
                new Comment("tacolover97","Brings back so many memories...")
            ]
        };

        Video video3 = new Video
        {
            _name = "Charlie bit my finger! ORIGINAL",
            _author = "jasminmakeup",
            _length = 55,
            _comments = [
                new Comment("SoccorMom1985","SO CUTE XOXO"),
                new Comment("MrBeast","I wonder where these kids are now"),
                new Comment("tacolover97","So nostalgic...")
            ]
        };
        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}