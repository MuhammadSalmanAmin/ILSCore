using System;
using System.Collections.Generic;
using System.Text;

namespace ILS
{
    public class JsTreeViewModel
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }

        public State state { get; set; }
        public string level { get; set; }
        public string icon { get; set; }
        public string type { get; set; }
        public bool children { get; set; } // if node has sub-nodes set true or not set false
    }

    public class NewJSTreeVM
    {
        public string id { get; set; }
        public string level { get; set; }
        public State state { get; set; }
        public string icon { get; set; }
        public string text { get; set; }
      //  public bool children { get; set; }
        public string type { get; set; }
        public List<JsTreeViewModel> children { get; set; } // if node has sub-nodes set true or not set false
    }

    public class State
    {
        public State()
        {

        }
        public State(bool inOpened,bool inClosed)
        {
            opened = inOpened;
            closed = inClosed;
        }
        public bool opened { get; set; }
        public bool closed { get; set; }
    }
}
