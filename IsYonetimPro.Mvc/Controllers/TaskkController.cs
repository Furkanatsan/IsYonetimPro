using IsYonetimPro.Services.Abstract;
using IsYonetimPro.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsYonetimPro.Mvc.Controllers
{
    public class TaskkController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskkController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _taskService.GetAllAsync();//dataResult döner
            if (result.ResultStatus==ResultStatus.Success)//Dönen DataResult içindeki resultStatus Success ise datayı view a göndeririz. 
            {
                return View(result.Data);
            }
            return View();
        }
    }
}
