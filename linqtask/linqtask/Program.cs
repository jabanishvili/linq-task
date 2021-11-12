using System;
using System.Collections.Generic;
using System.Linq;

namespace linqtask
{// CS1012.cs  
    class Sample
    {

        class Account
        {


            public string firstname { get; set; }
            public string lastname { get; set; }
            public double number { get; set; }
            public double balancel { get; set; }


        }


        class Email
        {
            public string name { get; set; }
            public string email { get; set; }




            class Transport
            {
                public string Type { get; set; }
                public string TransportName { get; set; }


            }




            class Program
            {

                private static object word;
                private static char w;

                static void Main(string[] args)
                {
                    //tsk1
                    int[] nums = { 1, -2, 3, 0, -4, 5 };
                    var query = from i in nums
                                where i > 0
                                select i;
                    Console.WriteLine("0 ze meti ciffrebi:");
                    foreach (var item in query)
                    {
                        Console.WriteLine($"{item}");
                    }


                    //task2
                    int[] numss = { 1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10 };
                    query = from a in numss
                            where (a > 0 && a < 10)
                            select a;
                    Console.WriteLine("0ze meti 10ze naklebi");
                    foreach (var item in query)
                    {
                        Console.WriteLine($"{item}");
                    }



                    //task3
                    string[] strs = { ".com", ".net", "hsNameA.com", "hsNameB.net",
                 "test", ".network", "hsNameC.net", "hsNameD.com" };
                    var stringquery = from word in strs
                                      where word.EndsWith(".net")
                                      select word;

                    Console.WriteLine("mtavrdeba net it");
                    foreach (var item in stringquery)
                    {
                        Console.WriteLine($"\t{item}");
                    }

                    //task 4

                    List<Account> accounts = new List<Account>
                {
                    new Account{firstname= "ani", lastname="jbn", number=1233456789, balancel= 4},
                    new Account {firstname="bani", lastname="ananna", number= 321456789, balancel= 5},
                };
                    var Accountquery = from i in accounts
                                       group i by i.firstname
                                      into f
                                       orderby f.Key
                                       select f;
                    foreach (var group in Accountquery)
                    {
                        Console.WriteLine($"firstname:{group.Key + ""}");
                        foreach (var item in group)
                        {
                            Console.WriteLine($"lastname: {item.lastname}\n balance:{item.balancel}");
                        }
                    }


                    //task 5

                    double[] numberss = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5 };
                    var kvadratulifesvi = from number in numberss
                                          let s = Math.Sqrt(number)

                                          select s;
                    Console.WriteLine("kvadratuli fesvi");
                    foreach (var item in kvadratulifesvi)
                    {
                        Console.WriteLine(item);
                    }

                    //task 6
                    List<Email> emails = new List<Email> {
    new Email {name="ani", email="ani.jbn@gmail.com"},
    new Email {name="bani", email="bani.ami@gmail.com"}
};
                    var emailquary = from e in emails
                                     group e by e.email
                                     into m
                                     orderby m.Key
                                     select m;
                    foreach (var item in emailquary)
                    {
                        Console.WriteLine(item);
                    }



                    //task7
                    string[] sites = {"hsNameA.com", "hsNameB.net", "hsNameC.net",
                 "hsNameD.com", "hsNameE.org", "hsNameF.org",
                 "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };
                    var queryy = from s in sites
                                 group s by s.Split('.').Last()
                          into result
                                 where result.Key.Count() > 2
                                 select result;
                    Console.WriteLine("domain >3");

                    // foreach (var item in queryy)
                    {
                        //.WriteLine($"key:{item.Key}\nvalue");
                        // foreach (var i in item)
                        {
                            //Console.WriteLine($"\t{i}");
                        }

                        Console.WriteLine();


                        //8task

                        //task9
                        string[] type = { "air", "sea", "land" };



                        Transport[] transports =
                          {
                new Transport {TransportName="ship",Type="sea" },
                new Transport {TransportName="car", Type="land"},
                new Transport {TransportName= "boat",Type="sea"},
                new Transport {TransportName="airplane",Type="air"},
                new Transport{TransportName="carriage", Type="land"},
            };
                        var quaryTr = from t in type
                                      join p in transports
                                      on t equals p.Type
                                      into x
                                      select new { key = t, value = x };
                        foreach (var item in quaryTr)
                        {
                            Console.WriteLine($"type {item.key}");
                            foreach (var i in item.value)
                            {
                                Console.WriteLine($"\t{i.TransportName}");
                            }

                        }



                        Console.ReadLine();


                    }
                }
            }
        }
    }

}