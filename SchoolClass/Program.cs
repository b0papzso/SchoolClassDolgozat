using SchoolClass;

SchoolDirector vilmos = new SchoolDirector
{
    DirectorName = "Vezető Vilmos",
    AppointedDate = new DateTime(2010, 10, 10),
    TeachedYears = 22,
    MonthlyPay = 250000
};

SchoolDirector ida = new SchoolDirector
{
    DirectorName = "Irányító Ida",
    AppointedDate = new DateTime(2011, 11, 11),
    TeachedYears = 11,
    MonthlyPay = 260000
};

Console.WriteLine(vilmos);
Console.WriteLine(ida);
Console.WriteLine(vilmos.WhoTeachedMore(ida));

SchoolDirectorRepo repo = new();
int pay = 0;
int count = 0;
foreach(var directors in repo.SchoolDirectors)
{
    pay += directors.MonthlyPay;
    count++;
}
Console.WriteLine($"Az igazgatók havi fizetésének átlaga: {pay/count}");