using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetUuid
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        [Benchmark(Baseline = true)]
        public void Guid_NewGuid()
        {
            var guid = Guid.NewGuid();
        }

        [Benchmark]
        public void Ulid_NewUlid()
        {
            var ulid = Ulid.NewUlid();
        }

        [Benchmark]
        public void Ulid_Guid()
        {
            var ulid = Ulid.NewUlid();
            var guid = ulid.ToGuid();
        }
        
        [Benchmark]
        public void Guid_String()
        {
            var guid = Guid.NewGuid();
            var str = guid.ToString();
        }

        [Benchmark]
        public void Ulid_String()
        {
            var ulid = Ulid.NewUlid();
            var str = ulid.ToString();
        }
    }
}
