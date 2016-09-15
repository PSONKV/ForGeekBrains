public class WorkContext : ApplicationDbContext
{

DbSet<Sensor> Sensors {get; set;}

}

public class Sensor
{
 public int sensorID {get; set;}
 public string parametrDescription {get; set;}
}