using System;
using Gtk;
using Gdk;
namespace bfbbtracker
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class Icon : Gtk.Bin
    {
        public Icon()
        {
            Build();
        }

        public string image_name
        {
            get { return image_id; }
            set {
                state = 0;
                images[0] = new Pixbuf($"res/{value}-Off.png");
                images[1] = new Pixbuf($"res/{value}-Half.png");
                images[2] = new Pixbuf($"res/{value}.png");
                image.Pixbuf = images[0];
            }
        }

        protected void OnEventboxButtonPressEvent(object o, ButtonPressEventArgs args)
        {
            if (args.Event.Button == 1 && args.Event.Type == EventType.ButtonPress)
            {
                switch (state) {
                    case 0:
                        state = 2;
                        image.Pixbuf = images[2];
                        break;
                    case 1:
                        state = 2;
                        image.Pixbuf = images[2];
                        break;
                    case 2:
                        state = 0;
                        image.Pixbuf = images[0];
                        break;
                }
            }
            if (args.Event.Button == 3 && args.Event.Type == EventType.ButtonPress)
            {
                switch (state)
                {
                    case 0:
                        state = 1;
                        image.Pixbuf = images[1];
                        break;
                    case 1:
                        state = 2;
                        image.Pixbuf = images[2];
                        break;
                    case 2:
                        state = 0;
                        image.Pixbuf = images[0];
                        break;
                }
            }
        }

        private Pixbuf[] images = { null, null, null };
        private int state;
        private string image_id = "";
    }
}
