using System;

namespace Common.Win {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Assembly, AllowMultiple = true)]
    public class OnlineRepoLocation : Attribute {
        readonly string _url;

        public OnlineRepoLocation(string url) {
            _url = url;
        }

        public string Url {
            get { return _url; }
        }
    }
}
