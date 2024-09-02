//using KageDating.Data;
//using KageDating.Models;
//using Microsoft.EntityFrameworkCore;

//namespace KageDating.Services
//{
//    public class CityService : ICityService
//    {
//        private readonly DataContext _context;
//        public CityService(DataContext context)
//        {
//            _context = context;
//        }

//        public async Task AddCityAsync(City city)
//        {
//            await _context.SaveChangesAsync();
//        }

//        public async Task DeleteCityAsync(int id)
//        {
//            var city = await _context.Cities.FindAsync(id);
//            if (city != null)
//            {
//               await _context.SaveChangesAsync();
//            }

//        }

//        public async Task<List<City>> GetAllCitiesAsync()
//        {
//            var result = await _context.Cities.ToListAsync();
//            return result;
//        }

//        public async Task<City> GetCityByIdAsync(int id)
//        {
//            var city = await _context.Cities.FindAsync(id);
//            return city;
//        }

//        public async Task UpdateCityAsync(City city, int id)
//        {
//            var dbCity = await _context.Cities.FindAsync(id);
//            if (dbCity != null)
//            {
//                dbCity.CityId = city.CityId;
//                dbCity.CityName = city.CityName;
//                await _context.SaveChangesAsync();
//            }
//        }
//    }
//}
