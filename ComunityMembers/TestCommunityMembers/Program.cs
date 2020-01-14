using CommunityModels.MembershipModels;
using System;
using CommunityRepository;
using CommunityRepository.DatabaseContext;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Threading;

namespace TestCommunityMembers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int workerThreads;
            int portThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
            Console.WriteLine("\nMaximum worker threads: \t{0}" +
            "\nMaximum completion port threads: {1}",
            workerThreads, portThreads);
            //Task.Run(() => MyMethod());
            Console.ReadKey();
        }

        public static async Task MyMethod()
        {
            SqlConnection conn = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "(localdb)\\MSSQLLocalDB",
                    InitialCatalog = "VBCommunity"
                }.ConnectionString
            );


            var options = new DbContextOptionsBuilder<FullDbContext>();
            //options.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VBCommunity;Integrated Security=True;");
            options.UseSqlServer(conn.ConnectionString);
            FullDbContext fullContext = new FullDbContext(options.Options);

            MemberRepository memberRepository = new MemberRepository(fullContext);
            Member member = new Member
            {
                LastName = "Apascaritei Sebastian",
                Observation = "nu sunt observatii",
                PlaceOfBaptism = "Dorohoi",
                SpouseName = "Apascaritei Irina"
            };
            Member mem = await memberRepository.Save(member, 1);

        }
    }
}
