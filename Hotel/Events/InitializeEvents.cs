using HotelEvents;
using System;
using System.Threading;

namespace Hotel.Events
{
    class InitializeEvents : HotelEventListener
    {
        //Constants
        private const int SleepTime = 1000;

        /// <summary>
        /// Notifies the listiner with what events need to be run
        /// </summary>
        /// <param name="evt"> evt stands for the event that stands within the enum in HotelEventType</param>
        public void Notify(HotelEvent evt)
        {
            Thread.Sleep(SleepTime);
            switch (evt.EventType)
            {
                case HotelEventType.CHECK_IN:
                    Window.HotelGame.AddPerson();                   //Adds a person to the hotel and adds them to the list
                    break;
                case HotelEventType.CHECK_OUT:
                    //Add an Checkout movement here
                    break;
                case HotelEventType.CLEANING_EMERGENCY:
                    //Add an Cleaning job here
                    break;
                case HotelEventType.EVACUATE:
                    //Add an method for all persons to evacuate the building
                    break;
                case HotelEventType.GODZILLA:
                    //???
                    break;
                case HotelEventType.GOTO_CINEMA:
                    //Let a person walk to the cinema
                    break;
                case HotelEventType.GOTO_FITNESS:
                    //Let a person walk to the fitness area
                    break;
                case HotelEventType.NEED_FOOD:
                    //Let a person walk to the restaurant to get some food
                    break;
                default:
                    Console.WriteLine(evt.Message);
                    break;
            }
        }
    }
}
