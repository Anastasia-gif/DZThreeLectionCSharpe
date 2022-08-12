// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Enter a five-digit: ");
 
string number = Console.ReadLine();

if(number.Length == 5){
for(int i = 0; i < number.Length/2; i++){
    if(number[i]!=number[number.Length-1-i]){
        System.Console.WriteLine("It is not polydrome");
        return;
    };
}
System.Console.WriteLine("It is polydrome");
}else{
    System.Console.WriteLine("we only check five-digit numbers");
}

