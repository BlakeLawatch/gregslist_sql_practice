using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslist_sql_practice.Services
{
    public class SportsService
    {

        private readonly SportsRepository _repository;
        public SportsService(SportsRepository repository)
        {
            _repository = repository;
        }

        internal Sport GetSportById(int sportId)
        {
            Sport sport = _repository.GetSportById(sportId);

            if (sport == null)
            {
                throw new Exception($"Invalid ID: {sportId}");
            }

            return sport;
        }

        internal List<Sport> GetSports()
        {
            List<Sport> sports = _repository.GetSports();
            return sports;
        }
    }
}