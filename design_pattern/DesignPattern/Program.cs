using DesignPattern.AbstractFactoryPattern;
using DesignPattern.AdapterPattern;
using DesignPattern.BuilderPattern;
using DesignPattern.DependencyInversionPrinciple;
using DesignPattern.FactoryPattern;
using DesignPattern.IteratorPattern;
using DesignPattern.ObserverPattern;
using DesignPattern.StatePattern;
using DesignPattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
	public class Program
	{
		//Main Method
		static void Main(string[] args)
		{
            //String input = null;
            //Console.WriteLine("Enter object name...");
            //input = Console.ReadLine();

            //IVehicle Type = VehicleFactory.GetVehicle(input);
            //Console.WriteLine("VehicleType" + Type.VehicleType());
            //Console.WriteLine("Vehicle Wheels" + Type.NumberOfWheels());
            //Console.ReadLine();

            //IAnimal animal = null;
            //AnimalFactory animalFactory = null;
            //string speakSound = null;
            //animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            //animal = animalFactory.GetAnimal("Octopus");
            //speakSound = animal.speak();
            //Console.WriteLine(speakSound);
            //Console.ReadLine();

            //var toyACreator = new ToyCreator(new ToyABuilder());
            //toyACreator.CreateToy();
            //Toy a = toyACreator.GetToy();
            //Console.WriteLine(a.Head + a.Body + a.Model + a.Limbs + a.Legs);
            //var toyBCreator = new ToyCreator(new ToyBBuilder());
            //toyBCreator.CreateToy();
            //Toy b = toyBCreator.GetToy();
            //Console.WriteLine(b.Head + b.Body + b.Model + b.Limbs + b.Legs);
            //Console.ReadLine();

            //Console.WriteLine("Hello!, Please select the mode of transport to get the travel time between source and destination: \nCar \nBike");
            //var userStrategy = Console.ReadLine().ToLower();
            //Console.WriteLine("\nUser has selected *" + userStrategy + "* as mode of transport\n");
            //Console.WriteLine("\n*****************************************************************************************************\n");
            //switch (userStrategy)
            //{
            //	case "car":
            //		new TravelStrategy(new CarStrategy()).GetTravelTime("Point A", "Point B");
            //		break;
            //	case "bike":
            //		new TravelStrategy(new BikeStrategy()).GetTravelTime("Point A", "Point B");
            //		break;
            //	default:
            //		Console.WriteLine("You have chosen an invalid mode of transport.");
            //		break;
            //}
            //Console.ReadLine();

            //ATMMachine atmMachine = new ATMMachine();
            //Console.WriteLine("ATM Machine Current state : "
            //				+ atmMachine.atmMachineState.GetType().Name);
            //Console.WriteLine();
            //atmMachine.EnterPin();
            //atmMachine.WithdrawMoney();
            //atmMachine.EjectDebitCard();
            //atmMachine.InsertDebitCard();
            //Console.WriteLine();
            //// Debit Card has been inserted so internal state of ATM Machine
            //// has been changed to DebitCardInsertedState
            //Console.WriteLine("ATM Machine Current state : "
            //				+ atmMachine.atmMachineState.GetType().Name);
            //Console.WriteLine();
            //atmMachine.EnterPin();
            //atmMachine.WithdrawMoney();
            //atmMachine.InsertDebitCard();
            //atmMachine.EjectDebitCard();
            //Console.WriteLine("");
            //// Debit Card has been ejected so internal state of ATM Machine
            //// has been changed to DebitCardNotInsertedState
            //Console.WriteLine("ATM Machine Current state : "
            //				+ atmMachine.atmMachineState.GetType().Name);
            //Console.ReadLine();

            ////Create a Product with Out Of Stock Status
            //Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            ////User Anurag will be created and user1 object will be registered to the subject
            //Observer user1 = new Observer("Anurag", RedMI);
            ////User Pranaya will be created and user1 object will be registered to the subject
            //Observer user2 = new Observer("Pranaya", RedMI);
            ////User Priyanka will be created and user3 object will be registered to the subject
            //Observer user3 = new Observer("Priyanka", RedMI);

            //Observer temp = new Observer("Pratham");
            //RedMI.RegisterObserver(temp);

            //RedMI.RemoveObserver(temp);

            //Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            //Console.WriteLine();
            //// Now product is available
            //RedMI.setAvailability("Available");
            //Console.Read();

            //WorkerBusinessLogic workerBusinessLogic = new WorkerBusinessLogic();
            //Worker wor = workerBusinessLogic.GetWorkerDetails(1001);
            //Console.WriteLine($"ID: {wor.ID}, Name: {wor.Name}, Department: {wor.Department}, Salary: {wor.Salary}");
            //Console.ReadKey();

            //Console.Read();

            //ConcreteCollection collection = new ConcreteCollection();
            //collection.AddEmployee(new Employee("Anurag", 100));
            //collection.AddEmployee(new Employee("Pranaya", 101));
            //collection.AddEmployee(new Employee("Santosh", 102));
            //collection.AddEmployee(new Employee("Priyanka", 103));
            //collection.AddEmployee(new Employee("Abinash", 104));
            //collection.AddEmployee(new Employee("Preety", 105));

            //// Create iterator
            //Iterator iterator = collection.CreateIterator();
            ////looping iterator      
            //Console.WriteLine("Iterating over collection:");

            //for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            //{
            //	Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            //}
            //Console.Read();

            //// Non-adapted chemical compound
            //using (Compound unknown = new Compound())
            //{
            //    unknown.Display();
            //    // Adapted chemical compounds
            //    Compound water = new RichCompound("Water");
            //    water.Display();
            //    Compound benzene = new RichCompound("Benzene");
            //    benzene.Display();
            //    Compound ethanol = new RichCompound("Ethanol");
            //    ethanol.Display();
            //    // Wait for user
            //}
            //Console.ReadKey();
        }
	}
}

	

