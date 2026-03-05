
// Класс StreamReader; через конструктор создаётся объект (экземпляр класса) reader и передаем в поле path путь до файла
// StreamReader наследуется от TextReader и реализует интрфейс IDisposable.
StreamReader reader = new StreamReader("c:\\tmp\\names.txt"); 


int counter = 1; // В данной строчке создаем счетчик
// reader.EndOfStream — СВОЙСТВО объекта reader (свойство = аксессоры get/set; тут используется get), применяя модификатор доступа public EndOfStream
while (!reader.EndOfStream) {
    // ReadLine — метод класса StreamReader (фактически переопределённый из базового TextReader).
    // Возвращает объект класса string; ссылка на этот объект сохраняется в переменной line.
    string line = reader.ReadLine(); 

    // Console — класс; WriteLine — (статический) метод.
    // Здесь выбирается конкретная ПЕРЕГРУЗКА WriteLine, которая принимает строку.
    Console.WriteLine(counter + ". " + line);
    counter += 1;
}


// Close — метод объекта reader.
reader.Close();

// Класс StreamWriter; через конструктор создаётся объект writer.
// StreamWriter наследуется от TextWriter и реализует интрфейс IDisposable.

StreamWriter writer = new StreamWriter("c:\\tmp\\result.txt"); // В данной строчке создаем объект writer класса StreamWriter и передаем в поле path путь до файла
// WriteLine/Write — методы объекта writer.
// У WriteLine и Write есть перегрузки; здесь используются варианты, принимающие string.
writer.WriteLine("qwerty"); // Используем метод WriteLine класса StreamWriter
writer.Write("aaaaa"); // Используем метод Write класса StreamWriter
writer.WriteLine("bbbbbb"); // Используем метод WriteLine класса StreamWriter
writer.Close(); // Используем метод Close класса StreamWriter


