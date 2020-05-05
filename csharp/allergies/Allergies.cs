using System;
using System.Collections.Generic;
using System.Linq;

namespace Allergies
{
    public enum Allergen
    {
        Eggs,
        Peanuts,
        Shellfish,
        Strawberries,
        Tomatoes,
        Chocolate,
        Pollen,
        Cats
    }

    public class Allergies
    {
        private readonly List<int> allergenNumbers = new List<int>();

        public Allergies(int mask)
        {
            var allergenMaxValue = Enum.GetNames(typeof(Allergen)).Length - 1;
            var limitValue = Math.Min(mask, allergenMaxValue);

            for (int i = 0; i <= limitValue; i++)
            {
                var bitShift = 1 << i;

                if ((mask & bitShift) == bitShift)
                {
                    allergenNumbers.Add(i);
                }

            }
        }

        public bool IsAllergicTo(Allergen allergen) => allergenNumbers.Contains((int)allergen);

        public Allergen[] List() => allergenNumbers.Select(x => (Allergen)x).ToArray();
    }
}