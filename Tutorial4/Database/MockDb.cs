using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
public List<Appointement> Appointements { get; set; } = new List<Appointement>();
    public MockDb()
    {
        Animals.Add(new Animal(1,"Mruczek","Cat",6.2,"Brown"));
        Animals.Add(new Animal(2,"Azor","Dog",8.4,"White"));
        Animals.Add(new Animal(3,"Pazurek","Cat",3.7,"Orange"));
        Animals.Add(new Animal(4,"Andrzej","Dog",5.0,"Black"));
        Animals.Add(new Animal(5,"Bob","Cat",6.0,"Grey"));
        Animals.Add(new Animal(6,"Steve","Cat",3.5,"Brown"));
        
        Appointements.Add( new Appointement("2024-05-05", 1, "Checkup", 120));
        Appointements.Add(  new Appointement("2024-04-15", 1, "Vaccination", 180));
        Appointements.Add(  new Appointement("2024-01-25",2,"Checkup",120));
        Appointements.Add( new Appointement("2024-12-07",3,"Vaccination",180));
        Appointements.Add(  new Appointement("2024-03-10",5,"Bug removal",220));

    }

    
    
}