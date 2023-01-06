namespace CSharpPractice.Practice___Data_structures
{
    public class List
    {
        private List<string> _thingsInstagramUserCanControl;

        public enum Priority
        {
            Low,
            Medium,
            High
        }

        public enum Phone
        {
            Main,
            Secondary
        }


        public List()
        {
            _thingsInstagramUserCanControl = new List<string>() { "Frequency of usage", "Who they follow", "How to respond/react to content i.e posts, messages and stories", "Which instagram features to use" };
        }

        public void AddThingInstagramUserCanControl(string thing, Priority priority)
        {
            if (priority == Priority.Low)
                _thingsInstagramUserCanControl.Add(thing);
            else
            {
                var positionToAddThingInList = priority == Priority.Medium ? _thingsInstagramUserCanControl.Count / 2 : 0;
                _thingsInstagramUserCanControl.Insert(positionToAddThingInList, thing);
            }
        }

        public void PrintThingsInstagramUserCanControl()
        {
            Console.WriteLine("Things a instagram user have control over:");
            foreach (var thing in _thingsInstagramUserCanControl)
            {
                Console.WriteLine(thing);
            }
        }

        public List<List<(string, Phone)>> GetApplications()
        {
            var mainPhoneApplications = new List<(string, Phone)>();
            var secondaryPhoneApplications = new List<(string, Phone)>();
            //Ideally, the secondary phone will be used for personal learning so having no social media apps or communications should be prohibited on that phone
            mainPhoneApplications.Add(("Business apps", Phone.Main));
            mainPhoneApplications.Add(("Whatsapp", Phone.Main));
            mainPhoneApplications.Add(("Spotify", Phone.Main));
            mainPhoneApplications.Add(("Relationships", Phone.Main));
            mainPhoneApplications.Add(("Email", Phone.Main));
            mainPhoneApplications.Add(("YouTube", Phone.Main));
            mainPhoneApplications.Add(("Reliable app to keep up to date on dev stuff", Phone.Main));

            secondaryPhoneApplications.Add(("Spotify", Phone.Secondary));
            secondaryPhoneApplications.Add(("YouTube", Phone.Secondary));
            secondaryPhoneApplications.Add(("Podcast", Phone.Secondary));

            return new List<List<(string, Phone)>>() { mainPhoneApplications, secondaryPhoneApplications };
        }

        public void PrintApplicationsStrategy()
        {
            var phoneApplications = GetApplications();
            Console.WriteLine("Here's a strategy for the applications to be installed on each phone to achieve separation of concerns:");
            foreach(var phone in phoneApplications)
            {
                var applicationCount = phone.Count;
                var phoneType = phone.Select(p => p.Item2).First();
                Console.WriteLine($"Total of {applicationCount} applications to be installed and used on {phoneType} phone");
                foreach(var application in phone)
                {
                    Console.WriteLine($"{application.Item1} to be installed and used on {application.Item2} phone");
                }
            }
        }

    }
}
