using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;
namespace ClienteWeb.ProfilesAutomapper
{
    public class PerfilCursos : Profile
    {
        public PerfilCursos()
        {
            CreateMap<Curso, CursoDto>();
            CreateMap<CursoDto, Curso>();

        }
    }
}
