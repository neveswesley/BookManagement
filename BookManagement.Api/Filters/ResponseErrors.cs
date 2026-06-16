namespace BookManagemant.Filters;

public class ResponseErrors
{
    private IList<string> Errors { get; set; }

    public ResponseErrors(IList<string> errors)
    {
        Errors = errors;
    }

    public ResponseErrors(string error)
    {
        Errors = new List<string>();
        Errors.Add(error);
    }
}