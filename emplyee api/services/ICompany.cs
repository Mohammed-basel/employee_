using emplyee_api.models;

namespace emplyee_api.services
{
    public interface ICompany
    {
        Task<List<company>> GET();
        Task<company> GetById(int id);
        Task<List<company>> Create(company company);
        Task<company> Update(company company);
        Task<List<company>> Delete(int id);
    }
}
