using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
 public class Lecture
  {
        public Lecture(int ordem, string title, int durantionInMinutes, EContentLevel level)
        {
            Ordem = ordem;
            Title = title;
            DurantionInMinutes = durantionInMinutes;
            Level = level;
        }

        public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurantionInMinutes { get; set; }

    public EContentLevel Level { get; set; }
  }
}