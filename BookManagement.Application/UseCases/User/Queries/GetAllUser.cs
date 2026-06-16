using BookManagement.Domain.DTOs;
using BookManagement.Domain.Interfaces;
using MediatR;

namespace BookManagement.Application.UseCases.User.Queries;

public abstract class GetAllUser
{
    public sealed record GetAllUserQuery : IRequest<List<GetUserDto>>;

    public class GetAllUserQueryHandle : IRequestHandler<GetAllUserQuery, List<GetUserDto>>
    {
        
        private readonly IUserRepository _repository;

        public GetAllUserQueryHandle(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetUserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllAsync();

           return users.Select(u => new GetUserDto()
           {
               Name = u.Name,
               Email = u.Email,
               
           }).ToList();
        }
    }
}