using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ForumDatabase.Context
{
    public class ForumBD : DbContext
    {
        public ForumBD([NotNullAttribute] DbContextOptions options) : base(options) { }
    }
}
