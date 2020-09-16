using System.Collections.Generic;

public enum Allergen
{
    None = 0,         // 0000 0000
    Eggs = 1,         // 0000 0001
    Peanuts = 2,      // 0000 0010
    Shellfish = 4,    // 0000 0100
    Strawberries = 8, // 0000 1000
    Tomatoes = 16,    // 0001 0000
    Chocolate = 32,   // 0010 0000  
    Pollen = 64,      // 0100 0000
    Cats = 128,       // 1000 0000
}

public class Allergies
{
    private Allergen alergias;

    public Allergies(int mask)
    {
        alergias = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen);
    }

    public List<Allergen> List()
    {
        var listagem = new List<Allergen>();
        var alergenicos = new Allergen[]
        { Allergen.Eggs,
          Allergen.Peanuts,
          Allergen.Shellfish,
          Allergen.Strawberries,
          Allergen.Tomatoes,
          Allergen.Chocolate,
          Allergen.Pollen,
          Allergen.Cats
        };

        for (int i = 0; i < alergenicos.Length; i++)
        {
            if ((alergias & alergenicos[i]) == alergenicos[i])
                listagem.Add(alergenicos[i]);
        }
        return listagem;
    }
}