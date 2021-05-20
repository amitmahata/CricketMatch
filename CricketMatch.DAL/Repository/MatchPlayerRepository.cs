using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketMatch.DAL.Repository
{
    public class MatchPlayerRepository: IMatchPlayerRepository
    {
        public void AddMatchPlayer(MatchDetail matchDetail)
        {
            try
            {
                using  (MatchPlayerEntities db  =  new MatchPlayerEntities())
                    {
                        db.MatchDetails.Add(matchDetail);
                        db.SaveChanges();
                    }
            }
            catch(SqlException ex)
            {
                throw;
            }
        }

        public MatchDetail GetData()
        {
            try
            {
                using (MatchPlayerEntities db = new MatchPlayerEntities())
                {
                    return db.MatchDetails.FirstOrDefault();                
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}
