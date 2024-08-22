using Balta.ContentContext;

namespace Balta
{
  class Program
  {
    
      private static void Main(string[] args)
      {
        var articles =  new List<Article>();
        articles.Add(new Article("Aprendendo sobre POO", "orientacao-a-objetos"));
        articles.Add(new Article("Aprendendo sobre c#", "aprendendo-csharp"));
        articles.Add(new Article("Aprendendo sobre sql", "aprendendo-sql"));

        foreach (var article in articles)
        {
          Console.WriteLine(article.Id);
          Console.WriteLine(article.Title);
          Console.WriteLine(article.Url);
        }
        
      }
    
  }
}