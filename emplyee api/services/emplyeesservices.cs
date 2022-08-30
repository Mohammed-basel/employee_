using emplyee_api.models;

namespace emplyee_api.services
{
    public class emplyeesservices : IEmplyee
    {
        static List<employee> employeeslist { get; }
        static int nextempid = 4;
        static emplyeesservices()
        {
            employeeslist = new List<employee>()
            {
                new employee {Id = 1,Name= "mohammed",Age = 22,CompanyID=1},
                new employee {Id = 2,Name= "omar",Age = 25,CompanyID=2},
                new employee {Id = 3,Name= "faisal",Age = 22,CompanyID=3},

            };
        }


        public async Task<List<employee>> Create(employee employees)
        {
            employeeslist.Add(employees);
            return (employeeslist);
        }

        public async Task<List<employee>> Delete(int id)
        {
            employee employee = employeeslist.First(x => x.Id == id);
            employeeslist.Remove(employee);
            return (employeeslist);
        }

        public async Task<employee> GetById(int id)
        {
            return (employeeslist.First(x => x.Id == id));
        }

        public async Task<List<employee>> GET()
        {
            return employeeslist;
        }



        public async Task<employee> Update( employee update)
        {
            ;
            employee employee = employeeslist.First(x => x.Id == update.Id);
            employee.Name = update.Name;
            employee.Name = update.Name;
            return (employee);
        }
    }
}

