using Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.BLL
{
    public class GameBLL
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public /*dynamic*/  List<Student> StudentsList()
        {
            var students = from s in db.Students
                          select s;
            return students.ToList();
        }
        private static Random rng = new Random();

        //public static void Shuffle<T>(this IList<T> list, int from)
        //{
        //    int n = list.Count;
        //    while (n > 1 + from)
        //    {
        //        n--;
        //        int k = rng.Next( from + 1, n + 1);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        //}
        public List<Tuple<Student, Student>> GenerateRandomPairs()
        {
            List<Tuple<Student, Student>> listOfMatches = new List<Tuple<Student, Student>>();
            List<Student> allStudents = StudentsList();
            int nrOfStudents = allStudents.Count;
            int nrTotalOfSeeders = nrOfStudents >> 2;
            int nrCurentOfSedders = 0;
      
            allStudents = allStudents.OrderBy(o => o.Seed).ToList();
            //Shuffle(allStudents, nrTotalOfSeeders);
            //List<Student> seedPlayers = 

            Random rnd = new Random();

            while (allStudents.Count >= 2)
            {
                int randomStudentIndex1 = rnd.Next(allStudents.Count);
                int randomStudentIndex2 = rnd.Next(allStudents.Count);
                Student randomStudent1 = allStudents.ElementAt(randomStudentIndex1);
                Student randomStudent2 = allStudents.ElementAt(randomStudentIndex2);

                if (randomStudent1.Seed != randomStudent2.Seed /*|| allStudents.Count <=2*/)
                {
                    Tuple<Student, Student> match = new Tuple<Student, Student>(randomStudent1, randomStudent2);
                    listOfMatches.Add(match);
                    allStudents.Remove(randomStudent1);
                    allStudents.Remove(randomStudent2);
                }
            }
            return listOfMatches;
        }
    }
}