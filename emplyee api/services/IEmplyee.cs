using emplyee_api.models;

namespace emplyee_api.services
{
    public interface IEmplyee
    {
            Task<List<employee>> GET();
            Task<employee> GetById(int id);
            Task<List<employee>> Create(employee employee);
            Task<employee> Update(employee employee);
            Task<List<employee>> Delete(int id);

        }
    }