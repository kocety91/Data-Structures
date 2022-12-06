
var number = int.Parse(Console.ReadLine());
var queue = new Queue<int>();
queue.Enqueue(number);
var sCounter = 1;
int? itteratorCounter = 0;
var currentNumber = number;

// S1 = N = 2

//S2 = S1 + 1 = (2 + 1) => 3
//S3 = 2*S1 + 1  = (2 * 2) + 1 => 5
//S4 = S1 + 2 = (2+2) => 4

//S5 = S2 + 1 = (3+1) => 4
//S6 = 2 * S2 + 1 = (2*3) + 1 => 7
//S7 = S2 + 2 = (3 + 2 ) => 5

//2 3 5 4 =>1st
//2 3 5 4 


for (int i = 0; i < 50; i++)
{
    if(itteratorCounter == null)
    {
        foreach (var item in queue.Select((value,index) => (value,index)))
        {
            if(item.index ==  sCounter)
            {
                currentNumber = item.value;
                break;
            }
        }
        sCounter++;
        itteratorCounter = 0;
    }

    if(itteratorCounter == 0)
    {
        queue.Enqueue(currentNumber + 1);
        itteratorCounter++;
    }
    else if(itteratorCounter == 1)
    {
        queue.Enqueue((2* currentNumber) + 1);
        itteratorCounter++;
    }
    else if(itteratorCounter == 2)
    {
        queue.Enqueue(currentNumber + 2);
        itteratorCounter = null;
    }
}


