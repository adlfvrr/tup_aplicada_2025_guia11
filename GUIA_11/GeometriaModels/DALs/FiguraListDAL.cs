using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;

public class FiguraListDAL:IFiguraDAL
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

    public List<FiguraModel> GetALL()
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

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }


    public FiguraModel Update(FiguraModel entity)
    {
        throw new NotImplementedException();
    }


}
