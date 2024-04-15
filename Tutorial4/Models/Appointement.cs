namespace Tutorial4.Models;

public class Appointement
{
    public string Date { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Appointement(string date, int animalId, string description, double price)
    {
        this.Date = date;
        this.AnimalId = animalId;
        this.Description = description;
        this.Price = price;
    }
    
}