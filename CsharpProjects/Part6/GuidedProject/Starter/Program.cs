/*
This application manages transactions at a store check-out line. The
check-out line has a cash register, and the register has a cash till
that is prepared with a number of bills each morning. The till includes
bills of four denominations: $1, $5, $10, and $20. The till is used
to provide the customer with change during the transaction. The item 
cost is a randomly generated number between 2 and 49. The customer 
offers payment based on an algorithm that determines a number of bills
in each denomination. 

Each day, the cash till is loaded at the start of the day. As transactions
occur, the cash till is managed in a method named MakeChange (customer 
payments go in and the change returned to the customer comes out). A 
separate "safety check" calculation that's used to verify the amount of
money in the till is performed in the "main program". This safety check
is used to ensure that logic in the MakeChange method is working as 
expected.
*/

string? readResult = null;
bool useTestData = false;

Console.Clear();

int[] cashTill = new int[] { 0, 0, 0, 0 };
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

LoadTillEachMorning(registerDailyStartingCash, cashTill);

registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// display the number of bills of each denomination currently in the till
LogTillStatus(cashTill);

// display a message showing the amount of cash in the till
Console.WriteLine(TillAmountSummary(cashTill));

// display the expected registerDailyStartingCash total
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random((int)DateTime.Now.Ticks);

int transactions = useTestData ? testData.Length : 100;

while (transactions > 0)
{
    Console.WriteLine($"Transactions remaining: {transactions}");
    transactions--;
    int itemCost = valueGenerator.Next(2, 50);

    if (useTestData)
    {
        itemCost = testData[testCounter];
        testCounter += 1;
    }

    // // value is 1 when itemCost is odd, value is 0 when itemCost is even
    // int paymentOnes = itemCost % 2;
    // // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    // int paymentFives = (itemCost % 10 > 7) ? 1 : 0;
    // // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    // int paymentTens = (itemCost % 20 > 13) ? 1 : 0;
    // // value is 1 when itemCost < 20, otherwise value is 2
    // int paymentTwenties = (itemCost < 20) ? 1 : 2;

    int paymentOnes = 0;
    int paymentFives = 0;
    int paymentTens = 0;
    int paymentTwenties = 0;

    int costTally = 0;

    do
    {
        switch (itemCost)
        {
            case >= 11:
                paymentTwenties++;
                costTally += 20;
                break;
            case >= 6:
                paymentTens++;
                costTally += 10;
                break;
            case >= 2:
                paymentFives++;
                costTally += 5;
                break;
            default:
                paymentOnes++;
                costTally += 1;
                break;
        }
    } while (costTally <= itemCost);

    // display messages describing the current transaction
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

    try
    {
        // MakeChange manages transaction and updates till:
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        Console.WriteLine("Successful transaction.");

        // Backup: to confirm that balance is accurate in the till
        registerCheckTillTotal += itemCost;
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Could not complete transaction: {e.Message}");
    }

    Console.WriteLine(TillAmountSummary(cashTill));
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
    Console.WriteLine();
}

Console.WriteLine("Press the Enter key to exit");
do
{
    readResult = Console.ReadLine();

} while (readResult == null);


static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
{
    cashTill[0] = registerDailyStartingCash[0, 1];
    cashTill[1] = registerDailyStartingCash[1, 1];
    cashTill[2] = registerDailyStartingCash[2, 1];
    cashTill[3] = registerDailyStartingCash[3, 1];
}

static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    int availableTwenties = cashTill[3] + twenties;
    int availableTens = cashTill[2] += tens;
    int availableFives = cashTill[1] += fives;
    int availableOnes = cashTill[0] += ones;
    bool tillDepleted = false;

    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
    int changeNeeded = amountPaid - cost;

    if (changeNeeded < 0)
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");

    if (!tillDepleted)
    {
        Console.WriteLine("Cashier Returns:");

        while ((changeNeeded > 19) && (availableTwenties > 0))
        {
            availableTwenties--;
            changeNeeded -= 20;
            Console.WriteLine("\t A twenty");
        }

        while ((changeNeeded > 9) && (availableTens > 0))
        {
            availableTens--;
            changeNeeded -= 10;
            Console.WriteLine("\t A ten");
        }

        while ((changeNeeded > 4) && (availableFives > 0))
        {
            availableFives--;
            changeNeeded -= 5;
            Console.WriteLine("\t A five");
        }

        while ((changeNeeded > 0) && (availableOnes > 0))
        {
            availableOnes--;
            changeNeeded -= 1;
            Console.WriteLine("\t A one");
        }

        if (changeNeeded > 0)
        {
            tillDepleted = true;
            throw new InvalidOperationException("InvalidOperationException: Insufficient funds available in till to complete this transaction.");
        }
    }

    // reset the cash till to ensure accuracy:
    cashTill[0] = availableOnes;
    cashTill[1] = availableFives;
    cashTill[2] = availableTens;
    cashTill[3] = availableTwenties;
}

static void LogTillStatus(int[] cashTill)
{
    Console.WriteLine("The till currently has:");
    Console.WriteLine($"{cashTill[3] * 20} in twenties");
    Console.WriteLine($"{cashTill[2] * 10} in tens");
    Console.WriteLine($"{cashTill[1] * 5} in fives");
    Console.WriteLine($"{cashTill[0]} in ones");
    Console.WriteLine();
}

static string TillAmountSummary(int[] cashTill)
{
    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

}
