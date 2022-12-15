int[] myArray = {35, 71, 223, 21, 78};

int min_N = myArray[0];
int max_N = 0;
int result = 0;



for ( int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < min_N)
    {
        min_N = myArray[i];
        
    }
}


for ( int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > max_N)
    {
        max_N = myArray[i];
    
    }
}
result = max_N - min_N; 
Console.WriteLine(result );
Console.ReadLine();




