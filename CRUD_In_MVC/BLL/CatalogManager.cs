using DAL;
namespace BLL;
@using System.Collections.Generic;

public class CatalogManager{

    public  list<Login> GetProducts(){

        List<Login> list=DBManager.GetAllDetails();
        return list;
    }
}