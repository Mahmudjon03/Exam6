namespace Infracstructure.Servises;
using Domain.Models;
using Dapper;
using Npgsql;
using Microsoft.VisualBasic;
using Infracstructure.Data;

public class StudentServise
{
DateContect _context=new DateContect();
string connstr="Server=Localhost;Port=5432;Database=Exam5;User Id=postgres;Password=mahmud04;";

public List<Student> GetStudent(){
    using var d= _context.Getconstr();
        var sql ="select * from students";
        var resalt = d.Query<Student>(sql).ToList();
        return resalt;
    }
        public void AddStudent(Student student){
        using var q = _context.Getconstr(); 
            var sql = $"insert into students(first_name,last_name,phone,group_id)values"+
            $"('{student.first_name}','{student.last_name}','{student.phone}',{student.group_id})";
            var resalt = q.Execute(sql);
            if(resalt== 1){
                System.Console.WriteLine("Student added sucessfully");
            }else{
                System.Console.WriteLine("Error");
            }
           }
       
        public string Delete(int s){
        using var conn=_context.Getconstr();{
            var sql =$"delete from students where id={s}";
            var res =conn.Execute(sql);
            if(res==1){
                return"Student remove sucessfully";
            }
           return "Error";

        }
       }
       public void UpdateStudent(Student student){
        using var conn = _context.Getconstr();
            var sql =$"update students set first_name ='{student.first_name}',"+
            $" last_name='{student.last_name}',phone='{student.phone}',group_id={student.group_id} where id = {student.id}";
            var res = conn.Execute(sql);
            if(res==1){
                System.Console.WriteLine("Update  sucessfully");
            }
            System.Console.WriteLine("Error");
        }
       
       public Student GEtById(int id){
         using var conn = _context.Getconstr();
         var sql =$"select * from students where id={id}";
         var res= conn.QueryFirstOrDefault<Student>(sql);
         if(res==null){
         System.Console.WriteLine("Error");
          }
         
             return res;

         
        
         }
         }
        

