using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class CD
    {
        private int id;
        private string title;
        private string singer;
        private short numberSong;
        private int price;

        public CD()
        {

        }

        public CD (int ID, string title, string singer, short numberSong, int price)
        {
            this.id = ID;
            this.title = title;
            this.singer = singer;
            this.numberSong = numberSong;
            this.price = price;
        }

        public int ID { get => id; set { id = value; } }
        public string Title { get => title; set { title = value; } }
        public string Singer { get => singer; set { singer = value; } }
        public short NumberSong { get => numberSong; set { numberSong = value; } }
        public int Price { get => price; set { price = value; } }

        public void ToStringCD ()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", id, title, singer, numberSong, price);
        }
    }
}
