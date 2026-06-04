using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaGestionEventos.Models;

public class RecursoEvento
{
    public int EventoId { get; set; }

    [ForeignKey("EventoId")]
    public Evento? Evento { get; set; }

    public int RecursoId { get; set; }

    [ForeignKey("RecursoId")]
    public Recurso? Recurso { get; set; }

    public int cantidad { get; set; }
}