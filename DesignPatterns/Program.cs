// See https://aka.ms/new-console-template for more information

using DesignPatterns.AbstractFactoryMethod;
using DesignPatterns.BuilderPattern;
using DesignPatterns.DesignPattern;
using DesignPatterns.DesignPattern.Builders;
using DesignPatterns.FactoryMethod;

new Animals().MakeSomeAnimals();
new AbstractFactoryAnimal().GenerateCorrectAnimal();
new BuilderPattern().BuildMeAHouse();