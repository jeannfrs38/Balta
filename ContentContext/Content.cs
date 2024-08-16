using System.Reflection.Emit;

namespace Balta.ContentContext
{
  public abstract class Content
  {
    public Guid Id { get; set; }
    public string Title { get; set; }

    public string Url { get; set; }

    public Content()
    {
      Id = Guid.NewGuid();
    }
  }
}