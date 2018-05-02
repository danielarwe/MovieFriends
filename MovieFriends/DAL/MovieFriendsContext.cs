using MovieFriends.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieFriends.DAL
{
    public class MovieFriendsContext:DbContext
    {
        public MovieFriendsContext() : base("MovieFriendsContext")
        {
        }

        public DbSet<Review> Reviews { get; set; }

    }
}