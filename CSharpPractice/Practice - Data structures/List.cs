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

    }
}
