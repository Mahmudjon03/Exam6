using Npgsql;

namespace Infracstructure.Data;

public class DateContect
{
    string constr ="Server=Localhost;Port=5432;Database=Exam5;User Id=postgres;Password=mahmud04;";
    public NpgsqlConnection Getconstr()=>new NpgsqlConnection(constr);
}
