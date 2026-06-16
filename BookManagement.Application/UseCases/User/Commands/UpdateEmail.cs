using BookManagement.Application.Exceptions;
using BookManagement.Domain.Interfaces;
using MediatR;

namespace BookManagement.Application.UseCases.User.Commands;

public abstract class UpdateEmail
{
    public class UpdateEmailRequest : IRequest<Guid>
    {
        public string NewEmail { get; set; } = string.Empty;
    }

    public sealed record UpdateEmailCommand(Guid UserId, string NewEmail) : IRequest<Guid>;
    
    public class UpdateEmailHandler : IRequestHandler<UpdateEmailCommand, Guid>
    {
        
        private readonly IUserRepository _userRepository;

        public UpdateEmailHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(UpdateEmailCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
                throw new NotFoundException(["User not found."]);
            
            user.UpdateEmail(request.NewEmail);
            await _userRepository.UpdateAsync(user);
            return user.Id;
        }
    }
}