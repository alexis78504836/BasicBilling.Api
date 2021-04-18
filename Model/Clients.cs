using System.Collections.Generic;

public class Client{
    public string clientId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Bills> Bills { get; set; }
    public Client() {
        Bills = new List<Bills>();
    }
}