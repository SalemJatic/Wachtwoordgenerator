using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wachtwoord_generator
{
    class Event
    {
        public event EventHandler<EventArgs> Event1 = delegate { };

        public void StartEvent()
        {
            Event1(this, EventArgs.Empty);
        }

    }
}
