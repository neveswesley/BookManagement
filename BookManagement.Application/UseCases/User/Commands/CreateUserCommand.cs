using BookManagement.Domain.Interfaces;
using FluentValidation;
using MediatR;

namespace BookManagement.Application.UseCases.User.Commands;

public sealed record CreateUserCommand(string Name, string Email, string Password) : IRequest<Guid>;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid>
{
    
    private readonly IUserRepository _userRepository;

    public CreateUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new Domain.Entities.User(request.Name, request.Email, request.Password);
        await _userRepository.CreateAsync(user);

        return user.Id;
    }
}