using System.Collections.Generic;
using System.Linq;

namespace AhmedLinq
{
    static class ComicAnalyzer
    {
        static private PriceRange CalculatePriceRange(Comic comic)
        {
           return Comic.Prices[comic.Issue] < 100? PriceRange.Cheap: PriceRange.Expensive;
        }

        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            var groups = from comic in comics
                         orderby prices[comic.Issue]
                         group comic by CalculatePriceRange(comic) into priceGroup
                         select priceGroup;

            return groups;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
        {
            var comicReviews = from comic in comics
                               orderby comic.Issue
                               join review in reviews
                               on comic.Issue equals review.Issue
                               select $"{review.Critic} rated #{review.Issue} '{comic.Name}' {review.Score:0.00}";

            return comicReviews;
        }
    }
}