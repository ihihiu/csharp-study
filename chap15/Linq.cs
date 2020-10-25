using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using static System.Console;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Dynamic;

namespace Linq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class InchProfile
    {
        public string Name { get; set; }
        public double Height { get; set; }

        public InchProfile(string name, double height)
        {
            Name = name;
            Height = height;
        }
    }
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Product 
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
             {
                new Profile(){ Name="정우성",Height=186},
                new Profile(){ Name="김태희",Height=158},
                new Profile(){ Name="고현정",Height=172},
                new Profile(){ Name="이문세",Height=178},
                new Profile(){ Name="하동훈",Height=171}
            };

            List<Profile> profiles = new List<Profile>();

            foreach (Profile profile in arrProfile)
                if (profile.Height < 175)
                    profiles.Add(profile);
            //람다식 사용, 키의 오름차순으로 정렬
            profiles.Sort((profile1, profile2) => (profile1.Height - profile2.Height));

            foreach (var profile in profiles)
                WriteLine("{0}, {1}", profile.Name, profile.Height);
            WriteLine("======================");

            //Linq문 사용
            var profiles1 = from profile in arrProfile
                            where profile.Height < 175
                            orderby profile.Height
                            select profile;
            foreach (var profile in profiles1)
                WriteLine("{0}, {1}", profile.Name, profile.Height);
            WriteLine("======================");

            double avg = profiles.Average(profile => profile.Height);

            double avg2 = (from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select profile).Average(profile => profile.Height);
            

            var profiles10 = arrProfile
                             .Where(profile => profile.Height < 175)
                             .OrderBy(profile => profile.Height)
                             .Select(profile => new { Name = profile.Name, InchHeight = profile.Height * 0.3 });



            int[] numbers = { 9, 2, 5, 7, 3, 4, 1, 8, 2 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            foreach (int n in result)
                WriteLine(n);
            WriteLine("======================");

            var result2 = from profile in arrProfile
                          where profile.Height < 175
                          orderby profile.Height descending
                          select new { Name = profile.Name, InchHeight = profile.Height * 0.3 };
            foreach (var profile in result2)
                WriteLine("{0}, {1}", profile.Name, profile.InchHeight);
            WriteLine("======================");

            var result3 = from profile in arrProfile
                          where profile.Height < 175
                          orderby profile.Height descending
                          select new InchProfile(profile.Name, profile.Height * 0.3);

            foreach (InchProfile profile in result3)
                WriteLine("{0}, {1}", profile.Name, profile.Height);
            WriteLine("======================");

            Class[] arrClass =
            {
                new Class(){Name = "연두반",Score = new int[]{99,80,70,24}},
                new Class(){Name = "분홍반",Score = new int[]{60,45,87,72}},
                new Class(){Name = "파랑반",Score = new int[]{92,30,85,94}},
                new Class(){Name = "노랑반",Score = new int[]{90,88,0,17}}
            };

            var classes = from c in arrClass
                            from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };
            foreach (var d in classes)
                WriteLine("{0}, {1}", d.Name, d.Lowest);
            WriteLine("======================");

            var listProfile = from profile in arrProfile
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };                
        
            foreach(var group in listProfile)
            {
                WriteLine("175 미만? : {0}", group.GroupKey);
                foreach (var profile in group.Profiles)
                    WriteLine("{0}, {1}", profile.Name, profile.Height);
            }
            WriteLine("======================");

            Product[] arrProduct =
             {
                new Product(){Star = "정우성",Title = "비트"},
                new Product(){Star = "김태희",Title = "CF 다수"},
                new Product(){Star = "김태희",Title = "아이리스"},
                new Product(){Star = "고현정",Title = "모래시계"},
                new Product(){Star = "이문세",Title = "Solo 예찬"},
                new Product(){Star = "박보검",Title = "응답하라 1988" }
            };
            //내부 조인
            var listProfile2 = from profile in arrProfile
                               join product in arrProduct on profile.Name equals product.Star
                               select new { Name = profile.Name, Work = product.Title, Height = profile.Height };

            foreach (var profile in listProfile2)
                WriteLine("{0}, {1}, {2}", profile.Name, profile.Work, profile.Height);
            WriteLine("======================");
            
            //외부 조인
            var listProfile3 = from profile in arrProfile
                               join product in arrProduct on profile.Name equals product.Star into ps
                               from product in ps.DefaultIfEmpty(new Product() { Title = "Empty"}) 
                               select new { Name = profile.Name, Work = product.Title, Height = profile.Height };

            foreach (var profile in listProfile3)
                WriteLine("{0}, {1}, {2}", profile.Name, profile.Work, profile.Height);
            WriteLine("======================");

            //외부 조인  - Product 기준
            var listProfile4 = from product in arrProduct
                               join profile in arrProfile on product.Star equals profile.Name into ps
                               from profile in ps.DefaultIfEmpty(new Profile() { Height = 0 })
                               select new { Name = product.Star, Work = product.Title, Height = profile.Height };

            foreach (var profile in listProfile4)
                WriteLine("{0}, {1}, {2}", profile.Name, profile.Work, profile.Height);
            WriteLine("======================");

            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175미만" : "175이상",
                                 Count = g.Count(),
                                 Max = g.Max(profile => profile.Height),
                                 Min = g.Min(profile => profile.Height),
                                 Avg = g.Average(profile => profile.Height)
                             };
            foreach (var stat in heightStat)
                WriteLine("{0} - Count : {1}, Min : {2}, Avg : {4}", 
                    stat.Group,stat.Count,stat.Max,stat.Min,stat.Avg);
           

        }
    }
}
