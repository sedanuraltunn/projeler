int[] array = new int[3];
array[0] = 3;
array[1] = 5;
array[2] = 4;

var elemaSayi = array.Length;
for (int i = 0; i< elemaSayi; i++)
{
    Console.WriteLine($"{i+1}. elmeman {array[i]}");
}
      