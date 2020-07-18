using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weekendtask.Models;
using weekendtask.MoviesDTO;
using weekendtask.Requests;

namespace weekendtask.Repository
{
    public interface IMovies
    {

        List<Languages> AllLanguages();

        List<MovieDTO> AllMoviesByLanguage(string language);

        List<MovieReviewDTO> ReviewsByMovie(string movieName);

        bool AddReview(AddReviews request);

    }
}
