using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace EventRegistration {

    public class FeaturedSessionsRotator {
        SessionList list;

        public FeaturedSessionsRotator(SessionList list) {
            this.list = list;
            CurrentId = new Random((int)DateTime.Now.Millisecond).Next(List.Count);
        }

        SessionList List { get { return list; } }
        int CurrentId { get; set; }

        public Session Current { get { return List[CurrentId]; } }
        public Session Next {
            get {
                CurrentId++;
                if(CurrentId == List.Count)
                    CurrentId = 0;
                return List[CurrentId];
            }
        }
        public Session Prev {
            get {
                CurrentId--;
                if(CurrentId < 0)
                    CurrentId = List.Count - 1;
                return List[CurrentId];
            }
        }
    }

}
