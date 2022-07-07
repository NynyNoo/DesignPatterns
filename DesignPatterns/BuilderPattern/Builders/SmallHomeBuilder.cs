using DesignPatterns.DesignPattern.Interfaces;

namespace DesignPatterns.DesignPattern.Builders;

public class SmallHomeBuilder:IHomeBuilder
{
    private Product _product = new();

    public SmallHomeBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        _product = new();
    }
    public void BuildFoundation()
    {
        _product.Add("Foundation");
    }

    public void BuildWalls()
    {
        _product.Add("Walls");
    }

    public void BuildRoof()
    {
        _product.Add("Roof");
    }

    public Product GetProduct()
    {
        Product result = _product;
        Reset();
        return result;
    }
}