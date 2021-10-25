using System;
using DBRepository.Interfaces;
using Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace DBRepository.Repositories
{
	public class ToDoListRepository : BaseRepository, IToDoListRepository
	{
		public ToDoListRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }


			
	}
}
