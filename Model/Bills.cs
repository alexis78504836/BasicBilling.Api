using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Bills{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public string Periodo { get; set; }
    public string Estado { get; set; }
    public double Monto { get; set; }
    public string ClientsId { get; set; }
    public int ServicesId { get; set; }
    public Clients Clients {get; set;}
    public Services Services { get; set; }
}