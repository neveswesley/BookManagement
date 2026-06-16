using BookManagement.Application.Exceptions;
using BookManagement.Domain.Interfaces;
using MediatR;

namespace BookManagement.Application.UseCases.User.Commands;

public abstract class UpdateName
{
    public class UpdateNameRequest : IRequest<UpdateNameRequest>
    {
        public string NewName { get; set; } = string.Empty;
    }
    
    public sealed record UpdateNameCommand(Guid UserId, string NewName) : IRequest<Guid>;

    public class UpdateUserHandle : IRequestHandler<UpdateNameCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserHandle(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(UpdateNameCommand command, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(command.UserId);
            if (user == null)
                throw new NotFoundException(["User not found."]);
            
            user.UpdateName(command.NewName);
            await _userRepository.UpdateAsync(user);
            
            return user.Id;
        }
    }
}