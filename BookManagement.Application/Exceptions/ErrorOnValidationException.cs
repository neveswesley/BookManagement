namespace BookManagement.Application.Exceptions;

public class ErrorOnValidationException : BookManagementException
{
    public IList<string> ErrorMessages { get; set; }

    public ErrorOnValidationException(IList<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}