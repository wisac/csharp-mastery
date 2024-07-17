var movieList = new MovieRepository();
// linq to objects
var currentMovies = movieList.GetMovies()
                     .Where(m => m.Year > 2000)
                     .Select(b => b.Title);

foreach (var movie in currentMovies)
{
   Console.WriteLine(movie);
}

public class Movie
{
   public string Title { get; set; }
   public int Year { get; set; }
}

public class MovieRepository
{
   public IEnumerable<Movie> GetMovies()
   {
      return new List<Movie> {
         new Movie() {Title = "pursuit of happiness", Year = 2006},
         new Movie() {Title = "men of honour",Year = 2000},
         new Movie() {Title = "rudy", Year = 1993},
         new Movie() {Title = "peaceful warrior",Year = 2006},
         new Movie() {Title = "bezos", Year = 2023},
      };
   }
}