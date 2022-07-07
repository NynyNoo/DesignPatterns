namespace DesignPatterns.AbstractFactoryMethod.Interfaces;

public interface IAnimalFactory
{
    IAmphibian CreateAmphibian();//plazy
    IReptile CreateReptile();
    IMamal CreateMamal();//ssaki
}