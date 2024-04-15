namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string FurColor { get; set; }
    public Animal(int id, string name, string category, double weight, string furColor )
    {
        this.Id = id;
        this.Name = name;
        this.Category = category;
        this.Weight = weight;
        this.FurColor = furColor;
    }
}