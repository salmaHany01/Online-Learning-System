using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineLearningSystem
{
    public class Course
    {
        public int id;
        public string name;
        public string prof;
        public string desc;
        public int price;
        public string duration;
        public int rating;

        public Course(int id, string name, string prof, string desc, int price, string duration, int rating)
        {
            this.id = id;
            this.name = name;
            this.prof = prof;
            this.desc = desc;
            this.price = price;
            this.duration = duration;
            this.rating = rating;
        }

        public Course()
        {
        }
    }
}