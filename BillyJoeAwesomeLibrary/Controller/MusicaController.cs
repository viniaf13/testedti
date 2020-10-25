using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Service.Interface;

namespace BillyJoeAwesomeLibrary.Controller
{
    public class MusicaController : IMusicaController
    {
        private readonly IMusicaService _musicaService;
        public MusicaController(IMusicaService musicaService)
        {
            _musicaService = musicaService;
        }

    }
}
