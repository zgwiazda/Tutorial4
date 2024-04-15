using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad request
            // 401 - Unauthorized
            // 403 - Forbidden
            // 404 - Not Found

            var animals = StaticData._animals;
            return Results.Ok(animals);
        });

        app.MapGet("/animals/{id}", ([FromRoute] int id) =>
        {
            var animals = StaticData._animals;
            return Results.Ok(id);
        });

        app.MapPost("/animals/", (Animal animal) =>
        {
            return Results.Created("", animal);
        });

        app.MapPut("/animals/{id}", ([FromRoute] int id, Animal animal) =>
        {
            var animalToEdit = StaticData._animals.FirstOrDefault(a => a.Id == id);
            if (animalToEdit == null)
            {
                return Results.NotFound($"Animal with id {id} was not found");
            }

            StaticData._animals.Remove(animalToEdit);
            StaticData._animals.Add(animal);
            return Results.NoContent();

        });

        app.MapDelete("/animals/{id}", ([FromRoute] int id) =>
        { 
            var animalToDelete = StaticData._animals.FirstOrDefault(a => a.Id == id);
            if (animalToDelete == null)
            {
                return Results.NotFound($"Animal with id {id} was not found");
            }

            StaticData._animals.Remove(animalToDelete);
            return Results.NoContent();

        });
    }
}