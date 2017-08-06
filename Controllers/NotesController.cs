using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace automatic_enigma.Controllers
{
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly List<string> notes = new List<string>();

        public NotesController(IEnumerable<string> notes)
        {
            this.notes.AddRange(notes);
        }

        // GET api/notes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}

