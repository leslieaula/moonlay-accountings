using ChartOfAccounts.Application;
using ChartOfAccounts.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChartOfAccounts.Controllers
{
    public class EntriesController : ControllerBase
    {
        private readonly IEntryService _entryService;

        public EntriesController(IEntryService entryService)
        {
            _entryService = entryService;
        }

        public async Task<IActionResult> Post([FromBody]EntryForm form)
        {
            await Task.Yield();

            return Ok(true);
        }
    }
}
