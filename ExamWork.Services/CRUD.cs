using ExamWork.DataAccess;
using ExamWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork.Services
{
    public class CRUD
    {
        public static void Create()
        {
            using (var context = new ExamContext())
            {

                Cantry cantry = new Cantry { Name = "Kazakstan" };

                context.Cantries.Add(cantry);
                context.SaveChanges();

                City city = new City { Name = "Karagandy", Cantry = cantry };
                context.Cities.Add(city);
                context.SaveChanges();
                Street street = new Street { Name = "17 mkr", City = city };
                context.Streets.Add(street);
                context.SaveChanges();

            }
        }

        public static void Show()
        {
            using (var context = new ExamContext())
            {
                foreach (var street in context.Streets.ToList())
                {
                    Console.WriteLine($"Street: {street.Name}\n City:{street.City.Name}\n Cantry:{street.City.Cantry.Name}");
                }
            }
        }

        public static void Change()
        {
            using (var context = new ExamContext())
            {
                Street street = context.Streets.FirstOrDefault(s => s.Name == "17 mkr");
                street = new Street
                {
                    Name="18 mkr"
                };

                context.Streets.Add(street);
                context.SaveChanges();
            }
        }

        public static void Delete()
        {
            using (var context=new ExamContext())
            {

                Street street = context.Streets.FirstOrDefault(s => s.Name == "17 mkr" || s.Name == "18 mkr");

                if (street!=null)
                {
                    context.Streets.Remove(street);
                    context.SaveChanges();
                }
            }
        }

    }
}
