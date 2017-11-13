using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DevExpress.VoteApp {

    public class CountyVote {
        public const string EmptyFIPS = "-";
        public string State { get; set; }
        public string FIPS { get; set; }
        public decimal PercentReported { get; set; }
        public int TotalVotesCount { get; set; }
        [ScriptIgnore]
        public bool IsAllDataReported {  get { return PercentReported >= 1; } }
        public List<CandidateVote> Votes { get; set; }
        public override string ToString() {
            return string.Format("{0}/{1} FIPS:{2}, total votes: {3}", State, GetCounty(), FIPS, TotalVotesCount);
        }
        public CountyInfo GetCounty() {
            return CountyInfo.Counties2010.FirstOrDefault(q => q.FIPS == FIPS);
        }
    }
    public class StateVote {
        public string State { get; set; }
        public string FIPS { get; set; }
        public int TotalVotesCount { get; set; }
        public bool HasCountyVotes { get; set; }
        public List<CandidateVote> Votes { get; set; }
        public List<CountyVote> CountyVotes { get; set; }
        public override string ToString() {
            return string.Format("{0}/{1} - {2}", State, FIPS, TotalVotesCount);
        }
    }

    public class CandidateVote {
        public CandidateType CandidateType {  get; set; }
        public string Name { get; set; }
        public int VotesCount { get; set; }
        public int ElectoralVotes { get; set; }
        public override string ToString() {
            return string.Format("{0}/{1} Votes:{2}{3}", Name, CandidateType, VotesCount, ElectoralVotes > 0 ? " Electoral:" + ElectoralVotes.ToString() : "");
        }
    }
    public class ElectionData {
        public string Title { get; set; }
        public bool IsPlayGround { get; set; }
        public string Year { get; set; }
        public DateTime SnapshotTime { get; set; }
        public List<StateVote> Votes { get; set; }
        public string Source { get; set; }
    }

    public enum CandidateType {
        Democrat, Republican, Other
    }

    public class StateInfo {
        internal StateInfo(string data) {
            var d = data.Split('|');
            if(d.Length > 2) {
                FIPS = d[0].Trim();
                State = d[1].Trim();
                Name = d[2].Trim();
            }
        }
        public string FIPS { get; set; }
        public string State { get; set; }
        public string Name { get; set; }

        static List<StateInfo> states;
        static Dictionary<string, StateInfo> stateToInfo;
        static Dictionary<string, StateInfo> GetStateToInfo() {
            if(stateToInfo == null) {
                stateToInfo = new Dictionary<string, VoteApp.StateInfo>(StringComparer.InvariantCultureIgnoreCase);
                foreach(var si in States) stateToInfo[si.State] = si;
            }
            return stateToInfo;
        }
        public static StateInfo GetState(string state) {
            StateInfo res;
            if(GetStateToInfo().TryGetValue(state, out res)) return res;
            return null;
        }
        public static List<StateInfo> States {
            get {
                if(states == null) states = GetStates();
                return states;
            }
        }
        static List<StateInfo> GetStates() {
            List<StateInfo> res = new List<StateInfo>();
            using(var stream = typeof(StateInfo).Assembly.GetManifestResourceStream("DevExpress.XtraGrid.Demos.VoteModule.Census.states.txt")) {
                using(var sr = new StreamReader(stream)) {
                    while(true) {
                        var line = sr.ReadLine();
                        if(line == null) break;
                        res.Add(new StateInfo(line));
                    }
                }
            }
            return res;

        }
    }
    public class CountyInfo {
        public CountyInfo(string countyLine) {
            var d = countyLine.Split(',');
            if(d.Length > 4) {
                State = d[0].Trim();
                StateFIPS = d[1].Trim();
                CountyFIPS = d[2].Trim();
                CountyName = d[3].Trim();
                CountyType = d[4].Trim();
            }
        }
        public string State { get; set; }
        public string StateFIPS { get; set; }
        public string CountyFIPS { get; set; }
        public string FIPS { get { return StateFIPS + CountyFIPS; } }
        public string CountyName { get; set; }
        public string CountyType { get; set; }
        static List<CountyInfo> counties2010;
        public static List<CountyInfo> Counties2010 {
            get {
                if(counties2010 == null) counties2010 = GetCounties2010();
                return counties2010;
            }
        }
        static Dictionary<string, CountyInfo> fipsToCounty2010;
        static Dictionary<string, CountyInfo> GetFipsToCounty2010() {
            if(fipsToCounty2010 == null) {
                fipsToCounty2010 = new Dictionary<string, CountyInfo>(StringComparer.InvariantCultureIgnoreCase);
                foreach(var si in Counties2010) fipsToCounty2010[si.FIPS] = si;
            }
            return fipsToCounty2010;
        }
        public static CountyInfo GetCounty(string fips) {
            CountyInfo res;
            if(GetFipsToCounty2010().TryGetValue(fips, out res)) return res;
            return null;
        }

        public bool IsMatchFIPS(string fips) {
            if(fips == FIPS) return true;
            if(FIPS[0] == '0' && FIPS.Substring(1) == fips) return true;
            return false;
        }
        public static List<CountyInfo> GetCounties2010() {
            List<CountyInfo> res = new List<CountyInfo>();
            using(var stream = typeof(StateInfo).Assembly.GetManifestResourceStream("DevExpress.XtraGrid.Demos.VoteModule.Census.counties.txt")) {
                using(var sr = new StreamReader(stream)) {
                    while(true) {
                        var raw = sr.ReadLine();
                        if(raw == null) break;
                        if(string.IsNullOrEmpty(raw.Trim())) continue;
                        res.Add(new CountyInfo(raw));
                    }
                }
            }
            return res;
        }
        public override string ToString() {
            return CountyName;
        }
    }

    public class ListVoteResults {
        public string Name { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public int RepVotes { get; set; }
        public int DemVotes { get; set; }
        public int OtherVotes { get; set; }
        public int RepElectoralVotes { get; set; }
        public int DemElectoralVotes { get; set; }
        public int TotalVotes { get; set; }

        public decimal DemPercents {  get { return Helpers.GetPercent(DemVotes, TotalVotes); } }
        public decimal RepPercents { get { return Helpers.GetPercent(RepVotes, TotalVotes); } }

        public int IntDemPercents {  get { return (int)(Math.Round(DemPercents * 100)); } }
        public int IntRepPercents { get { return (int)(Math.Round(RepPercents * 100)); } }
        public string CountyFIPS { get; set; }
    }
}
