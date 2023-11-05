using System;
using Domain.Models;
namespace Service.Services
{
    public class DataServices
    {
        DataList<Student> students = new()
        {
            students.Add(new Student{FullName = "Nisa Narimanova", Age = 26}),
            students.Add(new Student {FullName = "Rufa Ahmadova", Age = 26}),


            students.GetAll()
            {
                foreach(var item in students)
                {
                    Console.WriteLine(item.Fullname)
                }
            }
        }

    }






}



 


