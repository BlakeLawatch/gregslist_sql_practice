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