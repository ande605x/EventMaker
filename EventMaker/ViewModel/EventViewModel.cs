using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        private Model.EventCatalogSingleton myevent = Model.EventCatalogSingleton.Instance;

        public Model.EventCatalogSingleton MyEvent { get {return myevent; } }
    }
}
