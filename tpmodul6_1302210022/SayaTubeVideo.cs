using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210022
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public SayaTubeVideo(string title)
        {
            try
            {
                if(string.IsNullOrEmpty(title) || title.Length > 100)
                {
                    throw new ArgumentException("Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null");
                }

                this.id = new Random().Next(10000, 99999);
                this.title = title;
                this.playcount = 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void IncreasePlayCount(int count)
        {
            try
            {
                checked
                {
                    if (count > 10000000 || count < 0)
                    {
                        throw new OverflowException("Play count tidak boleh lebih dari 10.000.000 atau kurang dari 0.");
                    }
                    playcount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play count: " + this.playcount);
        }
    }
}
