using System;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            var video1 = new Video("Explorando a Amazônia", "NaturezaViva", 420);
            var video2 = new Video("Tutorial C# para Iniciantes", "CodeAcademy", 900);
            var video3 = new Video("Top 10 Cenas de Filmes", "CinemaFan", 600);
            var video4 = new Video("Como Fazer Pão Caseiro", "ChefEmCasa", 480);

            video1.AddComment(new Comment("Alice", "Imagens incríveis!"));
            video1.AddComment(new Comment("Bob", "Adorei a parte dos animais."));
            video1.AddComment(new Comment("Clara", "Muito educativo."));
            video1.AddComment(new Comment("Daniel", "Quero visitar um dia!"));

            video2.AddComment(new Comment("Eva", "Excelente explicação."));
            video2.AddComment(new Comment("Felipe", "Me ajudou muito."));
            video2.AddComment(new Comment("Giovana", "Bem claro."));
            video2.AddComment(new Comment("Henrique", "Valeu!"));

            video3.AddComment(new Comment("Igor", "Amo a cena número 3!"));
            video3.AddComment(new Comment("Juliana", "Momentos clássicos."));
            video3.AddComment(new Comment("Karla", "Faltou Matrix!"));
            video3.AddComment(new Comment("Lucas", "Ótima seleção!"));

            video4.AddComment(new Comment("Marina", "Fiz e ficou ótimo!"));
            video4.AddComment(new Comment("Nicolas", "Muito fácil de seguir."));
            video4.AddComment(new Comment("Olga", "Delicioso!"));
            video4.AddComment(new Comment("Pedro", "Obrigado, chef!"));

            var videos = new List<Video> { video1, video2, video3, video4 };

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Duration: {video.LengthInSeconds} sec");
                Console.WriteLine($"number of Coments: {video.GetCommentCount()}");
                Console.WriteLine("Coments:");
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
                }
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}