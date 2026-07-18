using PokeApiConnection.PokeConnection;
using PokeBl.BL.PokemonBL;
using PokeBl.Model.Pokemon;
namespace PokeTest;

public class PokemonTest
{
    const string BASE_URL = "https://pokeapi.co/api/v2/pokemon/";
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SinglePokemonTest()
    {
        var pokeConnection = new PokeApiGet<Pokemon>();
        var pokeApiGet = new PokemonGet();

        Assert.Pass();
    }
}
