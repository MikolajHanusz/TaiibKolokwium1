using WebApplication1.DTO;
using WebApplication1.Model;

namespace WebApplication1.BLL
{
    public class KeyboardService : IKeyboardService
    {
        private static List<Keyboard> keyboardList = new()
        {
            new Keyboard{Id = 1,Model = "adf", Type = KeyboardType.Membranowa },
            new Keyboard{Id = 2,Model = "adg", Type = KeyboardType.Mechaniczna },
            new Keyboard{Id = 3,Model = "adh", Type = KeyboardType.Optyczna },
            new Keyboard{Id = 4,Model = "adi", Type = KeyboardType.Nozycowa },
            new Keyboard{Id = 5,Model = "adj", Type = KeyboardType.Membranowa },
        };

        public KeyboardResponseDTO GetKeyboard(int id)
        {
            KeyboardResponseDTO res = ToKeyboardResponseDTO(keyboardList.Find(x => x.Id == id));
            return res;
        }
        public IEnumerable<KeyboardResponseDTO> GetKeyboardList()
        {
            foreach(Keyboard keyboard in keyboardList)
            {
                yield return ToKeyboardResponseDTO(keyboard);
            }
        }

        public void DeleteKeyboard(int id)
        {
            foreach (Keyboard k in keyboardList)
            {
                if (k.Id == id)
                {
                    keyboardList.Remove(k);
                    break;
                }
            }
        }

        public void PostKeyboard(KeyboardRequestDTO keyboardRequestDTO)
        {
            Keyboard k = new()
            {
                Id = keyboardList.Max(x => x.Id) + 1,
                Model = keyboardRequestDTO.Model,
                Type = keyboardRequestDTO.Type
            };
            keyboardList.Add(k);
        }

        public void PutKeyboard(KeyboardRequestDTO keyboardRequestDTO, int id)
        {
            Keyboard keyboard = keyboardList.Find(x=>x.Id == id);
            keyboard.Model = keyboardRequestDTO.Model;
            keyboard.Type = keyboardRequestDTO.Type;
        }

        KeyboardResponseDTO ToKeyboardResponseDTO(Keyboard keyboard)
        {
            return new KeyboardResponseDTO
            {
                Id = keyboard.Id,
                Model = keyboard.Model,
                Type = keyboard.Type
            };
        }

    }
}
