using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> _animals = new List<Animal>()
    {
        new Animal(1,"Mruczek","Cat",6.2,"Brown"),
        new Animal(2,"Azor","Dog",8.4,"White"),
        new Animal(3,"Pazurek","Cat",3.7,"Orange"),
        new Animal(4,"Andrzej","Dog",5.0,"Black"),
        new Animal(5,"Bob","Cat",6.0,"Grey"),
        new Animal(6,"Steve","Cat",3.5,"Brown")

    };

    public static List<Appointement> _Appointements = new()
    {
        new Appointement("2024-05-05", 1, "Checkup", 120),
        new Appointement("2024-04-15", 1, "Vaccination", 180),
        new Appointement("2024-01-25",2,"Checkup",120),
        new Appointement("2024-12-07",3,"Vaccination",180),
        new Appointement("2024-03-10",5,"Bug removal",220),
    };
}