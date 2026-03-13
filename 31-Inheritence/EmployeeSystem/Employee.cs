namespace EmployeeSystem {
    abstract internal class Employee {
        protected string _name;
        protected int _baseSalary;

        public Employee(string name, int baseSalary) {
            _name = name;
            _baseSalary = baseSalary;
        }

        public string GetName() {
            return _name;
        }

        public int GetBaseSalary() {
            return _baseSalary;
        }

        public virtual int CalculatePay() {
            return _baseSalary;
        }
        
        public abstract void PrintInfo();
    }
}
