using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Colors
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var Colors = await _unitOfWork.Colors.GetAll();
            return Ok(Colors);
        }

        // GET: /Colors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var Color = await _unitOfWork.Colors.Get(q => q.Id == id);

            if (Color == null)
            {
                return NotFound();
            }

            return Ok(Color);
        }

        // PUT: /Colors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color Color)
        {
            if (id != Color.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colors.Update(Color);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color Color)
        {
            await _unitOfWork.Colors.Insert(Color);
            await _unitOfWork.Save(HttpContext);

            //return CreatedAtAction("GetColor", new { id = Color.Id }, Color);
            return CreatedAtAction(nameof(GetColor), new { id = Color.Id }, Color);
        }

        // DELETE: /Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var Color = await _unitOfWork.Colors.Get(q => q.Id == id);

            if (Color == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColorExists(int id)
        {
            var Color = await _unitOfWork.Colors.Get(q => q.Id == id);

            return Color == null;
        }
    }
}
