
string[] array = new string[] {"hello","world", "7", "5215341", "123", "234", "00", "1", "2", "3", "4"};
for (int i=0; i < array.Length; i++)
{ 
    if (array[i].Length <=3)
    Console.Write(array[i] + " ");
}
