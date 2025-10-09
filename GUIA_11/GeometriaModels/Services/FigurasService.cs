using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.DALs;
using GeometriaModels.Models;

namespace GeometriaModels.Services;
public class FigurasService
{
    IFigurasDAL _figurasDAL;
    public FigurasService(IFigurasDAL figuraDAL)
    {
        this._figurasDAL = figuraDAL;
    }
    public List<FiguraModel> GetAll()
    {
        return _figurasDAL.GetAll();
    }

    public FiguraModel GetById(int id)
    {
        return _figurasDAL.GetById(id);
    }


    public FiguraModel AddFigura(FiguraModel nueva)
    {
        return _figurasDAL.Add(nueva);
    }
}

