namespace Solid.DotNET.Howto._4.ISP.Bad;

public sealed class Robot : IWorker
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
