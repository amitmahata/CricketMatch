using CricketMatch.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricketMatch.UI.Models
{
    public class MatchPlayerViewModel
    {
        public string MatchName { get; set; }
        public DateTime MatchDate { get; set; }
        public string TeamOne { get; set; }
        public string TeamTwo { get; set; }
        public TimeSpan StartTime { get; set; }
        public string Address { get; set; }
        public List<PlayerDetail> Players { get; set; }
    }
}