namespace ProyectoReservaciones.ViewModels;

public class EventoRecursoViewModel
{
    public int RecursoId { get; set; }

    public string Nombre { get; set; }

    public int CantidadDisponible { get; set; }

    public bool Seleccionado { get; set; }

    public int CantidadSeleccionada { get; set; }
}