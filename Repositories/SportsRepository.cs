using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslist_sql_practice.Repositories
{
    public class SportsRepository
    {

        private readonly IDbConnection _db;

        public SportsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Sport CreateSport(Sport sportData)
        {
            string sql = @"
            INSERT INTO sports (name, teams, inAmerica, watchable)
            VALUE(@Name, @Teams, @InAmerica, @Watchable);
            
            SELECT * FROM sports WHERE id = LAST_INSERT_ID();";

            Sport sport = _db.Query<Sport>(sql, sportData).FirstOrDefault();
            return sport;
        }

        internal void DestroySport(int sportId)
        {
            string sql = "DELETE FROM sports WHERE id = @sportId;";

            _db.Query<Sport>(sql, new { sportId }).FirstOrDefault();

        }

        internal Sport EditSport(int sportId)
        {
            string sql = $"SELECT FROM sports WHERE id = {sportId};";

            Sport sport = _db.Query(sql, new { sportId }).FirstOrDefault();
            return sport;
        }

        internal Sport GetSportById(int sportId)
        {
            string sql = $"SELECT * FROM sports WHERE id = @sportId;";

            Sport sport = _db.Query<Sport>(sql, new { sportId }).FirstOrDefault();
            return sport;
        }

        internal List<Sport> GetSports()
        {
            string sql = "SELECT * FROM sports;";

            List<Sport> sports = _db.Query<Sport>(sql).ToList();
            return sports;
        }
    }
}