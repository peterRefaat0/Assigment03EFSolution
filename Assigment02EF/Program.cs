using Assigment03EF.Data;
using Assigment03EF.Models;

namespace Assigment03EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assigment03EF_DbContext dbContext = new Assigment03EF_DbContext();

            
             void AddStudent(Student student)
            {
                using (var context = new Assigment03EF_DbContext())
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
            }

            
             Student GetStudent(int studentID)
            {
                using (var context = new Assigment03EF_DbContext())
                {
                    return context.Students.Find(studentID);
                }
            }

            
             void UpdateStudent(Student student)
            {
                using (var context = new Assigment03EF_DbContext())
                {
                    context.Students.Update(student);
                    context.SaveChanges();
                }
            }

        
             void DeleteStudent(int studentID)
            {
                using (var context = new Assigment03EF_DbContext())
                {
                    var student = context.Students.Find(studentID);
                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();
                    }
                }
            }











        }
    }
}
