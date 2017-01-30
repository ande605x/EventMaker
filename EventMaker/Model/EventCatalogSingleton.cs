using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton instance = new EventCatalogSingleton();
        
        public static EventCatalogSingleton Instance
        {
            get { return instance; }
        } 

        public ObservableCollection<Event> Events { get; set; }

        public EventCatalogSingleton()
        {
            /* event 1*/
            Events.Add(new Event() { Id = 1, Name = "Metalica", Description = "SortKoncert", Place = "SortScene"});

            /* event 2*/
            Events.Add(new Event() { Id = 2, Name = "Bruno", Description = "BrunKoncert", Place = "BrunScene" });
        }

        public void Add(Event newEvent)
        {
            // metode til at lave addere til liste
        }


    }
}
