using AutoMapper;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadWrite
{
    public class RatingReadWriteRepository : IReadWriteRepository<Ratings>
    {

        private FilmMoiContext _context;
        public IMapper _mapper;
        public RatingReadWriteRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Create(Ratings data, CancellationToken cancellationToken)
        {
            try
            {
               if(data.Rating >= 1 || data.Rating <= 5)
               {
                    data.CreatedTime = DateTime.UtcNow;
                    _context.Ratings.Add(data);

                    var Film = _context.Films.Find(data.ID_Film);
                    var ratings = _context.Ratings.Where(x => x.ID_Film == data.ID_Film);
                    double ratingvalue = ratings.Average(x => x.Rating);
                    Film.AvgRating = Int32.Parse(ratingvalue.ToString());
                    _context.Films.Update(Film);

                    await _context.SaveChangesAsync();
                    return await Task.FromResult(true);
               }
                return await Task.FromResult(false);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id, Ratings? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetByID(data.ID_Film, data.ID_User);
                if (obj != null)
                {
                    _context.Ratings.Remove(obj);
                    await _context.SaveChangesAsync();
                }
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
           
        }

        public async Task<bool> Update(Guid id, Ratings data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetByID(data.ID_Film, data.ID_User);
                if (obj != null && (data.Rating <= 5 && data.Rating >= 1))
                {
                    obj.Rating = data.Rating;
                    _context.Ratings.Update(obj);
                    await _context.SaveChangesAsync();
                    return await Task.FromResult(true);
                }
                return await Task.FromResult(false);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        } 

        private async Task<Ratings> GetByID(Guid idFilm,Guid idUser) 
        {
            var obj = await _context.Ratings.FirstOrDefaultAsync(x => x.ID_User == idUser && x.ID_Film == idFilm);
            return obj;
        }
    }
}
