using DesignPatterns.DesignPattern.Interfaces;

namespace DesignPatterns.BuilderPattern.Directors;

public class Roofer
{
    private IHomeBuilder _builder = null!;
    public IHomeBuilder Builder
    {
        set => _builder = value;
    }
    public void BuildOnlyRoof()
    {
        _builder.BuildRoof();
    }

    public void HireRoofersFriendToBuildEverything()
    {
        _builder.BuildFoundation();
        _builder.BuildWalls();
        _builder.BuildRoof();
    }
}