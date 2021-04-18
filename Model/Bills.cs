using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Bills{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public string period { get; set; }
    public string Estado { get; set; }
    public double Monto { get; set; }
    public string Category { get; set; }
    public string clientId { get; set; }
    public Client Client {get; set;}
}