using System;
namespace Week5.Task3
{
    class IndexerClass
    {
        private float[] val = new float[3];

        // Indexer
        public float this[int index]
        {
            get
            {
                return val[index];
            }

            set
            {
                val[index] = value;
            }
        }
    }

    class IndexerWork
    {
        public static void Main(string[] args)
        {
            IndexerClass ic = new IndexerClass();
            ic[0] = 12.2f;
            ic[1] = 9.2f;
            ic[2] = 23.2f;

            Console.WriteLine("{0}\n{1}\n{2}", ic[0], ic[1], ic[2]);
        }
    }
}