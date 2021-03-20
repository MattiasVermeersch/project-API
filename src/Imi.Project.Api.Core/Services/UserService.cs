using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepository = userRepo;
            _mapper = mapper;
        }
        public async Task<UserResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _userRepository.GetByIdAsync(id);

            var dto = _mapper.Map<UserResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<UserResponseDto>> ListAllAsync()
        {
            var result = await _userRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<UserResponseDto>>(result);
            return dto;
        }
    }
}
