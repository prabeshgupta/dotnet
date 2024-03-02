using System;
namespace Week6.Task2
{

    public delegate void EventHandler(object sender, EventArgs e);


    public class Publisher
    {
        public event EventHandler MyEvent;

        public string publisherName = "Event Publisher";

        public void RaiseEvent()
        {
            Console.WriteLine("Event is about to be raised.");
            if (MyEvent != null)
            {
                MyEvent(this, EventArgs.Empty);
            }
        }
    }

    public class Subscriber
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Publisher publisher = (Publisher)sender;
            Console.WriteLine("Event handled by Subscriber and the publisher name is " + publisher.publisherName);
        }
    }

    class EventProgram
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.MyEvent += subscriber.HandleEvent;

            publisher.RaiseEvent();

            publisher.MyEvent -= subscriber.HandleEvent;

            publisher.RaiseEvent();
        }
    }
}