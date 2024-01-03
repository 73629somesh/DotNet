namespace DAL;
@using System.Collections.Generic;

public static class DBManager(){

public static string str=@"server=localhost;port=3306;user=root;password=Sql@7888;database=demo_db";

public static List<Login> GetAllDetails(){

    List<Login> list=new List<Login>();
    MySqlConnection con=new MySqlConnection();
    con.ConnectionString=str;
    string query="Select * from Login";
    MySqlCommand cmd=new MySqlCommand()
    try{
        cmd.Connection=con;
        con.open();
        cmd.CommandText=query;
        MySqlReader reader=cmd.ExecuteReader();
        while(reader.Read()){
            int id=int.Parse(reader["Id"].ToString());
            string name=reader ["name"].ToString();

            Login Logn=new Login{
                    Id=id;
                    Name=name;
            };
            list.Add(Logn);
        }
        
    }
    catch(Exception ee){
                Console.WriteLine(ee.Message);                                   
            }
            finally{
                    con.Close();
            }

            return list;
    }
}

}