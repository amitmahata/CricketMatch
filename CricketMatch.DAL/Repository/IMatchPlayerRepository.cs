using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketMatch.DAL.Repository
{
    public interface IMatchPlayerRepository
    {
        void AddMatchPlayer(MatchDetail matchDetail);
        MatchDetail GetData();
    }
}
