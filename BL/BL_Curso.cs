using DA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL
{
    public class BL_Curso
    {
        public BL_Curso()
        {

        }
        public bool agregarCurso(Curso a)
        {
            using (Entidades da = new Entidades())
            {
                da.Cursoes.Add(a);
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
        public bool actualizarCurso(Curso a)
        {
            using (Entidades da = new Entidades())
            {
                Curso cur = da.Cursoes.First(x => x.CursoID == a.CursoID);
                //cur = a;
                cur.Nombre = a.Nombre;
                cur.Creditos = a.Creditos;
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
        public bool eliminarCurso(Curso a)
        {
            using (Entidades da = new Entidades())
            {
                try
                {
                    da.Cursoes.Remove(da.Cursoes.First(x => x.CursoID == a.CursoID));
                    da.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public ObservableCollection<Curso> mostrarCursosObserbable()
        {
            using (Entidades da = new Entidades())
            {
                ObservableCollection<Curso> list = new ObservableCollection<Curso>(da.Cursoes.ToList());
                return list;
            }
        }

        public List<Curso> mostrarCursos()
        {
            List<Curso> list;
            using (Entidades da = new Entidades())
            {
                list = da.Cursoes.ToList();
            }
            return list;
        }
    }
}
