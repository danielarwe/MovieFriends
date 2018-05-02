using MovieFriends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFriends.DAL
{
    public class MovieFriendsInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieFriendsContext>
    {
        public void Seed(MovieFriendsContext context)
        {
            var reviews = new List<Review>
            {
                new Review
                {
                    Title="Tommy Boy",
                    Actors="Chris Farley, David Spade",
                    Rating=MpaaRating.PG13,
                    Summary="Screw-up Tommy takes over the family business",
                    Genre="comedy",
                    ReviewerFirstName="John",
                    ReviewerLastName="Doe",
                    ReviewerRating=4,
                    Comments="Chris Farley is really funny!"
                },

                new Review
                {
                    Title="Dumb and Dumber",
                    Actors="Jim Carrey, Jeff Daniels",
                    Rating=MpaaRating.PG13,
                    Summary="Loyd and Harry set out on a cross-country roadtrip to return a lost briefcase to a special lady",
                    Genre="comedy",
                    ReviewerFirstName="Jimbo",
                    ReviewerLastName="Jones",
                    ReviewerRating=4,
                    Comments="Laughed my butt off!"
                }
            };

                reviews.ForEach(x=>context.Reviews.Add(x));
                context.SaveChanges();
        }


    }
        
    
}