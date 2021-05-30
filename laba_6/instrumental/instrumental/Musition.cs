
using System;
using System.Collections.Generic;
using System.Text;

namespace instrumental
{
    class Musition
    {

        public delegate void KeyboardListHandler(object source, InstrumentalListHandlerEventArgs instrumentalListHandlerEventArgs);

        public event KeyboardListHandler KeyPressed;

        public string Name { get; set; }


        public void Play(string sound, string typeOfSound)
        {
            KeyPressed?.Invoke(source: this, instrumentalListHandlerEventArgs: new InstrumentalListHandlerEventArgs(sound, typeOfSound));
        }
    }
}
