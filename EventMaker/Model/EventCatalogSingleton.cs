using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {
        private static EventCatalogSingleton instance = new EventCatalogSingleton();
        
        public static EventCatalogSingleton Instance
        {
            get { return instance; }
        } 

        public ObservableCollection<Event> EventListe { get; set; }

        public EventCatalogSingleton()
        {
            EventListe = new ObservableCollection<Event>();

            //Persistency.PersistencyService.LoadEventsFromJsonAsync();


            /* event 1*/
            EventListe.Add(new Event() { Id = 1, Name = "Metalica", Description = "SortKoncert", Place = "SortScene"});

            /* event 2*/
            EventListe.Add(new Event() { Id = 2, Name = "Bruno", Description = "BrunKoncert", Place = "BrunScene" });
        }

        public void AddEvent(Event newEvent)
        {
            // metode til at lave addere til liste
        
            EventListe.Add(newEvent);
            
            
            Persistency.PersistencyService.SaveEventAsJsonAsync(EventListe);
        }

        public void Remove(Event choseEvent)
        {
            EventListe.Remove(choseEvent);
            Persistency.PersistencyService.SaveEventAsJsonAsync(EventListe);
        }


    }
}
