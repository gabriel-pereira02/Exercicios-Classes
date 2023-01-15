namespace NullableProps
{
    class Program{
        static void Main(string[] args){
            double? x = null;
            double? y = 10;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue){
                Console.WriteLine(x.Value);
            } 
            else{
                Console.WriteLine("X é nulo");
            }

            if(y.HasValue){
                 Console.WriteLine(y.Value);
            } 
            else{
                Console.WriteLine("Y é nulo");
            }

            double a = x ?? 10;
            Console.WriteLine(a);
            Console.WriteLine("------");
            x = 20;
            a = x ?? a;
            Console.WriteLine(a);
        }
    }
}
