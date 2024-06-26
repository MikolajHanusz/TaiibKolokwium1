using WebApplication1.DTO;
using WebApplication1.Model;

namespace WebApplication1.BLL
{
    public interface IKeyboardService
    {
        KeyboardResponseDTO GetKeyboard(int id);
        IEnumerable<KeyboardResponseDTO> GetKeyboardList();
        void DeleteKeyboard(int id);
        void PostKeyboard(KeyboardRequestDTO keyboardRequestDTO);
        void PutKeyboard(KeyboardRequestDTO keyboardRequestDTO, int id);
    }
}
