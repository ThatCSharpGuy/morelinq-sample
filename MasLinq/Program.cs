using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MoreLinq;

namespace MasLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var dinos = Data.Dinosaurs;

            var endsWithSaurus = dinos.Where(dino => dino.Name.EndsWith("saurus"));
            var startsWithH = dinos.Where(dino => dino.Name.StartsWith("H"));

            if (endsWithSaurus.AtLeast(5))
            {
                Console.WriteLine("There are at least 5 dinosaurs whose name ends with saurus");
            }
            if (startsWithH.AtMost(1))
            {
                Console.WriteLine("There are at most 1 dinosaur whose name starts with H");
            }

            var countByHeight = dinos.CountBy(d => d.Height);
            foreach (var dinosaur in dinos)
            {
                Console.WriteLine(dinosaur.Height);
            }

            foreach (var height in countByHeight)
            {
                Console.WriteLine("There are " + height.Value + " whose height is " + height.Key);
            }

            var distinctByHeight = dinos.DistinctBy(d => d.Height);
            foreach (var dinosaur in distinctByHeight)
            {
                Console.WriteLine(dinosaur);
            }

            var dinosaursWithY = dinos.Where(d => d.Name.StartsWith("Y")).FallbackIfEmpty(new Dinosaur[]
            {
                new Dinosaur { Name = "Noexistesaurus" }
            });
            foreach (var dinosaur in dinosaursWithY)
            {
                Console.WriteLine(dinosaur);
            }

            var tallestDinosaur = dinos.MaxBy(d => d.Height);
            Console.WriteLine(tallestDinosaur);

            var lightestDinosaur = dinos.MinBy(d => d.Weight);
            Console.WriteLine(lightestDinosaur);

            var sortedByHeight = dinos.OrderBy(d => d.Height);
            var sortedByWeight = dinos.OrderBy(d => d.Weight);
            Console.WriteLine("====");
            foreach (var dinosaur in sortedByHeight)
            {
                Console.WriteLine(dinosaur);
            }
            Console.WriteLine("====");
            foreach (var dinosaur in sortedByWeight)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("====");
            var notSoTallDinosaurs = sortedByHeight.TakeUntil(d => d.Height >= 5);
            foreach (var dinosaur in notSoTallDinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            var notSoLightDinosaurs = sortedByWeight.SkipUntil(d => d.Weight >= 6000);
            Console.WriteLine("====");
            foreach (var dinosaur in notSoLightDinosaurs)
            {
                Console.WriteLine(dinosaur);
            }


            var ultimosDos = dinos.TakeLast(2);
            Console.WriteLine("====");
            foreach (var dinosaur in ultimosDos)
            {
                Console.WriteLine(dinosaur);
            }

            var todosMenosUltimosDos = dinos.SkipLast(2);
            Console.WriteLine("====");
            foreach (var dinosaur in todosMenosUltimosDos)
            {
                Console.WriteLine(dinosaur);
            }
            
            Console.Read();
        }
    }
}
