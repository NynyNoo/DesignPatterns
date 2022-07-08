// See https://aka.ms/new-console-template for more information

using DesignPatterns.AbstractFactoryMethod;
using DesignPatterns.BuilderPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FactoryMethod;

new Animals().MakeSomeAnimals();
new AbstractFactoryAnimal().GenerateCorrectAnimal();
new BuilderPattern().BuildMeAHouse();
new TreePrinter().PrintTree();
new CallPetAction().CallPetActions();


