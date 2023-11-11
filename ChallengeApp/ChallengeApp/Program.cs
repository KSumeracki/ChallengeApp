string name = "Krzysiek";
var age = 36;
string gender = "male";



if(gender =="famale" && age < 30)
{

    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if(name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if(gender == "male" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("Nie zgodnosc torsamosci");
}