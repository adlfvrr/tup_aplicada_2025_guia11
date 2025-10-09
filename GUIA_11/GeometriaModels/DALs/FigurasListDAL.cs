using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;

public class FigurasListDAL:IFigurasDAL
{
    List<FiguraModel> figuras = new();
    int Id = 1;

    public FiguraModel Add(FiguraModel figura)
    {
        if (figura.Id > 0) return null;

        figura.Id = Id++;
        figuras.Add(figura);
        return figura;
    }

    public List<FiguraModel> GetAll()
    {
        return figuras;
    }

    public FiguraModel GetById(int id)
    {
        /*return (from f in figuras
                 where f.Id == id
                 select f).FirstOrDefault();*/
        return figuras.Where(p => p.Id == id).FirstOrDefault();
    }

    public void Remove(int id)
    {
        var figura = GetById(id);
        if (figura != null)
        {
            figuras.Remove(figura);
        }
    }


    public FiguraModel Update(FiguraModel entity)
    {
        entity.Id = GenId();
        figuras.Add(entity);
        return entity;
    }
    protected int? GenId()
    {
        return (from f in figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
    }

}
