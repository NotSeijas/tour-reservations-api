namespace TourReservations.Domain.Entities;

public class Reservation
{
    public string ReservationId { get; set; } = Guid.NewGuid().ToString("N");
    public string Status { get; set; } = "confirmed";
    public string Message { get; set; } = "Tour reservado exitosamente";
}
