using ConsoleApp1;
using Pokedex;

//var pikatchu = new {Health = 100, Level = 10 };

//var Pikatchu = new Pikatchu(12, 35); // instansierer klassen Pikatchu!!!

//var Bulbasaur = new Bulbasaur(100, 55); // instansierer klassen Bulbasaur!!!


var poke1 = new Pokemon("Pikatchu", 100, 10);
var poke2 = new Pokemon("Bulbasaur", 100, 55);
var poke3 = new Pokemon("Charmander", 100, 20);
var poke4 = new Pokemon("Squirtle", 100, 30);
var testPokemon = new Pokemon("TestPokemon");

Console.WriteLine($"Du har funnet {poke1.Name} og {poke2.Name} og {poke3.Name} og {poke4.Name}");

//Console.WriteLine($"Bulbasaur har {Bulbasaur.Health}hp og er level {Bulbasaur.Level}");
//Console.WriteLine($"Pikatchu har {Pikatchu.Health}hp og er level {Pikatchu.Level}");