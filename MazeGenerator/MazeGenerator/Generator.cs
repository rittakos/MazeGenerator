using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    public enum GeneratorAlgorithmType { Random, Kruskal}
    public abstract class GeneratorAlgorithm
    {
        protected GeneratorAlgorithm(int seed, GeneratorAlgorithmType type)
        {
            this.type = type;
            this.seed = seed;
        }

        protected GeneratorAlgorithmType type;
        protected int seed;
        public abstract void generate();

    }

    public class KruskalAlgorithm : GeneratorAlgorithm
    {
        public KruskalAlgorithm(int seed) : base(seed, GeneratorAlgorithmType.Kruskal)
        {
            
        }
        public override void generate()
        {
            throw new NotImplementedException();
        }
    }

    public class Generator
    {
        private GeneratorAlgorithm      algorithm;
        private GeneratorAlgorithmType  algoritgmType;

        public void setAlgorithm(GeneratorAlgorithmType type)
        {
            algoritgmType = type;
        }
        public void generate(int seed)
        {

        }

        public void generate()
        {

        }
    }
}
