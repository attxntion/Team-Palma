using System;
using Models;
using Microsoft.EntityFrameworkCore;

namespace DBRepository
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{

		}

		public DbSet<Task> Posts { get; set; }
		
	}
}
