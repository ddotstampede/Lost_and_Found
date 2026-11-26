using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Item
    {
        public Item(string type, string description)
        {
            this.Type = type;
            Description = description;
        }

        public string Type { get; private set; }
        public string Description { get; private set; }

        public static Item CreateFromInput()
        {
            Console.Write("Typ des Fundstücks (z. B. Schlüssel, Geldbörse): ");
            string type = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Beschreibung des Fundstücks: ");
            string description = Console.ReadLine()?.Trim() ?? "";

            Item newItem = new Item(type, description);
            Console.WriteLine($"Fundstück '{newItem.Type}' wurde angelegt.");
            return newItem;
        }

       public static List<Item> LoadFromFile(string pfad = "items.txt")
       {
          List<Item> liste = new List<Item>();
           if (!File.Exists(pfad)) return liste;

           foreach (string zeile in File.ReadAllLines(pfad))
           {
             string[] teile = zeile.Split(';');
              if (teile.Length >= 2)
              {
                 liste.Add(new Item(teile[0], teile[1]));
              }
           }
            return liste;
       }
    }
}
