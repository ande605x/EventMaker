using System;
using EventMaker;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace EventMaker.ViewModel
{
    public class EventViewModel : INotifyPropertyChanged
    {
        private DateTimeOffset _date;
        private TimeSpan _time;
        //private EventHandler Eh;
        private EventMaker.Handler.EventHandler eventHandler { get; set; }

        public Model.EventCatalogSingleton EListe { get; set; }


        public EventViewModel()
        {
            eventHandler = new EventMaker.Handler.EventHandler(this);

            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            EListe = new Model.EventCatalogSingleton();

            CreateEventCommand = new RelayCommand(eventHandler.CreateEvent);
            DeleteEventCommand = new RelayCommand(eventHandler.DeleteEvent);
        }

        private Model.EventCatalogSingleton myevent = Model.EventCatalogSingleton.Instance;
       
        public Model.EventCatalogSingleton MyEvent { get {return myevent; } }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }

        public ICommand CreateEventCommand { get; set; } // eller typen RelayCommand
        public RelayCommand DeleteEventCommand { get; set; }


        private Model.Event selectedEvent;

        public Model.Event SelectedEvent
        {
            get { return selectedEvent; }
            set
            {
                selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
