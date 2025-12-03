using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOs;
using Project.BLL.Managers.Abstracts;
using Project.BLL.Managers.Concretes;
using Project.WebApi.Models.RequestModels.Authors;
using Project.WebApi.Models.RequestModels.Categories;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorManager _authorManager;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorManager authorManager, IMapper mapper)
        {
            _authorManager = authorManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorsList()
        {
            List<AuthorDTO> values = await _authorManager.GetAllAsync();
            List<AuthorResponseModel> responseModel = _mapper.Map<List<AuthorResponseModel>>(values);
            return Ok(responseModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            AuthorDTO value = await _authorManager.GetByIdAsync(id);
            return Ok(_mapper.Map<AuthorResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorRequestModel model)
        {
            AuthorDTO author = _mapper.Map<AuthorDTO>(model);
            await _authorManager.CreateAsync(author);
            return Ok("Veri ekleme basarılıdır");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorRequestModel model)
        {
            AuthorDTO author = _mapper.Map<AuthorDTO>(model);
            await _authorManager.UpdateAsync(author);
            return Ok("Veri güncelleme basarılıdır");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PacifyAuthor(int id)
        {
            string mesaj = await _authorManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            string mesaj = await _authorManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
