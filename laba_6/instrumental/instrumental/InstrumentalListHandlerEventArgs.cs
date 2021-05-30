using System;
using System.Collections.Generic;
using System.Text;

namespace instrumental
{
    class InstrumentalListHandlerEventArgs : EventArgs
    {

        public string Sound { get; set;}

        public InstrumentalListHandlerEventArgs(string sound, string typeOfSound)
        {
            Sound = sound;
            TypeOfSound = typeOfSound;
        }

        public InstrumentalListHandlerEventArgs() { }

        public string TypeOfSound { get; set; }


        



    }
}
