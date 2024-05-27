namespace Generics_Example
{
    public class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        // Adicionando valores ao vetor e atualizando o contador
        public void AddValue(T value)
        {
            // Criando uma exceção quando o contador estiver cheio
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full!");
            }

            _values[_count] = value;
            _count++;
        }
        
        // Metodo para retornar o primeiro valor do vetor
        public T First()
        {
            // Exceção indicando que o contador ainda está vazio
            if(_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty!");
            }

            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }

    }
}
