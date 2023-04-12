using System;
using System.Collections.Generic;

namespace Laboratorio2.Models;

public partial class Notum
{
    public int IdNotas { get; set; }

    public string? Materia { get; set; }

    public string? NombreEstudiante { get; set; }

    public decimal? Lab1 { get; set; }

    public decimal? Parcial1 { get; set; }

    public decimal? Lab2 { get; set; }

    public decimal? Parcial2 { get; set; }

    public decimal? Lab3 { get; set; }

    public decimal? Parcial3 { get; set; }

    public decimal? Resultado { get; set; }
}
