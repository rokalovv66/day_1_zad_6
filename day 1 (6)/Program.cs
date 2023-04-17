int n = 18; // здесь можно изменить число заданий

string description;
if (n % 10 == 1 && n != 11)
{
    description = $"{n} учебное задание";
}
else if (n % 10 >= 2 && n % 10 <= 4 && (n < 10 || n > 20))
{
    description = $"{n} учебных задания";
}
else
{
    description = $"{n} учебных заданий";
}

Console.WriteLine(description);
