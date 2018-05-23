using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Db;
using BOL;
using Microsoft.AspNetCore.Mvc;

namespace ToDoTrello.Controllers
{
    public class BaseController : Controller
    {
        protected AllDb db;

        public BaseController(ToDoTrelloContext context)
        {
            db = new AllDb(context);
        }
    }
}