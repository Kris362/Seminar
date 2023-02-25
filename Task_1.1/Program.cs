/*Показать кубы чисел, заканчивающихся на четную цифру*/

Console.Clear ();

int[] array = new int[] {13,342,85,44,13,10};
int i=0;
double pow=Math.Pow(array[i],3);
if((array[i] % 2) == 0) 
{
    pow=Math.Pow(array[i],3);
    i++;
    System.Console.WriteLine($"{pow}");
    
}
else
{
    System.Console.WriteLine("Число заканчивается на нечетную цифру");
}

