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

        // foreach (var article in articles)
        // {
        //   Console.WriteLine(article.Id);
        //   Console.WriteLine(article.Title);
        //   Console.WriteLine(article.Url);
        // }
        
        var courses = new List<Course>();
        var courserCSharp = new Course("Fundamentos CSharp", "fundamento-csharp");
        var courserOOP = new Course("Fundamentos OOP", "fundamento-oop");
        var courseAspNet = new Course(" Fundamentos AspNet", "fundamento-AspNet");

        courses.Add(courserCSharp);
        courses.Add(courserOOP);
        courses.Add(courseAspNet);

        var careers = new List<Career>();
        var careerDotNet = new Career("Especializacao .Net", "especializacao-dotnet");
        var careerItem2 = new CareerItem(2, "Aprendendo C#", "", courserCSharp);
        var careerItem3 =  new CareerItem(3, "Fundamentos OOP","", courserOOP);
        var careerItem = new CareerItem(1, "Comece por aqui", "", courseAspNet);

        careers.Add(careerDotNet);
        careerDotNet.Items.Add(careerItem3);
        careerDotNet.Items.Add(careerItem2);
        careerDotNet.Items.Add(careerItem);

        foreach( var career in careers)
        {
          System.Console.WriteLine(career.Title);
          foreach(var careeritem in career.Items.OrderBy(x => x.Order))
          {
            System.Console.WriteLine($"{careeritem.Order} - {careeritem.Title}");
            System.Console.WriteLine(careeritem.Course.Title);
            System.Console.WriteLine(careeritem.Course.Level);
          }
        }
      }
    
  }
}