using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck().Shuffle().Take(16);
            IOrderedEnumerable<IGrouping<Suits, Card>> groups = groupCardsBySuite(deck);

            foreach (var group in groups)
            {
                Console.WriteLine($"Group: {group.Key} Count: { group.Count()} Minimum: { group.Min()} Maximum: { group.Max()}");
            }
        }

        private static IOrderedEnumerable<IGrouping<Suits, Card>> groupCardsBySuite(IEnumerable<Card> deck)
        {
            return from card in deck
                   group card by card.Suit into suitGroup
                   orderby suitGroup.Key
                   select suitGroup;
        }
    }
}
