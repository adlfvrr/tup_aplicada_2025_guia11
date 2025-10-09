using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;
public interface IFigurasDAL
{
    public List<FiguraModel> GetAll();
    public FiguraModel GetById(int id);
    public FiguraModel Add(FiguraModel figura);
    public void Remove(int id);
    public FiguraModel Update(FiguraModel entity);
}
