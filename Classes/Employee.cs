namespace Classes{
    class EmployeeExcercise
    {
        public class Employee
    {
        //private fields pake _camelCase
        //private field - data internal dari object
        private string _name;
        private int _age;
        private readonly DateTime _hireDate; //
        private static int _totalEmployees = 0;
        private static int _totalWorkHours = 0;

        //bikin properti static public agar bisa diakses 
        public static int TotalEmployees => _totalEmployees;
        public static int TotalWorksHours => _totalWorkHours;

        //bikin contructor Employee untuk membuat new Employee
        //pake this untuk menghindari ambigu anatara parameter dan fields
        public Employee (string name, int age)
        {
            this._name = name ?? throw new ArgumentNullException(nameof(name));
            this._age = age;
            this._hireDate = DateTime.Now;//readonly field bisa di set di constructor

            //increment 1 employee setiap 1 object di buat
            _totalEmployees++;

            Console.WriteLine($"New employee hired {name} (Total employees : {_totalEmployees})");

        }

        //buat public propertie untuk menyediakn control akses pada private fields
        public string Name
        {
            get { return _name;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");    
                }
                _name = value;
            }
        }

        public int Age
        {
            get{ return _age;}
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException ("Age must be between 0 and 150");    
                }
                _age = value;
            }
        }

        //buat read-only property, tanpa setter dan hanya menampilkan readonly field
        public DateTime HireDate => _hireDate;
        

        //hitung property dari data lain
        public int YearOfService => DateTime.Now.Year - _hireDate.Year;
         
         //method dapat mengubah object state
         //method menambah umur employee dan menampilkan ucapan
         public void CelebrateBirthday()
        {
            _age++;
            Console.WriteLine($"  🎂 Happy birthday {_name}! Now {_age} years old.");
        }

        //
        public void Work()
        {
             int hoursWorked = 8; // Standard work day
            _totalWorkHours += hoursWorked;
            Console.WriteLine($"  💼 {_name} worked {hoursWorked} hours today");
        }

        public static void GetCompanyStats()
        {
            Console.WriteLine($"  📊 Company Stats:");
            Console.WriteLine($"      Total Employees: {_totalEmployees}");
            Console.WriteLine($"      Total Work Hours: {_totalWorkHours}");
            Console.WriteLine($"      Average Hours per Employee: {(_totalEmployees > 0 ? _totalWorkHours / _totalEmployees : 0)}");
        }

         public override string ToString()
        {
            return $"{_name} (Age: {_age}, Hired: {_hireDate:yyyy-MM-dd}, Service: {YearOfService} years)";
        }

          ~Employee()
        {
            _totalEmployees--;
            // Note: Don't write to Console in real finalizers - this is just for demo
            Console.WriteLine($"  💀 Employee {_name} record finalized");
        }
    }

    public static void EmployeeDemo()
        {
            var emp = new Employee("Sarah", 23);
            emp.Work();
            Employee.GetCompanyStats(); //panggil langsung dari class karena static belong to
            Console.WriteLine(emp);

            var emp2 = new Employee("Alice", 27);
            emp2.Work();
            Employee.GetCompanyStats(); //panggil langsung dari class karena static belong to
            Console.WriteLine(emp2);
        }

    }


}