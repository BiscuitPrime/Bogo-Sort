// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bogo sort program !");

int N = 10; //number of values to sort
List<int> list = new(); //unsorted list

//method that creates the unordered list
List<int> createUnorderedList(List<int> list)
{
    for(int i=0; i < N; i++)
    {
        Random random = new Random();
        list.Add(random.Next()%50);
    }
    return list;
}

//method that prints the list
void printList(List<int> list)
{
    for(int i = 0; i < list.Count; i++) { Console.WriteLine(i + "==" + list[i]); }
}

//the sort
void bogoSort(List<int> list)
{
    int essais=0;
    while (!testSort(list)) //we test if list is unsorted
    {
        essais++;
        Console.Write(essais+"|");
        list = shuffleList(list); //we then randomnly shuffle the list
    }
    Console.WriteLine("List is sorted !");
}

//method that tests wether or not the list is sorted
bool testSort(List<int> list)
{
    int ini = list[0];
    for(int i= 0; i < list.Count; i++) 
    {
       if(ini>list[i])
       {
            return false; //if unsorted
       }
        ini=list[i];
    }
    return true;
}

//method that shuffles the list based on the Fisher-yates method
List<int> shuffleList(List<int> list)
{
    Random rand = new Random();
    int opNb = 0;
    for (int i = list.Count - 1; i > 0; i--)
    {
        int j = rand.Next(i + 1);
        int temp = list[j];
        list[j] = list[i];
        list[i] = temp;
    }
    return list;
}


createUnorderedList(list);
printList(list);
bogoSort(list);
printList(list);
