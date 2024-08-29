namespace Balta.NotificationContext
{
  public sealed class Notification
  {
   public Notification()
   {
    
   }

   public Notification(string property, string menssage)
   {
     Property = property;
     Menssage = menssage;
   }

   public string Property { get; set; }
   public string Menssage { get; set; }
  }
}