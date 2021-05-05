using System;

namespace RadioApp
{
        public class Radio
        {
            private int _channel = 1;
            private bool _on;

            public int Channel
            {
                get { return Channel; }
                set { Channel = value; }
            }


            public Radio()
            {

            }

            public Radio(int channel, bool on)
            {
                _channel = channel;
                _on = on;
            }

            public string Play()
            {
                return "";
            }

            public void TurnOn()
            {
                _on = true;
            }
            public void TurnOff()
            {
                _on = false;
            }

        }
}
