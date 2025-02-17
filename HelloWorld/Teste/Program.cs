int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2};
var count = 0;
foreach (var vote in votes)
{
    if (vote > 3){
    Console.WriteLine("ok");
        continue;
        }



    count++;
}
Console.WriteLine(count + " votos válidos");