using Task03;

Course course1 = new Course();
course1.name = "Международное атомное право";
course1.lecturer = "Моисеева О.А.";
course1.online = true;
course1.language = "en";
course1.duration = 15;



Course course2 = new Course();
course2.name = "Алгоритмизация и языки программирования";
course2.lecturer = "Андриенко Ю.А.";
course2.online = true;
course2.language = "ru";
course2.duration = 30;


Course course3 = new Course();
course3.name = "Технологии системной инженерии";
course3.lecturer = "Королев А.С.";
course3.online = true;
course3.language = "ru";
course3.duration = 30;



Course course4 = new Course();
course4.name = "Сквозные цифровые инженерные технологии искусственных систем";
course4.lecturer = "Жабицкий М.Г.";
course4.online = false;
course4.language = "ru";
course4.duration = 45;



Course course5 = new Course();
course5.name = "Управление операционной деятельностью выскотехнологичного производства";
course5.lecturer = "Бойко О.В.";
course5.online = true;
course5.language = "ru";
course5.duration = 15;


Course[] hes_courses = { course1, course2, course3, course4, course5 };
Console.WriteLine("Добрый день, вам доступно " + hes_courses.Length + " " + "предметов:");
for (int i = 0; i < hes_courses.Length; i++)
{
    Console.WriteLine((i+1) + ". " + hes_courses[i].name);
    Console.WriteLine("Продолжительность: " + hes_courses[i].duration + " часов.");
    Console.WriteLine("Преподаватель: " + hes_courses[i].lecturer);
    Console.WriteLine("Язык курса: " + hes_courses[i].language + ".");
    Console.WriteLine("Формат занятий: " + hes_courses[i].online + ".");
    Console.WriteLine(" ");
}


