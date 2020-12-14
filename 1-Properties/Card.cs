namespace Properties
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            
            this.Name = name;
            this.Ordinal = ordinal;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple)
            : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        public string Seed
        {
            get;
        }
        public string Name
        {
            get;
        }

        public int Ordinal
        {
            get;
        }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            return "Name: " + Name.ToString() + " - Seed: " + Seed.ToString() + " - Ordinal: " + Ordinal.ToString() + "\n";
            //return $"{this.GetType().Name}(Name={this.GetName()}, Seed={this.GetSeed()}, Ordinal={this.GetOrdinal()})";
        }

        public override bool Equals(object obj)
        {
            return obj is Card card &&
<<<<<<< HEAD
                   seed == card.seed &&
                   name == card.name &&
                   ordinal == card.ordinal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(seed, name, ordinal);
        }

        // TODO generate Equals(object obj)
=======
                   Seed == card.Seed &&
                   Name == card.Name &&
                   Ordinal == card.Ordinal;
        }
>>>>>>> b765cd2e89a89a2be52c17dfb6658fb0e122b29c

        public override int GetHashCode()
        {
            return HashCode.Combine(Seed, Name, Ordinal);
        }
    }
}
