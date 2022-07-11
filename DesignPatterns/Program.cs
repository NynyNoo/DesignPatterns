// See https://aka.ms/new-console-template for more information

using DesignPatterns.AbstractFactoryMethod;
using DesignPatterns.BuilderPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FactoryMethod;
using DesignPatterns.MediatorPattern;

new Animals().MakeSomeAnimals();//factory
new AbstractFactoryAnimal().GenerateCorrectAnimal();//abstract factory
new BuilderPattern().BuildMeAHouse();//builder
new TreePrinter().PrintTree();//decorator
new CallPetAction().CallPetActions();//commands
new OrderFood().StartFoodOrderSystem();//mediator


