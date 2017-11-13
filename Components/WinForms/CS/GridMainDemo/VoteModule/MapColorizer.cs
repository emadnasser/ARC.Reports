using DevExpress.Utils.Drawing;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.VoteApp {
    public class VoteMapColorizer {
        public Color DemColor { get { return Color.FromArgb(255, Color.FromArgb(0, 84, 156, 189)); } }
        public Color RepColor { get { return Color.FromArgb(255, Color.FromArgb(0, 207, 64, 76)); } }
        public Color OtherColor { get { return Color.FromArgb(255, Color.Orange); } }
        public StateInfo StateFromMapAttribute(MapItemAttributeCollection attributes) {
            if(attributes == null) return null;
            var postalAttr = attributes["STUSPS"];
            if(postalAttr != null) {
                return StateInfo.GetState((postalAttr.Value ?? "").ToString());
            }
            return null;
        }
        public CountyInfo CountyFromMapAttribute(MapItemAttributeCollection attributes) {
            if(attributes == null) return null;
            var countyAttr = attributes["GEOID"];
            if(countyAttr != null) {
                return CountyInfo.GetCounty((countyAttr.Value ?? "").ToString());
            }
            return null;
        }
        public void ColorizeStateItems(ElectionData electionData, List<MapItem> mapItems) {
            if(electionData == null) return;
            foreach(var item in mapItems) {
                var state = StateFromMapAttribute(item.Attributes);
                if(state != null) {
                    var results = electionData.Votes.FirstOrDefault(q => q.State == state.State);
                    if(results != null) {
                        ColorizeStateItem(item, results);
                        continue;
                    }
                }
                ColorizeItemAsUnknown(item);

            }
        }
        public void ColorizeCountyItems(ElectionData electionData, List<MapItem> mapItems) {
            if(electionData == null) return;
            foreach(var item in mapItems) {
                var county = CountyFromMapAttribute(item.Attributes);
                if(county != null) {
                    var results = electionData.Votes.FirstOrDefault(q => q.State == county.State);
                    if(results != null && results.HasCountyVotes) {
                        var countyResults = results.CountyVotes.FirstOrDefault(q => q.FIPS == county.FIPS);
                        if(countyResults != null) ColorizeCountyItem(item, countyResults);
                        continue;
                    }
                }
                ColorizeItemAsUnknown(item);

            }
        }
        public bool IsColorByTotalVotes { get { return true; } }
        void ColorizeCountyItem(MapItem item, CountyVote results) {
            var maxVotes = results.Votes.Max(q => q.VotesCount);
            CandidateVote winnerVotes = maxVotes > 0 ? results.Votes.FirstOrDefault(q => q.VotesCount == maxVotes) : null;

            if(winnerVotes == null) {
                ColorizeItemAsUnknown(item);
                return;
            }
            ColorizeItemByWinner(item, results.TotalVotesCount, winnerVotes);
        }

        void ColorizeStateItem(MapItem item, StateVote results) {
            var maxVotes = results.Votes.Max(q => q.VotesCount);
            var maxElectoral = results.Votes.Max(q => q.ElectoralVotes);
            CandidateVote winnerElectoral = maxElectoral > 0 ? results.Votes.FirstOrDefault(q => q.ElectoralVotes == maxElectoral) : null;
            CandidateVote winnerVotes = maxVotes > 0 ? results.Votes.FirstOrDefault(q => q.VotesCount == maxVotes) : null;

            if(IsColorByTotalVotes || winnerElectoral == null) {
                if(winnerVotes == null) {
                    ColorizeItemAsUnknown(item);
                    return;
                }
                ColorizeItemByWinner(item, results.TotalVotesCount, winnerVotes);
                return;
            }
            if(winnerElectoral != null) {
                ColorizeItemByWinner(item, results.TotalVotesCount, winnerVotes, true);
            }
        }

        void ColorizeItemByWinner(MapItem item, int totalVotes, CandidateVote winnerVotes, bool ignoreGradient = false) {
            Color baseColor = ColorByType(winnerVotes.CandidateType);

            if(!ignoreGradient) {
                decimal percent = Helpers.GetPercent(winnerVotes.VotesCount, totalVotes);
                if(percent > 0.85m) {
                    baseColor = HSLColor.Darken(baseColor, 0.5);
                }
                else {
                    if(percent > 0.7m) {
                        baseColor = HSLColor.Darken(baseColor, 0.8);
                    }
                }
            }

            item.Fill = baseColor;
            item.HighlightedFill = baseColor;
            item.SelectedFill = baseColor;
        }
        void ColorizeItemAsUnknown(MapItem item) {
            item.SelectedFill = item.HighlightedFill = item.Fill = Color.LightGray; 
        }
        public Color ColorByType(CandidateType candidateType) {
            switch(candidateType) {
                case CandidateType.Republican: return RepColor;
                case CandidateType.Democrat: return DemColor;
            }
            return OtherColor;
        }
        internal Image GenerateImage(CandidateType candidateType) {
            Bitmap bi = new Bitmap(16, 16);
            using(Graphics g = Graphics.FromImage(bi)) {
                g.Clear(ColorByType(candidateType));    
            }
            return bi;
        }
    }
}
