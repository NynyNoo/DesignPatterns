// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;

AnimalFactory dogFactory=new DogFactory();
AnimalFactory birdFactory=new BirdFactory();
IAnimal doggo=dogFactory.CreateAnimal("Dogo");
IAnimal birdo=birdFactory.CreateAnimal("Birdo");

Console.Write("{0} can {1} {2} can {3}",doggo.GetName(),doggo.TravelStyle(),birdo.GetName(),birdo.TravelStyle());