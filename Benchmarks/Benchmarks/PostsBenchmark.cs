using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;
using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [MinIterationCount(2)]
    [MaxIterationCount(10)]
    public class PostsBenchmark
    {
        AppDbContext _context;

        [GlobalSetup]
        public void setup()
        {
            var efCoreOptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            efCoreOptionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StackOverflow2010;Integrated Security=True;TrustServerCertificate=True", opt =>
            {
                opt.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
            });
            var efCoreOptions = efCoreOptionsBuilder.Options;
            _context = new AppDbContext(efCoreOptions);
        }

        [Benchmark]
        public void GetAllColumn()
        {
            var posts = _context.Posts
                .OrderByDescending(i => i.ClosedDate)
                .Take(20)
                .ToList();
        }

        [Benchmark]
        public void GetTwoColumn()
        {
            var posts = _context.Posts
                .OrderByDescending(i => i.ClosedDate)
                 .Select(i => new
                 {
                     i.Id,
                     i.Title,

                 })
                .Take(20)
                .ToList();
        }

        [GlobalCleanup]
        public void cleanup()
        {
            _context.Dispose();
        }

    }
}
