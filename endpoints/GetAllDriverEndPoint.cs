using FastEndpoints;
using fleetsystem.repositories;
using fleetsystem.dtos;
using fleetsystem.entities;

public class GetAllDriversEndpoint : EndpointWithoutRequest<IEnumerable<DriverResponse>>
{
    private readonly DDriverRepository _repository;

    public GetAllDriversEndpoint(DDriverRepository repository)
    {
        _repository = repository;
    }

    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/api/drivers");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var drivers = await _repository.GetAllDriversAsync();
        await SendAsync(drivers.Select(d => new DriverResponse
        {
            Id = d.Id,
            Name = d.Name,
            License = d.License,
            Details = d.Details
        }));
    }
}