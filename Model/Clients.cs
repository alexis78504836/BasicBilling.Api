using System.Collections.Generic;

public class Clients{
    public string ClientsId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Bills> Bills { get; set; }
    public Clients() {
        Bills = new List<Bills>();
    }
}