
string[] fradulentOrdersIds = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach(string id in fradulentOrdersIds)
{
    if(id.StartsWith("B"))
    {
        Console.WriteLine($" This Id Starts With B: {id}");
    }

    if(id.StartsWith("A"))
    {
        Console.WriteLine($" This Id Starts With A: {id}");
    }

    if(id.StartsWith("C"))
    {
        Console.WriteLine($" This Id Starts With C: {id}");
    }

    if(id.StartsWith("G"))
    {
        Console.WriteLine($" This Id Starts With G: {id}");
    }
}