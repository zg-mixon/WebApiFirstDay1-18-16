using IntroToWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace IntroToWebApi.Controllers
{
    public class MoviesController : ApiController
    {

        //Static lists exist on the class itself
        public static IList<Movie> _movies = new List<Movie>() {
            new Movie() {
                    Id = 0,
                    Title = "Star Trek"
            }
        };
        public Movie Get(int id) {
            return _movies.First(x => x.Id == id);
        }


        public IHttpActionResult Post(MovieBattle battle) {
            _movies.Add(battle.movieA);
            _movies.Add(battle.movieB);
            return Ok();

        }

        public IHttpActionResult Post(int id, Movie changes) {
            var dbMovie = _movies.First(x => x.Id == id);
            dbMovie.Id = changes.Id;
            dbMovie.Title = changes.Title;
            dbMovie.Genre = changes.Genre;
            dbMovie.ReleaseDate = changes.ReleaseDate;
            return Ok();


        }
    }
}


            

