using ExamWork.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Добавим страну, город этой страны, улицу этого города:");
            CRUD.Create();
            CRUD.Show();
            System.Console.WriteLine("Изменим наименование улицы:");
            CRUD.Change();
            System.Console.WriteLine("\n\n");
            CRUD.Show();
            System.Console.WriteLine("Удалим улицу города:");
            CRUD.Delete();
            CRUD.Show();
        }
    }
}
