using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание:
            Вам необходимо разработать консольное приложение на языке C#, которое имитирует работу пропускной системы предприятия. Пропускная система должна позволять регистрировать сотрудников, выдавать им пропуски, а также проверять валидность пропусков при попытке доступа.

            Требования:

            Создайте класс "Employee" (сотрудник) со следующими полями:

            Идентификатор сотрудника (EmployeeId)
            Фамилия (LastName)
            Имя (FirstName)
            Должность (Position)
            Логин (Login)
            Пароль (Password)
            Создайте интерфейс "IPass" (пропуск) с методами:

            Validate() - проверка валидности пропуска
            PrintInfo() - отображение информации о пропуске
            Создайте классы пропусков:

            TemporaryPass (временный пропуск) - должен иметь дату начала и окончания действия
            PermanentPass (постоянный пропуск) - не имеет ограничения по дате действия
            Создайте класс "PassSystem" (система пропусков) с методами:

            RegisterEmployee() - регистрация нового сотрудника
            IssuePass() - выдача пропуска сотруднику
            AccessControl() - проверка доступа сотрудника с помощью пропуска
            PrintEmployeeList() - отображение списка зарегистрированных сотрудников
            Используйте делегаты и события для логирования важных событий системы, например, успешной регистрации сотрудника или проверке доступа.

            Используйте LINQ для выполнения следующих запросов:

            Получение списка сотрудников с постоянным пропуском.
            Получение списка сотрудников с временным пропуском, чье действие истекает сегодня.
            Используйте Generics для возможности работы с разными типами пропусков.

            Примечание:

            Для упрощения примера, весь ввод/вывод можно осуществлять через консоль.
            Разрешается использовать любые сторонние библиотеки или фреймворки.*/
            Employee employee = new Employee(1, "Иванов", "Сергей", "Директор", "direk", "pasDirek");
            Employee employee1 = new Employee(1, "Сидоров", "Олег", "Заместитель", "zam", "pasZam");
            Employee employee2 = new Employee(1, "Соколов", "Николай", "Начальник отдела", "otd", "pasSokol");
            Employee employee3 = new Employee(1, "Петухова", "Светлана", "Главный бухгалтер", "buh", "pasPetuh");
            Employee employee4 = new Employee(1, "Тарасова", "Диана", "Программист", "prog1", "pasTaras");
            Employee employee5 = new Employee(1, "Максимова", "Маргарита", "Программист", "prog2", "pasMax");
            Employee employee6 = new Employee(1, "Конев", "Иван", "Программист", "prog3", "pasKonev");
            Employee employee7 = new Employee(1, "Козлов", "Максим", "Инженер", "ingen", "pasKozlov");
            Employee employee8 = new Employee(1, "Ежов", "Михаил", "Инженер", "ingen1", "pasEzhov");
            Employee employee9 = new Employee(1, "Еремин", "Виталий", "Рабочий", "prog6", "pasEremin");
            Employee employee10 = new Employee(1, "Медведев", "Пётр", "Рабочий", "prog7", "pasMedvedev");
            Employee employee11 = new Employee(1, "Быков", "Олег", "Рабочий", "prog8", "pasBikov");
            Employee employee12 = new Employee(1, "Ковалёв", "Андрей", "Рабочий", "rab8", "pasKovalev");
            Employee employee13 = new Employee(1, "Денисова", "Ирина", "Рабочий", "rab7", "pasDenis");
            Employee employee14 = new Employee(1, "Носков", "Игорь", "Рабочий", "rab6", "pasNoskov");
            Employee employee15 = new Employee(1, "Лебедев", "Дмитрий", "Рабочий", "rab5", "pasLebedev");
            Employee employee16 = new Employee(1, "Ларин", "Леонид", "Рабочий", "rab4", "pasLarin");
            Employee employee17 = new Employee(1, "Степанов", "Евгений", "Рабочий", "rab3", "pasStepanov");
            Employee employee18 = new Employee(1, "Семёнова", "Анна", "Бухгалтер", "buhg", "pasSemenov");
            Employee employee19 = new Employee(1, "Бобов", "Дмитрий", "Рабочий", "rab2", "pasBobov");

            PassSystem passSystem = new PassSystem();
            passSystem.RegisterEmployee(employee);
            passSystem.RegisterEmployee(employee1);
            passSystem.RegisterEmployee(employee2);
            passSystem.RegisterEmployee(employee3);
            passSystem.RegisterEmployee(employee4, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee5, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee6, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee7, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee8, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee9, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee10, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee11, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee12, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee13, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee14, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee15, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee16, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee17, new DateTime(2017, 7, 20), DateTime.Now);
            passSystem.RegisterEmployee(employee18, new DateTime(2017, 7, 20), new DateTime(2023, 11, 30));
            passSystem.RegisterEmployee(employee19, new DateTime(2017, 7, 20), new DateTime(2023, 11, 13));

            List<Employee> employees = passSystem.GetEmployeesWithTempNow();
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
            //passSystem.Print();
            //passSystem.AccessControl(employee);
            //passSystem.AccessControl(employee18);
        }
    }
}
