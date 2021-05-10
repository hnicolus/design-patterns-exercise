using System.Threading;
using System.Data;
using System;
using DesignWithMosh.Iterator.Browser;
using DesignWithMosh.Iterator.Products;
using DesignWithMosh.Memento.WordEditor;
using DesignWithMosh.State.Traveler;
using DesignWithMosh.StrategyPattern;
using DesignWithMosh.Template;
using DesignWithMosh.Observer;
using DesignWithMosh.Observer.FirstWay;
using DesignWithMosh.Mediator;

namespace DesignWithMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            // MementoPatternProgram();
            // StatePattern();
            //IteratorPattern();
            //IteratorPatternExercise();
            //StrategyPattern();
            //TemplatePattern();
            //ObserverPattern();

            var signUpDIalogBox = new SignUpDialogBox();

            signUpDIalogBox.SimulateInteraction();
            Console.ReadKey();

        }

        private static void ObserverPattern()
        {
            var weatherSource = new WeatherDataSource();

            var tempDisplay = new TemperatureDisplay();
            var dueDisplay = new DuePointDisplay();

            weatherSource.AddObserver(tempDisplay);
            weatherSource.AddObserver(dueDisplay);

            weatherSource.DuePoint = 12.56f;
            Thread.Sleep(1000);
            weatherSource.Temperature = 60.00f;
            Thread.Sleep(1000);
            weatherSource.DuePoint = 14.56f;
            Thread.Sleep(1000);
            weatherSource.Temperature = 63.00f;
        }

        private static void TemplatePattern()
        {
            var homeWindow = new HomeWindow();

            homeWindow.close();

        }

        private static void StrategyPattern()
        {
            var ChatClient = new ChatClient(new DESEncryption());
            ChatClient.send("Hello ");

            ChatClient.Encryption = new AESEncryption();
            ChatClient.send("Hello ");
        }

        private static void IteratorPatternExercise()
        {
            var collection = new ProductCollection();
            collection.Add(new Product(1, "Cup"));
            collection.Add(new Product(2, "Rice"));
            collection.Add(new Product(3, "Glass"));
            collection.Add(new Product(4, "Meat"));

            var iterator = collection.CreateIterator();
            while (iterator.HasNext())
            {
                System.Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }

        private static void IteratorPattern()
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Push("https://www.nicksoftware.co.za");
            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.github.com/hnicolus");

            var iterator = browserHistory.CreateIterator();

            while (iterator.HasNext())
            {
                var current = iterator.Current();
                System.Console.WriteLine(current);
                iterator.Next();
            }
        }

        private static void StatePattern()
        {
            var directionService = new DirectionService();
            directionService.TravelMode = new DrivingMode();

            directionService.getEta();
            directionService.getDirection();

            directionService.TravelMode = new TransitMode();
            directionService.getEta();
            directionService.getDirection();

            directionService.TravelMode = new BicycleMode();
            directionService.getEta();
            directionService.getDirection();

            directionService.TravelMode = new WalkingMode();
            directionService.getEta();
            directionService.getDirection();
        }

        private static void MementoPatternProgram()
        {
            var editor = new Document();

            var history = new History();

            editor.Content = "First Text to be added";
            history.Push(editor.CreateState());

            editor.Content = "Second Text";
            history.Push(editor.CreateState());

            editor.Content = "Third Text";

            System.Console.WriteLine(editor.Content);

        }
    }
}
