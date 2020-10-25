using BillyJoeAwesomeLibrary.Repository.Interface;
using BillyJoeAwesomeLibrary.Service.Interface;

namespace BillyJoeAwesomeLibrary.Service
{
    public class MusicaService : IMusicaService
    {
        private readonly IMusicaRepository _musicaRepository;
        public MusicaService(IMusicaRepository musicaRepository)
        {
            _musicaRepository = musicaRepository;
        }
    }
}
