using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public int Money { get; set; }
    public ICollection<EngineerMachine> Engineers { get; }
  }
}