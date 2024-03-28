using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223118
{
    internal class SayaTubeUser
    {
        private int id;
        private string userName;
        List<SayaTubeVideo> uploadedVideo;

        public SayaTubeUser(string username)
        {
            this.id = GenerateRandomId();
            //precondition
            Debug.Assert(username.Length <= 100 && username != null, "judul tidak ada atau panjang judul melebihi batas maksimal");

            this.userName = username;
            this.uploadedVideo = [];
        }
        public int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(10000, 99999); // Generate 5-digit random ID
        }

        public int GetTotalVideoPlayCount()
        {
            int count = 0;
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                count += uploadedVideo[i].GetPlayCount();
            }
            return count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "video tidak terdefinisi");
            Debug.Assert(video.GetPlayCount() <= int.MaxValue
                , "video tidak terdefinisi");
            this.uploadedVideo.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("==== video ====");
            Console.WriteLine($"User: {userName}");
            //post condition dengan output maksimal 8 film
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Debug.Assert(i < 8, "Film yang ditampilkan maksimal 8");
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideo[i].GetJudul()}");
                
            }
        }

        public string GetUserName()
        {
            return userName;
        }
    }
}
