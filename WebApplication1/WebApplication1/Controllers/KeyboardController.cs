using Microsoft.AspNetCore.Mvc;
using WebApplication1.BLL;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeyboardController : Controller
    {
        private IKeyboardService keyboardService;

        public KeyboardController(IKeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        [HttpGet]
        [Route("getList/")]
        public IEnumerable<KeyboardResponseDTO> GetList()
        {
            return this.keyboardService.GetKeyboardList();
        }

        [HttpGet]
        [Route("get/{id}")]
        public KeyboardResponseDTO Get(int id)
        {
            return this.keyboardService.GetKeyboard(id);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.keyboardService.DeleteKeyboard(id);
        }

        [HttpPost]
        public void Post([FromBody] KeyboardRequestDTO keyboardRequest)
        {
            this.keyboardService.PostKeyboard(keyboardRequest);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] KeyboardRequestDTO keyboardRequestDTO)
        {
            this.keyboardService.PutKeyboard(keyboardRequestDTO, id);
        }
    }
}
