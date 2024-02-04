using CleanArchitecture.Application.Features.CustomerFeatures.Commands.CreateCustomer;
using CleanArchitecture.Application.Features.CustomerFeatures.Contracts;
using CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetAllCustomers;
using CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetCustomerBySearchParam;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("Customer")]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<CustomerResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllCustomersRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet("Search")]
    public async Task<ActionResult<CustomerResponse>> GetByEmail([FromQuery] GetCustomerBySearchParamRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CustomerResponse>> Create(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}