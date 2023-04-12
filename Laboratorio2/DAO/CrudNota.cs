using Laboratorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.DAO
{
    public class CrudNota
    {
        public void AgregarNotas(Notum ParamNotas)
        {
            using (NotaEstudianteContext db = new NotaEstudianteContext())
            {
                Notum Notas = new Notum();
                Notas.NombreEstudiante = ParamNotas.NombreEstudiante;
                Notas.Materia = ParamNotas.Materia;
                Notas.Lab1 = ParamNotas.Lab1;
                Notas.Parcial1 = ParamNotas.Parcial1;
                Notas.Lab2 = ParamNotas.Lab2;
                Notas.Parcial2 = ParamNotas.Parcial2;
                Notas.Lab3 = ParamNotas.Lab3;
                Notas.Parcial3 = ParamNotas.Parcial3;
                Notas.Resultado = ParamNotas.Resultado;
                

                db.Add(Notas);
                db.SaveChanges();

            }

        }

        public decimal CalcularPeriodo1(Notum ParamNota)
        {
            var Lab1 = ParamNota.Lab1 * Convert.ToDecimal(0.4);
            var Parcial1 = ParamNota.Parcial1 * Convert.ToDecimal(0.6);
            return Convert.ToDecimal(Lab1) + Convert.ToDecimal(Parcial1);

        }

        public decimal CalcularPeriodo2(Notum ParamNota)
        {
            var Lab2 = ParamNota.Lab2 * Convert.ToDecimal(0.4);
            var Parcial2 = ParamNota.Parcial2 * Convert.ToDecimal(0.6);
            return Convert.ToDecimal(Lab2) + Convert.ToDecimal(Parcial2);
            
        }

        public decimal CalcularPeriodo3(Notum ParamNota)
        {
            var Lab3 = ParamNota.Lab3 * Convert.ToDecimal(0.4);
            var Parcial3 = ParamNota.Parcial3 * Convert.ToDecimal(0.6);
            return Convert.ToDecimal(Lab3) + Convert.ToDecimal(Parcial3);
            
        }

        public List<Notum> ListarNotas()
        {
            using (NotaEstudianteContext db = new NotaEstudianteContext())
            {
                return db.Nota.ToList();
            }
        }

        public string Resultado(Notum Nota)
        {
                CrudNota CrudNota = new CrudNota();

                var Periodo1 = CrudNota.CalcularPeriodo1(Nota);
                var Periodo2 = CrudNota.CalcularPeriodo2(Nota);
                var Periodo3 = CrudNota.CalcularPeriodo3(Nota);

                Nota.Resultado = decimal.Round(Convert.ToDecimal((Periodo1 + Periodo2 + Periodo3)/3), 2);

            return $"NOTA FINAL: {Nota.Resultado}";

        }
    }
}
