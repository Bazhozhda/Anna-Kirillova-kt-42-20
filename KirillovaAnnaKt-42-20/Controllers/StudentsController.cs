using KirillovaAnnaKt_42_20.Filters.StudentFilters;
using KirillovaAnnaKt_42_20.Interfaces.StudentsInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace KirillovaAnnaKt_42_20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentService _studentService;

        public StudentsController(ILogger<StudentsController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpPost("GetStudentsByGroup")]
        public async Task<IActionResult> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsByGroupAsync(filter, cancellationToken);

            return Ok(students);
        }

        [HttpPost("GetStudentsByFIO")]
        public async Task<IActionResult> GetStudentsByFIOAsync(StudentFIOFilter filter, CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsByFIOAsync(filter, cancellationToken);

            return Ok(students);
        }

        [HttpPost("GetStudentsByExist")]
        public async Task<IActionResult> GetStudentsByExistAsync(StudentExistFilter filter, CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsByExistAsync(filter, cancellationToken);

            return Ok(students);
        }
    }
}