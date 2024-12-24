Console.Write("Entrez la hauteur du sapin souhaiter (entre 1 et 30) :\t");
string monSapin = Console.ReadLine();
int hauteurSapin = int.Parse(monSapin);

if (hauteurSapin >= 1 && hauteurSapin <= 30)
{
    void DessinerFeuilles(int feuilles)
    {

        for (int i = 0; i < hauteurSapin; i++)
        {
            
            for (int j = 1; j >= hauteurSapin - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
    DessinerFeuilles(hauteurSapin);
}

else
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Vous devez saisir une hauteur de sapin entre 1 et 30 uniquement");
    Console.ResetColor();
}

