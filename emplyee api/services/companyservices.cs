using emplyee_api.models;

namespace emplyee_api.services
{
    public class companyservices : ICompany
    {
        static List<company> companylist { get; }
        static int nextempid = 4;
        static companyservices()
        {
            companylist = new List<company>()
            {
                new company {Id = 1,Name= "mohammed", location= "ramallah"},
                new company {Id = 2,Name= "omar", location= "tulkarm "},
                new company {Id = 3,Name= "faisal", location= "nablus "},
            };
        }


        public async Task<List<company>> Create(company company)
        {
            companylist.Add(company);
            return (companylist);
        }

        public async Task<List<company>> Delete(int id)
        {
            company company = companylist.First(x => x.Id == id);
            companylist.Remove(company);
            return (companylist);
        }

        public async Task<company> GetById(int id)
        {
            return (companylist.First(x => x.Id == id));
        }

        public async Task<List<company>> GET()
        {
            return companylist;
        }



        public async Task<company> Update( company update)
        {
            ;
            company company = companylist.First(x => x.Id == update.Id);
            company.Name = update.Name;
            company.Name = update.Name;
            return (company);
        }
    }
}

