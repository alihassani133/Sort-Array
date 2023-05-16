using GeneticSharp;
using SortArray.SortingClasses.Genetic;

namespace SortArray.SortingClasses
{
    class GeneticSort : ISort
    {
        public void SortArray(int[] array)
        {
            // Define chromosome representation
            var chromosome = new SortChromosome(array);

            // Define fitness function
            var fitness = new FuncFitness((c) =>
            {
                var genes = ((SortChromosome)c).GetGenes();
                int[] sortedArray = genes.Select(g => (int)g.Value).OrderBy(g => g).ToArray();

                // Fitness is based on the number of misplaced elements (the fewer, the better)
                return array.Length - GetNumberOfMisplacedElements(array, sortedArray);
            });

            // Create the population
            var population = new Population(50, 100, chromosome);

            // Define the genetic operators
            var selection = new EliteSelection();
            var crossover = new OnePointCrossover();
            var mutation = new ReverseSequenceMutation();

            // Create the genetic algorithm
            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation)
            {
                Termination = new GenerationNumberTermination(100)
            };

            // Start the genetic algorithm
            ga.Start();

            // Get the best solution (sorted array) after the genetic algorithm terminates
            var bestSolution = ((SortChromosome)ga.BestChromosome).GetGenes().Select(g => (int)g.Value).ToArray();

            // Copy the sorted array to the input array
            Array.Copy(bestSolution, array, array.Length);
        }

        private int GetNumberOfMisplacedElements(int[] array1, int[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    count++;
            }
            return count;
        }
    }
} 

