using System;

class Program
{
    static void Main(string[] args)
    {
      
        List<Comment> commentsVideo1 = new List<Comment> 
        {
            new Comment ("Helio","Je suis a Jeremie"), 
            new Comment ("CoolTroll","N'importe quoi."),
            new Comment ("Helio","Tu veux parler de quoi toi. Lance.")
        };
        

        List<Comment> commentsVideo2 = new List<Comment> 
        {
            new Comment ("Paul2345","Je vais au Japon."), 
            new Comment ("Eltapo","Bon voyage."),
            new Comment ("Helio","Rien a voir avec ce cours."),
            new Comment ("Echo509","On parle de ce qu'on veut. Tu peux aller voir ailleurs si ca te derange.")
        };
        
        List<Comment> commentsVideo3 = new List<Comment> 
        {
            new Comment ("Paul2345","Les Nouvelles sont mauvaises."), 
            new Comment ("Eltapo","Ca date pas d'hier."),
            new Comment ("Helio","La fin est proche."),
            new Comment ("Echo509","Assez!")
        };
        

        List<Video> videoList = new List<Video> {
            new Video("Tout sur C#", "Charl Jonel", "10m:05s", commentsVideo1),
            new Video ("Tout sur Python", "Laks Akin", "50m:15s", commentsVideo2),
            new Video ("Tout autour", "Laks Akin", "08m:35s", commentsVideo3)
        };

        foreach (Video item in videoList)
        {
            item.DisplayVideoInfo();
        };
    }
}