using DBRepository.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Palma
{
    
	public class ToDoListController : Controller
	{
		IToDoListRepository _ToDoListRepository;
        private IToDoListRepository _ToDoListRepository;

        public ToDoListController(IToDoListRepository ToDoListRepository)
		{
			_ToDoListRepository = ToDoListRepository;
		}

		
		
	}
}
