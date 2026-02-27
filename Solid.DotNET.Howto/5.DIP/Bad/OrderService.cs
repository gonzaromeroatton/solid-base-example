namespace Solid.DotNET.Howto._5.DIP.Bad;

public sealed class OrderService
{
    private readonly SqlLogger _logger = new SqlLogger();
}
