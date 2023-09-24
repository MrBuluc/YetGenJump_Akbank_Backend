using Week_2_4.Abstract;
using Week_2_4.Common;

namespace Week_2_4.Entities
{
    public class Meeting : Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (string guest in Guests)
            {
                Console.WriteLine($"Inviting: {guest}");
            }
        }
    }
}
