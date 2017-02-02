using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.ViewModel;

namespace EventMaker.Handler
{
    public class EventHandler

    {
        public EventViewModel evm { get; set; }

        public EventHandler(EventViewModel Evm)
        {
            this.evm = Evm;
            
        }
        

        public void CreateEvent()
        {
            Model.Event tempEvent = new Model.Event();

            tempEvent.Id = evm.Id;
            tempEvent.Name = evm.Name;
            tempEvent.Description = evm.Description;
            tempEvent.Place = evm.Place;
            tempEvent.DateTime = Converter.DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(evm.Date,evm.Time);

            Model.EventCatalogSingleton.Instance.EventListe.Add(tempEvent);
            
            

            // Model.EventCatalogSingleton.Instance.EventListe.Add(new Model.Event() { });

        }

        public void DeleteEvent()
        {
            Model.EventCatalogSingleton.Instance.Remove(evm.SelectedEvent);
        }
    }
}
