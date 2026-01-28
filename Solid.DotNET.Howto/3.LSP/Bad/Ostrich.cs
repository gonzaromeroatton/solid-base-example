namespace Solid.DotNET.Howto._3.LSP.Bad;

/// <summary>
/// 
/// </summary>
public class Ostrich : Bird
{
    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotSupportedException"></exception>
    public override void Fly()
    {
        throw new NotSupportedException("Ostriches can't fly.");
    }
}
