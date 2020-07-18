using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using weekendtask.Models;
using weekendtask.MoviesDTO;
using weekendtask.Requests;

namespace weekendtask.Repository
{
    public class Movies : IMovies
    {
        private readonly MoviesDbContext mov;
        public Movies(MoviesDbContext db)
        {
            this.mov = db;
        }
        public bool AddReview(AddReviews request)
        {
            if (request != null)
            {
                Reviews newreview = new Reviews();
                newreview.reviews = request.reviews;
                newreview.movieName = request.movieName;
                mov.MyReviews.Add(newreview);
                mov.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Languages> AllLanguages()
        {
            return mov.Languages.ToList();
        }

        public List<MovieDTO> AllMoviesByLanguage(string language)
        {
           var lang= mov.Languages.Where(a => a.language == language).FirstOrDefault();
           var resultantList=mov.MyMovies.Include("Languages").Where(a => a.languageId == lang.languageId).ToList();
            List<MovieDTO> moviesByLang = new List<MovieDTO>();
            if (resultantList.Any())
            {
                foreach (var item in resultantList)
                {
                    moviesByLang.Add(new MovieDTO
                    {
                        movieId = item.movieId,
                        movieName = item.movieName,
                        language = item.Languages.language
                    });
                }
            }
            
            return moviesByLang;
        }





        public List<MovieReviewDTO> ReviewsByMovie(string movieName)
        {

            var review = mov.MyReviews.Where(a => a.movieName == movieName).ToList();
            List<MovieReviewDTO> movieReview = new List<MovieReviewDTO>();
            if (review.Any())
            {
                foreach (var item in review)
                {
                    movieReview.Add(new MovieReviewDTO
                    {
                        reviewId = item.reviewId,
                        review=item.reviews,
                        movieName=item.movieName
                    }) ;
                }
            }
            return movieReview;
        }
    }
}
