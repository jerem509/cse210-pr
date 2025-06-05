using System;

class Program
{
    static void Main(string[] args)
    {
      
        List<List<string>> commentsVideo1 = new List<List<string>> 
        {
            new List<string> {"Helio","Je suis a Jeremie"}, 
            new List<string> {"CoolTroll","N'importe quoi."},
            new List<string> {"Helio","Tu veux parler de quoi toi. Lance."}
        };
        

        List<List<string>> commentsVideo2 = new List<List<string>> 
        {
            new List<string> {"Paul2345","Je vais au Japon."}, 
            new List<string> {"Eltapo","Bon voyage."},
            new List<string> {"Helio","Rien a voir avec ce cours."},
            new List<string> {"Echo509","On parle de ce qu'on veut. Tu peux aller voir ailleurs si ca te derange."}
        };
        
        List<List<string>> commentsVideo3 = new List<List<string>> 
        {
            new List<string> {"Paul2345","Les Nouvelles sont mauvaises."}, 
            new List<string> {"Eltapo","Ca date pas d'hier."},
            new List<string> {"Helio","La fin est proche."},
            new List<string> {"Echo509","Assez!"}
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