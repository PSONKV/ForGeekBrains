public class WorkContext : ApplicationDbContext
{

DbSet<Sensor> Sensors {get; set;}

}

public class Sensor
{
 public int sensorID {get; set;}
 public string parametrDescription {get; set;}
 
 public ConnectionType {get; set;}

}


enum ConnectionType
{
 USB,
 RS232,
 RS485,
 Wireless
}


