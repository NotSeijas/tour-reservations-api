using TourReservations.Domain.Entities;

namespace TourReservations.Application.Commands.CreateReservation;

public class CreateReservationHandler
{
    public Reservation Handle(CreateReservationCommand command)
    {
        // Regla: tour disponible solo entre marzo y octubre
        if (command.TourId == "inca-trail")
        {
            if (command.Date.Month < 3 || command.Date.Month > 10)
                throw new InvalidOperationException("El tour 'inca-trail' solo está disponible entre marzo y octubre.");

            // Regla: mayor de 65 y condición baja
            if (command.Tourist.Age > 65 && command.Tourist.FitnessLevel.ToLower() == "low")
                throw new InvalidOperationException("No se puede reservar este tour por su nivel de exigencia física.");

            // Regla: USA debe reservar con 30 días de anticipación
            if (command.Tourist.Nationality.ToUpper() == "USA")
            {
                var diferencia = (command.Date - DateTime.UtcNow.Date).TotalDays;
                if (diferencia < 30)
                    throw new InvalidOperationException("Los turistas de USA deben reservar con al menos 30 días de anticipación.");
            }
        }

        return new Reservation();
    }
}
