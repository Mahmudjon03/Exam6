using Infracstructure.Servises;
using Domain.Models;
var St = new StudentServise();
var Gr = new GroupServise();
while (true)
{
    int l;
    System.Console.WriteLine("1:Student");
    System.Console.WriteLine("2:Group");
    System.Console.WriteLine("3:Get All Student by group");
    System.Console.WriteLine("4:Get a random Student");
    System.Console.WriteLine("5:Get all students with GroupName.");
    System.Console.WriteLine("6:Get all groups with students");
    System.Console.WriteLine("7:Get group by id with students");
    l = Convert.ToInt16(Console.ReadLine());
    if (l == 1)
    {
        while (true)
        {
            int e = 0;
            System.Console.WriteLine("1:Get");
            System.Console.WriteLine("2:Add");
            System.Console.WriteLine("3:Delete");
            System.Console.WriteLine("4:Update");
            System.Console.WriteLine("5:GetById");
            System.Console.WriteLine("6:Exit");

            e = Convert.ToInt16(Console.ReadLine());
            if (e == 1)
            {
                var d = St.GetStudent();
                System.Console.WriteLine("id -----------firstname------------lastname-----------phone-----------group_id");
                foreach (var m in d)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{m.id}          {m.first_name}        {m.last_name}        {m.phone}       {m.group_id}");
                    System.Console.WriteLine();

                }
            }
            else if (e == 2)
            {
                var st = new Student();
                System.Console.Write("firstname: ");
                st.first_name = Console.ReadLine();
                System.Console.Write("lastname: ");
                st.last_name = Console.ReadLine();
                System.Console.Write("phone: ");
                st.phone = Console.ReadLine();
                System.Console.Write("group_id: ");
                st.group_id = Convert.ToInt32(Console.ReadLine());
                St.AddStudent(st);
            }
            else if (e == 3)
            {
                int del;
                System.Console.Write("id: ");
                del = Convert.ToInt32(Console.ReadLine());
                St.Delete(del);
            }
            else if (e == 4)
            {
                var st = new Student();
                System.Console.Write("Id: ");
                st.id = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("firstname: ");
                st.first_name = Console.ReadLine();
                System.Console.Write("lastname: ");
                st.last_name = Console.ReadLine();
                System.Console.Write("phone: ");
                st.phone = Console.ReadLine();
                System.Console.Write("group_id: ");
                st.group_id = Convert.ToInt32(Console.ReadLine());
                St.UpdateStudent(st);

            }
            else if (e == 5)
            {
                int t;
                t = Convert.ToInt32(Console.ReadLine());
                var k = St.GEtById(t);
                System.Console.WriteLine($"{k.id}       {k.first_name}       {k.last_name}        {k.phone}        {k.group_id}");

            }
            else if (e == 6)
            {
                break;
            }

        }
    }
    else if (l == 2)
    {
        while (true)
        {
            int t;
            System.Console.WriteLine("1:Get");
            System.Console.WriteLine("2:Add");
            System.Console.WriteLine("3:Delete");
            System.Console.WriteLine("4:Update");
            System.Console.WriteLine("5:GetById");
            System.Console.WriteLine("6:Exit");
            t = Convert.ToInt16(Console.ReadLine());
            if (t == 1)
            {
                var gt = Gr.GetGroup();
                foreach (var item in gt)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"id: {item.id}");
                    System.Console.WriteLine($"groupname: {item.group_name}");
                    System.Console.WriteLine($"title: {item.title}");
                    System.Console.WriteLine();
                }
            }
            else if (t == 2)
            {
                var gr = new Group();

                System.Console.Write("groupname:");
                gr.group_name = Console.ReadLine();
                System.Console.Write("title: ");
                gr.title = Console.ReadLine();
                Gr.Add(gr);
            }
            else if (t == 3)
            {
                int i;
                System.Console.Write("id: ");
                i = Convert.ToInt32(Console.ReadLine());
                Gr.DeleteGroup(i);


            }
            else if (t == 3)
            {
                int g;
                System.Console.Write("id: ");
                g = Convert.ToInt32(Console.ReadLine());
                Gr.DeleteGroup(g);

            }
            else if (t == 4)
            {
                var gg = new Group();
                System.Console.Write("id: ");
                gg.id = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("groupname: ");
                gg.group_name = Console.ReadLine();
                System.Console.Write("title:");
                gg.title = Console.ReadLine();
                Gr.UpdateGroup(gg);
            }
            else if (t == 5)
            {
                int u;
                System.Console.Write("id: ");
                u = Convert.ToInt32(Console.ReadLine());
                var gby = Gr.GEtById(u);
                System.Console.WriteLine($"group_name: {gby.group_name}");
                System.Console.WriteLine($"title:  {gby.title}");

            }
            else if (t == 6)
            {
                break;

            }
        }
    }
    else if (l == 5)
    {
        var t = Gr.GetStudentGroupName();
        System.Console.WriteLine("firstname          lastname        phone         groupname");
        foreach (var i in t)
        {
            System.Console.WriteLine($"{i.first_name}          {i.last_name}          {i.phone}           {i.group_name}");
        }
    }
    else if (l == 4)
    {
     var f = Gr.GetRandomStudent();
     System.Console.WriteLine("id -----------firstname------------lastname-----------phone-----------group_id");
    System.Console.WriteLine($"{f.id}        {f.first_name}         {f.last_name}         {f.phone}          {f.group_id}");
}else if(l==3){
        int m;
        System.Console.Write(" groupid: ");
        m= Convert.ToInt32(Console.ReadLine());
        var f = Gr.GetStudentbyGroupId(m);
             System.Console.WriteLine("id -----------firstname------------lastname-----------phone-----------group_id");
        foreach (var i in f){
    System.Console.WriteLine($"{i.id}        {i.first_name}         {i.last_name}         {i.phone}          {i.group_id}");
        }
    }else if(l==6){
       var d= Gr.GetGroupByStudent();
       foreach (var t in d)
    {
        System.Console.WriteLine($"{t.group_name}         {t.first_name}          {t.last_name}           {t.phone}");
    }
    }
    else if(l==7){
    int t;
    System.Console.WriteLine("grop id: ");
    t= Convert.ToInt32(Console.ReadLine());
     var c=Gr.GetGroupWidtStudent(t);
     System.Console.WriteLine("groupname        firstname         lastname         phone");
     foreach (var e in c)
     {
      System.Console.WriteLine($"{e.group_name}         {e.first_name}          {e.last_name}          {e.phone}");  
     }
        
    

    }
    }