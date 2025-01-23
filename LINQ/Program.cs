using LINQ;

var games = new List<Game>
{
    new Game {Title ="The Legend of Zelda" ,Genre ="Adventure",ReleaseYear=1986,Rating=9.5,Price=60},
    new Game {Title ="Super Mario Bros" ,Genre ="Platformer",ReleaseYear=1985,Rating=9.2,Price=50},
    new Game {Title ="Elden Ring" ,Genre ="RPG",ReleaseYear=2022,Rating=9.8,Price=20},
    new Game {Title ="Elden Ring 2" ,Genre ="RPG",ReleaseYear=2023,Rating=9.6,Price=20},
    new Game {Title ="Stardew Valley" ,Genre ="Simulation",ReleaseYear=2016,Rating=9.0,Price=15},
    new Game {Title ="Tetris" ,Genre ="Puzzle",ReleaseYear=1984,Rating=8.9,Price=10},
};

//var allGames = games.Select(x => x.Title);


//var rpgGames = games.Where(g => g.Genre == "RPG");


//var modernGames = games.Any(x => x.ReleaseYear > 2000); //true-false

//var sortedListByYear = games.OrderBy(x => x.ReleaseYear);
//foreach (var game in sortedListByYear)
//{
//    Console.WriteLine(game.Title + " - " + game.ReleaseYear);
//}


//var avgPrice = games.Average(x => x.Price);

//Console.WriteLine(avgPrice);


//var highestRating = games.Max(game => game.Rating);
//var bestGame = games.First(game => game.Rating == highestRating);
//Console.WriteLine(bestGame.Title);


//var gamesByGroup = games.GroupBy(x => x.Genre);
//foreach (var group in gamesByGroup)
//{
//    Console.WriteLine("Genre: "+group.Key);

//    foreach (var game in group)
//    {
//        Console.WriteLine(game.Title);
//    }
//}

//var budgetAdventureGames = games
//    .Where(g => g.Genre == "RPG" && g.Price <= 30)
//    .OrderByDescending(g => g.Rating)
//    .Select(g => g.Title + " - " + g.Price + " - " + g.Rating);

//foreach (var game in budgetAdventureGames)
//{
//    Console.WriteLine(game);
//}


//var paginatedGames = games.Skip(2).Take(2);

//foreach (var game in paginatedGames)
//{
//    Console.WriteLine(game.Title);
//}


//var cheapestGame = games.OrderBy(g => g.Price).First();
//Console.WriteLine(cheapestGame.Title);

//var genres = games.Select(game => game.Genre).Distinct();
//foreach (var game in genres)
//{
//    Console.WriteLine(game);
//}