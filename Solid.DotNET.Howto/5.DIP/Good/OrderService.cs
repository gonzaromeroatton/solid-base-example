namespace Solid.DotNET.Howto._5.DIP.Good;

public sealed class OrderService
{
    private readonly ILogger _logger;

    public OrderService(ILogger logger)
    {
        this._logger = logger;
    }
}
