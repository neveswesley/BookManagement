using System.Net;
using BookManagement.Application.Exceptions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookManagemant.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case ErrorOnValidationException validationException:
                HandleErrorOnValidation(context, validationException);
                break;
            
            case NotFoundException notFoundException:
                HandleNotFoundException(context, notFoundException);
                break;

            default:
                HandleUnknownException(context);
                break;
        }
    }

    private void HandleErrorOnValidation(ExceptionContext context, ErrorOnValidationException ex)
    {
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
        context.Result = new BadRequestObjectResult(new ResponseErrors(ex.Message));
    }

    private void HandleNotFoundException(ExceptionContext context, NotFoundException ex)
    {
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
        context.Result = new NotFoundObjectResult(new ResponseErrors(ex.Message));
    }

    private void HandleUnknownException(ExceptionContext context)
    {
        var exception = context.Exception;

        context.HttpContext.Response.StatusCode =
            (int)HttpStatusCode.InternalServerError;

        context.Result = new ObjectResult(new
        {
            message = exception.Message,
            exception = exception.GetType().Name,
            stackTrace = exception.StackTrace
        });

        context.ExceptionHandled = true;
    }
}