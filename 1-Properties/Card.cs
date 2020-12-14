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
        private readonly string seed;
        private readonly string name;
        private readonly int ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            
            this.name = name;
            this.ordinal = ordinal;
            this.seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple)
            : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        public string GetSeed
        {
            get { return seed; }
        }
        public string GetName
        {
            get { return name; }
        }

        public int GetOrdinal
        {
            get { return ordinal; }
        }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            return "Name: " + GetName.ToString() + " - Seed: " + GetSeed.ToString() + " - Ordinal: " + GetOrdinal.ToString();
            //return $"{this.GetType().Name}(Name={this.GetName()}, Seed={this.GetSeed()}, Ordinal={this.GetOrdinal()})";
        }

        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   seed == card.seed &&
                   name == card.name &&
                   ordinal == card.ordinal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(seed, name, ordinal);
        }
    }
}
