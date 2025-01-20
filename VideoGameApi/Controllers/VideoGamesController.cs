using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Id = 1,
                Title = "Spider-Man 2",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony Interactive Entertainment"
            },
            new VideoGame
            {
                Id = 2,
                Title = "The Legend of Zelda",
                Platform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },

            new VideoGame
            {
                Id = 3,
                Title = "Cyberpunk 2077",
                Platform = "PC",
                Developer = "CD Project Red",
                Publisher = "CD Project"
            }

        };

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public ActionResult<VideoGame> GetVideoGameById(int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(game);
        }
        [HttpPost]
        public ActionResult<VideoGame> CreateVideoGame(VideoGame newGame)
        {
            if (newGame == null)
            {
                return BadRequest();
            }
            newGame.Id = videoGames.Max(x => x.Id) + 1;
            videoGames.Add(newGame);
            return CreatedAtAction(nameof(GetVideoGameById),new {id = newGame.Id},newGame);
        }
        [HttpPut]
        public IActionResult UpdateVideoGame(VideoGame newGame)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == newGame.Id);
            if(game is null)
                return BadRequest();

            game.Title = newGame.Title;
            game.Platform = newGame.Platform;
            game.Publisher = newGame.Publisher;
            game.Developer = newGame.Developer;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideoGame(int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            if (game is null)
                return NotFound();
            videoGames.Remove(game);
            return NoContent();
        }
    }
}
