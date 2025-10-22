//percabangan if-else
Console.WriteLine("Masukan nilai Matematika:");
int matematika = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Masukan nilai Sistem Oprasi:");
int so = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Masukan nilai Basis data:");
int basisdata = Convert.ToInt32(Console.ReadLine());
//menghitung rata-rata nilai
double rataRata = (matematika + so + basisdata) / 3.0;
string grade;
if (rataRata >= 90)
{
    grade = "A";
}
else if (rataRata >= 75)
{
    grade = "B";
}
else if (rataRata >= 55)
{
    grade = "C";
}
else if (rataRata >= 40)
{
    grade = "D";
}
else
{
    grade = "E";
}

Console.WriteLine("\nHasil :");
Console.WriteLine("Matematika : " + matematika);
Console.WriteLine("Sistem Operasi : " + so);
Console.WriteLine("Basis Data : " + basisdata);
Console.WriteLine("\nRata-rata : " + rataRata);

// Console.WriteLine("Grade : " + grade);

int total = 0;
for (int i = 1; i <= 10; i++)
{
    total += i;
}
Console.WriteLine("Total dari 1 sampai 10 adalah: " + total);

// diskon   
Console.Write("Masukkan total belanja: ");
double total = Convert.ToDouble(Console.ReadLine());

double diskon = 0;

// Jika belanja lebih dari 100 ribu, dapat diskon 10%
if (total > 100000)
{
    diskon = total * 0.10;
}

double totalBayar = total - diskon;

Console.WriteLine("Diskon: Rp" + diskon);
Console.WriteLine("Total yang harus dibayar: Rp" + totalBayar);


// switch case
int hari = 5;
switch (hari)
{
    case 1:
        Console.WriteLine("Senin");
        break;
    case 2:
        Console.WriteLine("Selasa");
        break;
    case 3:
        Console.WriteLine("Rabu");
        break;
    case 4:
        Console.WriteLine("Kamis");
        break;
    case 5:
        Console.WriteLine("Jumat");
        break;
    case 6:
        Console.WriteLine("Sabtu");
        break;
    case 7:
        Console.WriteLine("Minggu");
        break;
    default:
        Console.WriteLine("Hari tidak valid");
        break;
}
