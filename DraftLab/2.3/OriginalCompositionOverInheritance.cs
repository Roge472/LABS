namespace DraftLab.OriginalCompositionOverInheritance
{
    // Compositions over inheritance.
    public class Pokemon
    {
        public int HitPoints { get; set; }
        public int AttackDamage { get; set; }

        public Pokemon(int hitPoints, int attackDamage)
        {
            HitPoints = hitPoints;
            AttackDamage = attackDamage;
        }
    }

    public class FlyingPokemon : Pokemon
    {
        public FlyingPokemon(int hitPoints, int attackDamage) : base(hitPoints, attackDamage)
        {
        }

        public int WindStrike(Pokemon pokemon)
        {
            if(pokemon is EarthPokemon)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

    }

    public class EarthPokemon : Pokemon
    {
        public EarthPokemon(int hitPoints, int attackDamage) : base(hitPoints, attackDamage)
        {
        }

        public int EarthStrike(Pokemon pokemon)
        {
            // if (pokemon is FirePokemon) { }
            return AttackDamage;
        }

    }

    /// <summary>
    /// Inheritance not really flexible.
    /// In order to combine something you need to create completely new instance of this class.
    /// </summary>
    public class EarthAndFlyingPokemon : EarthPokemon
    {
        public EarthAndFlyingPokemon(int hitPoints, int attackDamage) : base(hitPoints, attackDamage)
        {
        }

        public int EarthOrFlyingStrike(Pokemon pokemon)
        {
            // if (pokemon is FirePokemon)
            // {
            //   return AttackDamage * 2;
            // }

            if (pokemon is EarthPokemon)
            {
                return AttackDamage * 3;
            }

            return AttackDamage;
        }
    }
}
