using System.Collections.Generic;
using System.Threading.Tasks;
using Chambre_API.Model;

namespace Chambre_API.Repository
{
    public interface IChambreRepository
    {
        Task Add(Chambre chambre);  
        Task<Chambre> GetById(int id);  
        Task<List<Chambre>> GetAll();  

        Task Update(Chambre chambre); 
        Task Delete(int id);  
    }
}
