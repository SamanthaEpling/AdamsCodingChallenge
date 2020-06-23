using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AdamsCodingChallenge.Models;

namespace AdamsCodingChallenge.DAL
{
    public class ChallengeInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ChallengeContext>
    {
        protected override void Seed(ChallengeContext context)
        {
            var admins = new List<Admin>
            {
                new Admin{FirstName="Romani",LastName="Epling",Email="romani@epling.com"},
                new Admin{FirstName="Lionel",LastName="Epling",Email="lionel@epling.com"},
                new Admin{FirstName="Hermione",LastName="Epling",Email="hermione@epling.com"}
            };
            admins.ForEach(s => context.Admins.Add(s));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{FirstName="Mister",LastName="Epling",Email="mister@epling.com"},
                new Student{FirstName="Rosie", LastName="Epling",Email="rosie@epling.com"},
                new Student{FirstName="Love Bug", LastName="Epling", Email="lovebug@epling.com"}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}