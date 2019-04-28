using HotelEvents;

namespace Hotel.Events
{
    class EventStart
    {
        public void StartEventChecker()
        {
            InitializeEvents events = new InitializeEvents();   //Builds a new initializer
            HotelEventManager.Register(events);                 //Registers the initializer
            HotelEventManager.Start();                          //Starts the Initializer
        }   
    }
}
