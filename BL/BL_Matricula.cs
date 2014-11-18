using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
namespace BL
{
    public class BL_Matricula
    {
        public BL_Matricula()
        { }

        public bool agregarMatricula(Matricula ma)
        {
            using (Entidades da = new Entidades())
            {
                da.Matriculas.Add(ma);
                try
                {
                    da.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool eliminarMatricula(Matricula ma)
        {
            using (Entidades da = new Entidades())
            {
                da.Matriculas.Remove(da.Matriculas.First(x=>x.MatriculaID == ma.MatriculaID));
                try
                {
                    da.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool actualizarMatricula(Matricula ma)
        {
            using (Entidades da = new Entidades())
            {
                var mat = da.Matriculas.First(x => x.MatriculaID == ma.MatriculaID);
                mat.FK_AlumnoID = ma.FK_AlumnoID;
                mat.FK_CursoID = ma.FK_CursoID;
                mat.Fecha = ma.Fecha;
                try
                {
                    da.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public List<Matricula> mostrarMatriculas()
        {
            List<Matricula> list;
            using (Entidades da = new Entidades())
            {
                list = da.Matriculas.ToList();
            }
            return list;
        }
    }
}
