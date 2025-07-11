using Microsoft.AspNetCore.Mvc;
using TourReservations.Application.Commands.CreateReservation;

namespace TourReservations.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationsController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] CreateReservationCommand command)
    {
        try
        {
            var handler = new CreateReservationHandler();
            var result = handler.Handle(command);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
