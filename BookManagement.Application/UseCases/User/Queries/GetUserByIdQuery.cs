using BookManagement.Application.Exceptions;
using BookManagement.Domain.DTOs;
using BookManagement.Domain.Interfaces;
using MediatR;

namespace BookManagement.Application.UseCases.User.Queries;

public abstract class GetUserById
{

    public sealed record GetUserByIdQuery(Guid UserId) : IRequest<GetUserDto>;

    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, GetUserDto>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GetUserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);

            if (user == null)
                throw new NotFoundException(["User not found."]);

            return new GetUserDto()
            {
                Name = user.Name,
                Email = user.Email,
            };
        }
    }
}