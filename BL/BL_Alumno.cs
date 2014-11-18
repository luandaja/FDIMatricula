
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;



namespace BL
{
    public class BL_Alumno
    {
        public BL_Alumno()
        {
        }

        public bool agregarAlumno(Alumno a)
        {
            try
            {
                Entidades da = new Entidades();
                da.Alumnoes.Add(a);
                da.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool actualizarAlumno(Alumno a)
        {
            try
            {
                Entidades da = new Entidades();
                Alumno alu = da.Alumnoes.First(x => x.ID == a.ID);
                alu = a;
                alu.Nombre = a.Nombre;
                alu.Apellido = a.Apellido;
                alu.FechaNac = a.FechaNac; //5 minutos
                alu.Edad = a.Edad;


                da.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool eliminarAlumno(Alumno a)
        {
            try
            {
                Entidades da = new Entidades();
                da.Alumnoes.Remove(da.Alumnoes.First(x => x.ID == a.ID));
                da.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Alumno> mostrarAlumnos()
        {
            Entidades da = new Entidades();
            return da.Alumnoes.ToList();

        }
        public int calcularEdad(DateTime d)
        {
            return (DateTime.Now.Year - d.Year);
        }
    }
}
