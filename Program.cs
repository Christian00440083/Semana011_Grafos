int[,] mat = new int[5,7];
Random rand = new Random();

for (int f = 0; f < mat.GetLongLength(0); f++)
{ for (int C = 0; C < mat.GetLongLength(1); C++)
    { mat[f,C] = rand.Next(1, 10);
    }
}
for (int f = 0; f < mat.GetLongLength(0); f++)
{
    for (int C = 0; C < mat.GetLongLength(1); C++)
    {
       Console.Write(" "+ mat[f,C] +", ");
    }
    Console.WriteLine();
}
