using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born.");
        }

        public Actor(string actorName) : this()
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set {
                var formattedName = value?.Trim();
                actorName = formattedName; 
            }
        }

        ////Minimize this with prop
        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        //Use prop
        public int ActorAge { get; set; }
        public string ActorDescription { get; set; } = "Regular actor";


        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns>Title</returns>
        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Books actor and not date specified
        /// </summary>
        /// <returns></returns>
        public string BookActor()
        {
            string details = "Booking can change if actor starts trouble."; //Use method chaining for avoid duplication
            return $"Actor {ActorName} is booked. {details}";
        }

        /// <summary>
        /// Books actor on a specific date
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if actor starts trouble.";
            return $"Actor {ActorName} is booked on {theDate}. {details}";
        }
    }
}
