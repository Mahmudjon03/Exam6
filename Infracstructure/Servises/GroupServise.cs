namespace Infracstructure.Servises;
using Domain.Models;
using Dapper;
using Npgsql;
using Infracstructure.Data;

public class GroupServise
{    DateContect _context = new DateContect();
    public List<Group> GetGroup(){
    using var conn = _context.Getconstr();
        var sql ="select * from groups";
        var resalt = conn.Query<Group>(sql).ToList();
      return resalt;
       }
        public void Add(Group g){
        using var conn = _context.Getconstr(); {
            var sql = $"insert into groups(group_name,title)values"+
            $"('{g.group_name}','{g.title}')";
            var resalt = conn.Execute(sql);
            if(resalt== 1){
                System.Console.WriteLine("Student added sucessfully");
            }else{
                System.Console.WriteLine("Error");
            }
           }
       }
        public string DeleteGroup(int s){
        using var conn = _context.Getconstr();{
            var sql =$"delete from groups where id={s}";
            var res =conn.Execute(sql);
            if(res==1){
                return"Student remove sucessfully";
            }
           return "Error";

        }
       }
       public void UpdateGroup(Group g){
        using var conn =_context.Getconstr(); {
            var sql =$"update groups set group_name ='{g.group_name}',"+
            $" title='{g.title}'  where id = {g.id}";
            var res = conn.Execute(sql);
            if(res==1){
                System.Console.WriteLine("Update  sucessfully");
            }else{
            System.Console.WriteLine("Error");
            }
        }
       }
       public Group GEtById(int id){
         using var conn = _context.Getconstr();
         var sql =$"select *from groups where id={id}";
         var res= conn.QueryFirstOrDefault<Group>(sql);
         return res;
         }
         public List<StudentGroupName> GetStudentGroupName(){
            using var con = _context.Getconstr();
            var sql =$"select s.first_name,s.last_name,s.phone,g.group_name from students as s  join groups as g on s.group_id=g.id ";
       var res =con.Query<StudentGroupName>(sql).ToList();
       return res;
         }
         public Student GetRandomStudent(){
            using var con = _context.Getconstr();
            var sql="select * from students order by random() limit 1";
            var res =con.QueryFirstOrDefault<Student>(sql);
            return res;
         }
         public List<Student> GetStudentbyGroupId(int t){
            using var con = _context.Getconstr();
            var sql=$"select * from students as s join groups as g on s.group_id=g.id where g.id={t}";
            var res = con.Query<Student>(sql).ToList();
    
            
            return res;
         }
         public List<GroupStudent> GetGroupByStudent(){
            using var con = _context.Getconstr();
            var sql= $"select g.group_name,s.first_name,s.last_name,s.phone from groups as g join students as s on g.id=s.group_id"; 
            var red = con.Query<GroupStudent>(sql).ToList();
            return red;
            }public List<GroupStudent> GetGroupWidtStudent(int i){
            using var con = _context.Getconstr();
            var sql= $"select g.group_name,s.first_name,s.last_name,s.phone from groups as g join students as s on g.id=s.group_id where g.id={i}"; 
            var red = con.Query<GroupStudent>(sql).ToList();
            return red;
            }
            }

