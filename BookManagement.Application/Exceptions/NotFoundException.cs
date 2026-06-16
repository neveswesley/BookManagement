namespace BookManagement.Application.Exceptions;

public class NotFoundException : BookManagementException
{
    public IList<string> ErrorMessages { get; set; }

    public NotFoundException(IList<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}