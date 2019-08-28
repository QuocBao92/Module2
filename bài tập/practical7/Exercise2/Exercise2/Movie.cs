using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Movie : IMovie
    {
        private int iD;
        private string name;
        private DateTime publishDate;
        private string director;
        private string subtitle;
        private float averageRate;

        public double[] RateList = new double[3];
        public double this [int index]
        {
            get
            {
                return RateList[index];
            }
            set
            {
                RateList[index] = value;
            }
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Director { get => director; set => director = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }
        public float AverageRate { get => averageRate; }

        public string Display()
        {
            return $"Name {name} PulishDate {publishDate} Director {director} Subtitle {subtitle} AverageRate {averageRate}";
        }

        public void Caculator()
        {
            double total = 0f;
            for(int i = 0;i< RateList.Length; i++)
            {
                total += RateList[i];
            }
            averageRate = (float)(total / RateList.Length);
        }
    }
}
