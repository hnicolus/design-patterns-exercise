using System;
using System.Data;
using System.Threading;
using Patterns.Adapter;
using Patterns.Bridge;
using Patterns.ChainOfResponsibility.accountingApplication;
using Patterns.ChainOfResponsibility.WebServerExample;
using Patterns.Composite;
using Patterns.Composite.Exercise;
using Patterns.Facade.Exercise;
using Patterns.FlyWeight;
using Patterns.FlyWeight.spreadsheetApplication;
using Patterns.Iterator.Browser;
using Patterns.Iterator.Products;
using Patterns.Mediator;
using Patterns.Mediator.Chat;
using Patterns.Mediator.GUI.UIFramework;
using Patterns.Memento.WordEditor;
using Patterns.Observer;
using Patterns.Observer.FirstWay;
using Patterns.Prototype;
using Patterns.Singleton.ConfigManager;
using Patterns.State.Traveler;
using Patterns.StrategyPattern;
using Patterns.Template;
using Patterns.Visitor;

namespace Patterns
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
            //MediatorPattern();
            //ChainOfResponsibility();
            //ChainOfResponsibiltyExcercise();
            //VisitorPattern();
            //CompositeProgram.Run();
            // ChatProgram.Run();
            // FireFighterProgram.Run();
            //MediatorPatternChatRoom();
            //EmailProgram.Run();
            //TwitterProgram.Run();

            //MapProgram.Run();

            //SpreadSheetProgram.Run();

            // DeviceRemoteProgram.Run();
            
            //Prototype Pattern Version
            //VideoEditorProgram.Run();
            SingletonAppProgram.Run();
        }

        private static void VisitorPattern()
        {
            var document = new HtmlDocument();
            document.AddNode(new HeadingNode());
            document.AddNode(new AnchorNode());

            document.HighLight();
        }

        private static void ChainOfResponsibiltyExcercise()
        {
            // ExcelHandler => SpreadSheetHandler => QuickBookHandler => FallBackHandler
            var defaultHandler = new FallBackHandler(null);
            var quickBook = new QuickBookHandler(defaultHandler);
            var spreadSheet = new SpreadSheetHandler(quickBook);
            var excel = new ExcelHandler(spreadSheet);


            var datareader = new DataReader(excel);
            datareader.Read("options.");
        }

        private static void ChainOfResponsibility()
        {
            var compressor = new Compressor(null);

            var logger = new Logger(compressor);
            var auth = new Authenticator(logger);

            var webServer = new WebServer(auth);

            var request = new HttpRequest()
            {
                Username = "admin",
                Password = "123qwE*"
            };


            webServer.Handle(request);
        }

        private static void MediatorPattern()
        {
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

            homeWindow.Close();

        }

        private static void StrategyPattern()
        {
            var ChatClient = new ChatClient(new DESEncryption());
            ChatClient.Send("Hello ");

            ChatClient.Encryption = new AESEncryption();
            ChatClient.Send("Hello ");
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
            BrowserProgram.Run();
        }

        private static void StatePattern()
        {
            var directionService = new DirectionService();
            directionService.TravelMode = new DrivingMode();

            directionService.GetEta();
            directionService.GetDirection();

            directionService.TravelMode = new TransitMode();
            directionService.GetEta();
            directionService.GetDirection();

            directionService.TravelMode = new BicycleMode();
            directionService.GetEta();
            directionService.GetDirection();

            directionService.TravelMode = new WalkingMode();
            directionService.GetEta();
            directionService.GetDirection();
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
