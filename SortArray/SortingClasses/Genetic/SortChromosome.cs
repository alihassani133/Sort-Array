using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray.SortingClasses.Genetic
{
    class SortChromosome : ChromosomeBase
    {
        private readonly int[] array;

        public SortChromosome(int[] array) : base(array.Length)
        {
            this.array = array;

            for (int i = 0; i < array.Length; i++)
            {
                ReplaceGene(i, new Gene(array[i]));
            }
        }

        public override Gene GenerateGene(int geneIndex)
        {
            return new Gene(array[geneIndex]);
        }

        public override IChromosome CreateNew()
        {
            return new SortChromosome(array);
        }
    }
}
