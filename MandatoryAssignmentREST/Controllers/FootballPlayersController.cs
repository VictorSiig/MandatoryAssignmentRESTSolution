using MandatoryAssignmentClassLibrary;
using MandatoryAssignmentREST.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MandatoryAssignmentREST.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase {

        private readonly FootballPlayersManager _manager = new FootballPlayersManager();

        // GET: api/<ApisController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<FootballPlayer> GetAll([FromHeader] int? amount) {
            IEnumerable<FootballPlayer> footballPlayers = _manager.GetAll(amount);
            if (amount == null || amount < 0) return NotFound("No list found");
            return Ok(footballPlayers);
        }

        // GET api/<BooksController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> GetById(int id) {
            FootballPlayer footballPlayer = _manager.GetById(id);
            if (footballPlayer == null) return NotFound();
            return Ok(footballPlayer);
        }

        // POST api/<BooksController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpPost]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value) {
            FootballPlayer footballPlayer = _manager.Add(value);
            if (footballPlayer == null) return NotFound();
            if (footballPlayer == value) return Conflict();
            return Ok(footballPlayer);
        }

        // PUT api/<BooksController>/5
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPut("{id}")]
        public ActionResult<FootballPlayer> Put(int id, [FromBody] FootballPlayer value) {
            FootballPlayer footballPlayer = _manager.Update(id, value);
            if (footballPlayer == null) return NotFound();
            if (footballPlayer.Id == id && value != null) return Ok(footballPlayer);
            if (footballPlayer.Id == id && value == null) return NoContent();
            return Ok(footballPlayer);

        }

        // DELETE api/<BooksController>/5
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete("{id}")]
        public ActionResult<FootballPlayer> Delete(int id) {
            FootballPlayer footballPlayer = _manager.GetById(id);
            if (footballPlayer == null) return NotFound();
            return Ok(footballPlayer);
        }
    }
}
