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
            "Jatuh cinta seperti di film-film",
            "Dune",
            "Yuni",
        ];
        SayaTubeUser saya = new SayaTubeUser("Rakha");
        for (int i = 0; i < films.Count; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {films[i]} oleh {saya.GetUserName()}");
            // Menambahkan 100 pemutaran ke video
            for (int j = 0; j <= i * 120; j++)
            {
                video.IncreasePlayCount(2000000);
            }
            saya.AddVideo(video);
        }
        saya.PrintAllVideoPlayCount();
    }
}