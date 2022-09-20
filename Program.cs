Console.Write("Введи цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Совсем не то");
  }
  else Console.WriteLine("( не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);