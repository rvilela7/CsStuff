using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born.");
            //this.currentAgency = new Agency(); //Implicit inicialization
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

        private Agency currentAgency;

        public Agency CurrentAgency
        {
            get {
                if (currentAgency == null) //lazy load
                {
                    currentAgency = new Agency();
                }
                return currentAgency; 
            }
            set { currentAgency = value; }
        }



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

        public string GetAgency()
        {
            //var currentAgency = new Agency();
            return CurrentAgency.Name;
        }

    }
}
