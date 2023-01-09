using AutoMapper;
using Lesson23.Database;
using Lesson23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lesson23.Models.Response;
using Lesson23.Database.Entities;
using Lesson23DatabaseDFirst;
using System.Text;

namespace Lesson23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly FootballDB _db;
        private readonly Lesson19Context _db2;

        public HomeController(ILogger<HomeController> logger, FootballDB db, Lesson19Context db2, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            _db2 = db2;
            _mapper = mapper;
        }

        public IActionResult Players() => View(_db.Players.Select(_mapper.Map<PlayerDto>).ToList());
        public IActionResult Teams() => View(_db.Teams.Select(_mapper.Map<TeamDto>).ToList());
        public IActionResult Coaches() => View(_db.Coaches.Select(_mapper.Map<CoachDto>).ToList());
        public IActionResult Groups() => View(_db.Groups.Select(_mapper.Map<GroupDto>).ToList());
        public IActionResult Schedules() => View(_db.Schedules.Select(_mapper.Map<ScheduleDto>).ToList());

        //I don't have time for this so it just prints string
        public IActionResult DatabaseFirst() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Players:");
            foreach (var p in _db2.Players)
            {
               sb.AppendLine($"{p.Id}, {p.Name}, {p.Surname}, {p.TeamId}, {p.Salary}");
            }
            sb.AppendLine("Teams:");
            foreach (var p in _db2.Teams)
            {
                sb.AppendLine($"{p.Id}, {p.Name}, {p.GroupId}, {p.CoachId}, {p.Rate}");
            }
            sb.AppendLine("Coaches:");
            foreach (var p in _db2.Coaches)
            {
                sb.AppendLine($"{p.Id}, {p.Name}, {p.Surname}");
            }
            sb.AppendLine("Groups:");
            foreach (var p in _db2.Groups)
            {
                sb.AppendLine($"{p.Id}, {p.Name}");
            }
            sb.AppendLine("Schedules:");
            foreach (var p in _db2.Schedules)
            {
                sb.AppendLine($"{p.Id}, {p.GroupId}, {p.TeamA}, {p.TeamB}, {p.Time}");
            }
            return View((object)sb.ToString());
        }

        public IActionResult Index()
        {
            return Players();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}