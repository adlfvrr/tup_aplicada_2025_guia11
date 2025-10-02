using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;
public interface IFiguraDAL
{
    public List<FiguraModel> GetALL();
    public FiguraModel GetById(int id);
    public FiguraModel Add(FiguraModel figura);
    public bool Remove(int id);
    public FiguraModel Update(FiguraModel entity);
}
