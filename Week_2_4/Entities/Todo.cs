using Week_2_4.Abstract;
using Week_2_4.Common;

namespace Week_2_4.Entities
{
    public class Todo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To-Do: {Title}");
        }
    }
}
