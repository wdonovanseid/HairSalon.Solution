using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string Details { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

    public static List<Stylist> Search(List<Stylist> allStylists, string searchParam)
    {
      List<Stylist> matchingStylists = new List<Stylist> { };
      if (searchParam != null)
      {
        foreach (Stylist stylist in allStylists)
        {
          if (stylist.Name.ToUpper().Contains(searchParam.ToUpper()))
          {
            matchingStylists.Add(stylist);
          }
          else if (stylist.Specialty.ToUpper().Contains(searchParam.ToUpper()))
          {
            matchingStylists.Add(stylist);
          }
        }
      }
      return matchingStylists;
    }

  }
}