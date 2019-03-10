namespace Catalog.Migrations
{
    using Catalog.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Catalog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(Catalog.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

          

            var students = new List<Student>
            {
                new Student { StudentID=1, FirstMidName = "Carsonz", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "1"
                }, //ApplicationUser =users.First() },
                new Student {StudentID=2, FirstMidName = "Meredithsdas", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "2"},
                new Student {StudentID=3, FirstMidName = "Arturo2", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "3"},
                 new Student {StudentID=4, FirstMidName = "Yaaan", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "4"},
                new Student {StudentID=5, FirstMidName = "Gytisewq", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "5"},            
                new Student {StudentID=6, FirstMidName = "Pegdsagy", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "6"},
                new Student {StudentID=7, FirstMidName = "Laudasra", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "7"},
                new Student {StudentID=8, FirstMidName = "Ninoq", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "8"},
                 new Student {StudentID=9, FirstMidName = "NinovNanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed = "9"},
                  new Student { StudentID=10, FirstMidName = "Carwson", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "10"}, //ApplicationUser =users.First() },
                 new Student { StudentID=11, FirstMidName = "Caryson", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "11"}, //ApplicationUser =users.First() },
                new Student {StudentID=12, FirstMidName = "Meresddith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "12"},
                new Student {StudentID=13, FirstMidName = "Arturozw", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "13"},
                 new Student {StudentID=14, FirstMidName = "Ys1an", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "14"},
                new Student {StudentID=15, FirstMidName = "Gytisksi", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "15"},         
                new Student {StudentID=16, FirstMidName = "Pzeggy", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "16"},
                new Student {StudentID=17, FirstMidName = "Lawura", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                new Student {StudentID=18, FirstMidName = "Nisno", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student {StudentID=19, FirstMidName = "NinogrNanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                  new Student { StudentID=20, FirstMidName = "Car24son", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "0"
                }, //ApplicationUser =users.First() },
                new Student {StudentID=21, FirstMidName = "Meredffwith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "0"},
                new Student {StudentID=22, FirstMidName = "ArtuDANro", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "0"},
                new Student {StudentID=23, FirstMidName = "Gyasdtis", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "0"},
                new Student {StudentID=24, FirstMidName = "Ya2een", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "0"},
                new Student {StudentID=25, FirstMidName = "Pi5eggy", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "0"},
                new Student {StudentID=26, FirstMidName = "Lauyrera", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                new Student {StudentID=27, FirstMidName = "Nieeeno", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student {StudentID=28, FirstMidName = "NineyeeoNanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                  new Student { StudentID=29, FirstMidName = "Caeeerrson", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "0"
                }, //ApplicationUser =users.First() },
                new Student {StudentID=30, FirstMidName = "Meretttydith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "0"},
                new Student {StudentID=31, FirstMidName = "Artuuuiuro", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "0"},
                new Student {StudentID=32, FirstMidName = "Gytutttis", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "0"},
                new Student {StudentID=33, FirstMidName = "Yhfgan", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "0"},
                new Student {StudentID=34, FirstMidName = "Peddbggy", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "0"},
                new Student {StudentID=35, FirstMidName = "Laxxcura", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                new Student {StudentID=36, FirstMidName = "Ninoslko", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student {StudentID=37, FirstMidName = "NinohheNanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student { StudentID=38, FirstMidName = "Ca3dsrson", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "0"
                }, //ApplicationUser =users.First() },
                new Student {StudentID=39, FirstMidName = "Meredixxth", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "0"},
                new Student {StudentID=40, FirstMidName = "sArturo", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "0"},
                new Student {StudentID=41, FirstMidName = "Gaawytis", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "0"},
                new Student {StudentID=42, FirstMidName = "Yanxxaa", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "0"},
                new Student {StudentID=43, FirstMidName = "Peggyhhf", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "0"},
                new Student {StudentID=44, FirstMidName = "Laddfsdxura", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                new Student {StudentID=45, FirstMidName = "Niniuo", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student {StudentID=46, FirstMidName = "NinyyyoNanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student { StudentID=47, FirstMidName = "Carsyuion", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "0"
                }, //ApplicationUser =users.First() },
                new Student {StudentID=48, FirstMidName = "Meredutuith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "0"},
                new Student {StudentID=49, FirstMidName = "Aryturryeo", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "0"},
                new Student {StudentID=50, FirstMidName = "Gytyreis", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "0"},
                new Student {StudentID=51, FirstMidName = "Ygfdan", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "0"},
                new Student {StudentID=52, FirstMidName = "Peggfdgy", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "0"},
                new Student {StudentID=53, FirstMidName = "Lauvcra", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                new Student {StudentID=54, FirstMidName = "Ninbcvo", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student {StudentID=55, FirstMidName = "NinoNbvcanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed ="0"},
                  new Student { StudentID=56, FirstMidName = "Caghhkrson", LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")/*,ApplicationUser_Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831"*//*StudentID=7*/
                    ,Seed = "0"
                }, //ApplicationUser =users.First() },
                new Student {StudentID=57, FirstMidName = "Meredityiths", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")/*ApplicationUser_Id ="76fb9330-379c-4cae-acc5-27b7a57d1b6d" */
                 ,Seed = "0"},
                new Student {StudentID=58, FirstMidName = "Artudiytro", LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01") /*ApplicationUser_Id ="9c8c0052-60a9-49a4-8fbb-7b8b7b935baa"*/
                 ,Seed = "0"},
                new Student {StudentID=59, FirstMidName = "Gytityfis", LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="9432d8c5-a713-4190-8b8a-392ca7a4f911"*/
                 ,Seed = "0"},
                new Student {StudentID=60, FirstMidName = "Yaghnhgn", LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2002-09-01") /*ApplicationUser_Id ="00000"*/
                 ,Seed = "0"},
                new Student {StudentID=61, FirstMidName = "Peghnvbggy", LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2001-09-01")/*ApplicationUser_Id ="020cd213-ca4f-4756-8dcf-58e98ee4624b"*/
                 ,Seed = "0"},
                new Student {StudentID=62, FirstMidName = "Lauhjjra", LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2003-09-01")/*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                new Student {StudentID=63, FirstMidName = "Nggggino", LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                 new Student {StudentID=64, FirstMidName = "NinoNfffffanana", LastName = "Olivettotototo",
                    EnrollmentDate = DateTime.Parse("2005-09-07") /*ApplicationUser_Id =""*/
                 ,Seed = "0"},
                };

            students.ForEach(s => context.Students.AddOrUpdate(s));
            context.SaveChanges();

            var courses = new List<Course>
                {
                new Course{CourseID=1050,Title="Chemistry",Credits=3,},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseID=1045,Title="Calculus",Credits=4,},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseID=2021,Title="Composition",Credits=3,},
                new Course{CourseID=2042,Title="Literature",Credits=4,}
                };
            courses.ForEach(s => context.Courses.AddOrUpdate(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
                {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050,},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
                };
            enrollments.ForEach(s => context.Enrollments.AddOrUpdate(s));
            context.SaveChanges();  //DBCC CHECKIDENT (Students, RESEED, 0)



            var users = new List<ApplicationUser>
                {
                //new ApplicationUser{Id="4fdc31a1-13f0-4d27-92b0-56cefc58f831",Email="danbaluss@yahoo.com",EmailConfirmed=false,
                //    PasswordHash ="AKADAMByEfhHDvVIrlPWMPrjyA/AG4a0esNHusa5OGIpHeiPgQcpypsJL85ZFGdOcg==",
                //    SecurityStamp ="0fe49f0c-94f2-4265-b458-a40a67bb6b67",PhoneNumberConfirmed=false,TwoFactorEnabled=false,
                //    LockoutEnabled =true,AccessFailedCount=0,UserName="danbalus@yahoo.com",/*ApplicationUserID="s"*/ },

                new ApplicationUser {Id= "76fb9330-379c-4cae-acc5-27b7a57d1b6d",  Email= "aaaa@yahoo.com" ,  EmailConfirmed=false ,
                    PasswordHash = "ANo/FwLUtW4MgAeuWlT5fTtPVr941gipdpPq2UCMH4xBmeCm9axkO3dvT4Tq4oBtjQ=="  ,
                    SecurityStamp = "f2c471af-2e42-4ec5-8ae8-d73b228c3e3e",   PhoneNumber= null  , PhoneNumberConfirmed=false ,
                    TwoFactorEnabled =false   , LockoutEndDateUtc = null  ,   LockoutEnabled=true , AccessFailedCount =0 , UserName = "aaaa@yahoo.com"},

                new ApplicationUser {  Id= "9c8c0052-60a9-49a4-8fbb-7b8b7b935baa",  Email= "aaava@yahoo.com" ,  EmailConfirmed=false ,
                    PasswordHash = "ACaNs5FceavAey2HZBkdK5aZ/cSvF1tM+LmmEiu3cw99+V0ElpabEotLWm6mD6zrxw=="  ,
                    SecurityStamp = "d9fbc959-8e02-4d8d-af32-49259cb10bfc",   PhoneNumber= null  , PhoneNumberConfirmed=false ,
                    TwoFactorEnabled =false   , LockoutEndDateUtc = null  ,   LockoutEnabled=true , AccessFailedCount =0 , UserName = "aaava@yahoo.com"},

                new ApplicationUser{Id="9432d8c5-a713-4190-8b8a-392ca7a4f911",Email="db@yahoo.com",EmailConfirmed=false,
                    PasswordHash ="AIAQyoq9anr1IQVmse8ssXMlPVeYtoVCFL5Dc/2YIIaShIZ7xEjVRA3dtiZDlpFAzg==",
                    SecurityStamp ="05484c39-fd53-47e1-9dd8-c26081043ed8",PhoneNumberConfirmed=false,TwoFactorEnabled=false,
                    LockoutEnabled =true, AccessFailedCount =0,UserName="db@yahoo.com" },

                   new ApplicationUser{Id="020cd213-ca4f-4756-8dcf-58e98ee4624b",Email="vvvvvvvvv@yahoo.com",EmailConfirmed=false,
                    PasswordHash ="ABeeD9C4R7fpBH+pcOrVujhvLmXP53N/ZOb2BuacfgRz5WLV9VAUYySLRurj6MC6og==",
                    SecurityStamp ="05484c39-fd53-47e1-9dd8-c26081043ed8",PhoneNumberConfirmed=false,TwoFactorEnabled=false,
                    LockoutEnabled =true, AccessFailedCount =0,UserName="vvvvvvvvv@yahoo.com" },
               // new ApplicationUser{Id="4fdc31a1-13f0-4d27-92b0-56cefc58f832",Email="oooo@yahoo.com",EmailConfirmed=false,PasswordHash="AKADAMByEfhHDvVIrlPWMPrjyAesNHugfgfgfsa5OGIpHeiPgQcpypsJL85ZFGdOcg==",SecurityStamp="0fe49f0c-94f2-4265-b458-a40a67bb6b67",PhoneNumberConfirmed=false,TwoFactorEnabled=false,LockoutEnabled=true,AccessFailedCount=0,UserName="danbalus@yahoo.com" },        
                // new ApplicationUser{Id="fdfdfdfdf",UserName="admin"},
               // new ApplicationUser{Id="fdfdsdfdfdf",UserName="user"},
               // new ApplicationUser{Id="fdfdfdfdfdf",UserName="user"},
                //new ApplicationUser{Id="fdfdfggdfdf",UserName="user"},
                };
            users.ForEach(s => context.Users.AddOrUpdate(s));
            context.SaveChanges();


            var roles = new List<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>
                {
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole{Id="1", Name="Admin"},
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole{Id="2", Name="User"},
                };
            roles.ForEach(s => context.Roles.AddOrUpdate(s));
            context.SaveChanges();

                var userRoles = new List<Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole>
                {
                //new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole{UserId="4fdc31a1-13f0-4d27-92b0-56cefc58f831", RoleId="1"},
                new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole{UserId="9432d8c5-a713-4190-8b8a-392ca7a4f911", RoleId="2"},
                new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole{UserId="020cd213-ca4f-4756-8dcf-58e98ee4624b", RoleId="1"},
                };
            userRoles.ForEach(s => context.UserRoles.AddOrUpdate(s));
            context.SaveChanges();

            Course Course1 = new Course { CourseID = 10501, Title = "Chemistry", Credits = 3, };
            Course Course2 = new Course { CourseID = 40411, Title = "Macroeconomics", Credits = 3, };
            Course Course3 = new Course { CourseID = 10451, Title = "Calculus", Credits = 4, };
            ICollection<Course> Courses = new List<Course>
            {
                Course1,
                Course2,
                Course3
            };

            var professors = new List<Professor>
            {


                new Professor {ProfessorID = 1, FirstMidName = "Carsonprof",     LastName = "Alexander" ,   Courses = Courses},
                new Professor {ProfessorID = 2, FirstMidName = "Meredithprof",   LastName = "Alonso",       Courses = Courses },
                new Professor {ProfessorID = 3, FirstMidName = "Arturoprof",     LastName = "Anand",        Courses = Courses },
                new Professor {ProfessorID = 4, FirstMidName = "Gytisprof",      LastName = "Barzdukas",    Courses = Courses  },
                new Professor {ProfessorID = 5, FirstMidName = "Yanprof",        LastName = "Li",            Courses = Courses },
                new Professor {ProfessorID = 6, FirstMidName = "Peggyprof",      LastName = "Justice",      Courses = Courses},
                new Professor {ProfessorID = 7, FirstMidName = "Lauraprof",      LastName = "Norman",       Courses = Courses },
                new Professor {ProfessorID = 8, FirstMidName = "Ninoprof",       LastName = "Olivetto",      Courses = Courses }
                };

            professors.ForEach(s => context.Professors.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
