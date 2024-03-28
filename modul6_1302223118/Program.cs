using modul6_1302223118;

internal class Program
{

    private static void Main(string[] args)
    {
        List<string> films = [
        "Up",
            "Soul",
            "Pinochio Guilermo del Toro",
            "Like & Share",
            "Penyalin Cahaya",
            "Dua Garis Biru",
            "Laskar Pelangi",
            "Dune",
            "Jatuh cinta seperti di film-film",
            "Yuni",
        ];
        SayaTubeUser saya = new SayaTubeUser("Rakha");
        for (int i = 0; i < films.Count; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {films[i]} oleh {saya.GetUserName()}");
            saya.AddVideo(video);
        }
        Console.WriteLine("Hello, World!");
        saya.PrintAllVideoPlayCount();
            } }