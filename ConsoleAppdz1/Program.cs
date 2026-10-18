Console.Write("Введите вес (кг): ");
string weightInput = Console.ReadLine();
double weight = Convert.ToDouble(weightInput);

Console.Write("Введите рост (м): ");
string heightInput = Console.ReadLine();
double height = Convert.ToDouble(heightInput);

// Считаем и сохраняем в переменную с понятным названием
double rezultat = weight / (height * height);

Console.Write("Индекс массы тела: ");
Console.WriteLine(rezultat);

