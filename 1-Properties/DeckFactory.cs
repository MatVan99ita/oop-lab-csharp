namespace Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A factory class for building <see cref="ISet{T}">decks</see> of <see cref="Card"/>s.
    /// </summary>
    public class DeckFactory
    {
        private string[] seeds;

        private string[] names;

        public IList<string> Seeds
        {
            get { return seeds.ToList(); }
            set { seeds = value.ToArray(); }
        }

        public IList<string> Names
        {
            get { return names.ToList(); }
            set { names = value.ToArray(); }
            
        }
        public int GetDeckSize
        {
            get { return names.Length * seeds.Length; }
        }

        /// TODO improve
        public ISet<Card> GetDeck
        {
            get { return new HashSet<Card>(Enumerable
                  .Range(0, this.names.Length)
                  .SelectMany(i => Enumerable
                      .Repeat(i, this.seeds.Length)
                      .Zip(
                          Enumerable.Range(0, this.seeds.Length),
                          (n, s) => Tuple.Create(this.names[n], this.seeds[s], n)))
                  .Select(tuple => new Card(tuple))
                  .ToList()); }
        }
    }
}
