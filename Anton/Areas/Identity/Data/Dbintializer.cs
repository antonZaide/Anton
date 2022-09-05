using Anton.Models;
using System;
using System.Linq;

namespace Anton.Areas.Identity.Data
{
    public static class Dbintializer
    {
        public static void Initialize(AntonContextDb context)
        {
            context.Database.EnsureCreated();

            if (context.Artist.Any())
            {
                return;
            }
        }
    }
}
