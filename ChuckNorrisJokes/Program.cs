using System;
using ChuckNorrisJokesLib;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChuckNorrisJokes
{
    class Program   
    {
        static async Task Main(string[] args)
        {
           
            JokesGenerator jokesGenerator = new JokesGenerator();
            string randomJoke = await jokesGenerator.GetRandomJoke();

            Console.WriteLine(randomJoke);

            string[] categories = await jokesGenerator.GetCategories();

            for(int index = categories.Length - 1; index >= 0; index --)
            {
                Console.WriteLine(categories[index]);
            }
        } 
    }
}
