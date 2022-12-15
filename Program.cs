int dice1 = 0;
int dice2 = 0;
int dice3 = 0;
int dice4 = 0;
int dice5 = 0;
bool fixed1 = false;
bool fixed2 = false;
bool fixed3 = false;
bool fixed4 = false;
bool fixed5 = false;
int count = 0;

string input;
Console.Clear();
Console.WriteLine("Welcome to the dice game");
void RollDice()
{
    if (fixed1 == false) { dice1 = Random.Shared.Next(1, 7); }
    if (fixed2 == false) { dice2 = Random.Shared.Next(1, 7); }
    if (fixed3 == false) { dice3 = Random.Shared.Next(1, 7); }
    if (fixed4 == false) { dice4 = Random.Shared.Next(1, 7); }
    if (fixed5 == false) { dice5 = Random.Shared.Next(1, 7); }


}
void PrintDice() { count++; System.Console.WriteLine($"Dice roll {count} of 3"); Console.WriteLine(dice1); Console.WriteLine(dice2); Console.WriteLine(dice3); Console.WriteLine(dice4); Console.WriteLine(dice5); }
void fixedDice()
{
    do
    {
        System.Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dice)");

        input = Console.ReadLine()!;

        switch (input)
        {
            case "1":
                if (fixed1 == false) { fixed1 = true; }
                else
                {
                    fixed1 = false;
                }
                break;
            case "2":
                if (fixed2 == false) { fixed2 = true; }
                else
                {
                    fixed2 = false;
                }
                break;
            case "3":
                if (fixed3 == false) { fixed3 = true; }
                else
                {
                    fixed3 = false;
                }
                break;
            case "4":
                if (fixed4 == false) { fixed4 = true; }
                else
                {
                    fixed4 = false;
                }
                break;
            case "5":
                if (fixed5 == false) { fixed5 = true; }
                else
                {
                    fixed5 = false;
                }
                break;
        }
        System.Console.WriteLine("Fixed :");
        if (fixed1 == true) { System.Console.WriteLine(dice1); }
        if (fixed2 == true) { System.Console.WriteLine(dice2); }
        if (fixed3 == true) { System.Console.WriteLine(dice3); }
        if (fixed4 == true) { System.Console.WriteLine(dice4); }
        if (fixed5 == true) { System.Console.WriteLine(dice5); }
        if (fixed1 == true && fixed2 == true && fixed3 == true && fixed4 == true && fixed5 == true) { System.Console.WriteLine(" You have no dices lelft"); System.Console.WriteLine($"Your final dices were {dice1}, {dice2}, {dice3}, {dice4}, {dice5}"); Environment.Exit(1); }
    } while (input != "r");

}


int temp;
void SortDice(){
    

for (int i = 10; i > 0; i--)
{
    for (int j = 0; j < 9; j++)
    {
        if (dice1 > dice2 )
        {
            temp = dice1 ;
            dice1 = dice2 ;
            dice2 = temp;
        }
        if (dice2 > dice3 )
        {
            temp = dice2 ;
            dice2 = dice3 ;
            dice3 = temp;
        }
         if (dice3 > dice4 )
        {
            temp = dice3 ;
            dice3 = dice4 ; ;
            dice4 = temp;
        }
         if (dice4 > dice5 )
        {
            temp = dice4 ;
            dice4 = dice5 ;
            dice5 = temp;
        }
        
    }
}
                System.Console.WriteLine($"Your final sortet dices were {dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
}

do
{
    RollDice();
    PrintDice();
    fixedDice();
} while (count < 3);
System.Console.WriteLine("Game finished");
System.Console.WriteLine($"Your final dices were {dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
SortDice();
RollDice();
void AnalyzingAndPrintResult(){
    if(dice1 == dice5 ){System.Console.WriteLine("Five of a kind");}
    else if(dice1 == dice4){System.Console.WriteLine("You have four of a kind");}
    else if(dice2 == dice5){System.Console.WriteLine("You have  four of a kind");}
    else if(dice1 == dice3 && dice4 == dice5){System.Console.WriteLine("You have a Full House");}
    else if(dice1 == dice2 && dice3 == dice5){System.Console.WriteLine("you have a Full House");}
    else if(dice1 == 1 && dice2 == 2 && dice3 == 3 && dice4 == 4 && dice5 == 5){System.Console.WriteLine("You have a Straight");}
    else if(dice1 == 2 && dice2 == 3 && dice3 == 4 && dice4 == 5 && dice5 == 6){System.Console.WriteLine("You have a great Straight");}
    else if(dice1 == dice3){System.Console.WriteLine("You have Three of a Kind");}
    else if(dice2 == dice4){System.Console.WriteLine("You have a three of a Kind");}
    else if(dice3 == dice5){System.Console.WriteLine("You have a Three of a Kind");}
    else if(dice1 == dice2 && dice4 == dice5){System.Console.WriteLine("You have Two Pair's");}
    else if(dice2 == dice3 && dice4 == dice5){System.Console.WriteLine("You have Two Pair's");}
    else if(dice1 == dice2 && dice3 == dice4){System.Console.WriteLine("You have Two Pair's");}
    else if(dice2 == dice3 || dice4 == dice5 || dice3 == dice4 || dice1  == dice2){System.Console.WriteLine("You have a one pair");}
    else{System.Console.WriteLine("You have a bust");}



}