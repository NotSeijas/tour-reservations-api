using TourReservations.Domain.Entities;

namespace TourReservations.Application.Commands.CreateReservation;

public class CreateReservationCommand
{
    public string TourId { get; set; } = "";
    public DateTime Date { get; set; }
    public Tourist Tourist { get; set; } = new Tourist();
}
