using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Structural.Adapter
{
    public interface IXbox
    {
        void PressA();
        void PressB();
        void PressX();
        void PressY();
    }

    public interface IPlaystation
    {
        void PressX();
        void PressCircle();
        void PressSquare();
        void PressTriangle();
    }

    public class XboxSeriesS : IXbox
    {
        public void PressA()
        {
            Console.WriteLine("A Pressed!");
        }

        public void PressB()
        {
            Console.WriteLine("B Pressed!");
        }

        public void PressX()
        {
            Console.WriteLine("X Pressed!");
        }

        public void PressY()
        {
            Console.WriteLine("Y Pressed!");
        }
    }

    public class PS5 : IPlaystation
    {
        public void PressX()
        {
            Console.WriteLine("X Pressed!");
        }

        public void PressCircle()
        {
            Console.WriteLine("Circle Pressed!");
        }

        public void PressSquare()
        {
            Console.WriteLine("Square Pressed!");
        }

        public void PressTriangle()
        {
            Console.WriteLine("Triangle Pressed!");
        }
    }

    public class XboxController
    {
        readonly IXbox console;

        public XboxController(IXbox console)
        {
            this.console = console;
        }

        public void PressA()
        {
            console.PressA();
        }

        public void PressB()
        {
            console.PressB();
        }

        public void PressX()
        {
            console.PressX();
        }

        public void PressY()
        {
            console.PressY();
        }

        public void PressAllButtons()
        {
            PressA();
            PressB();
            PressX();
            PressY();
        }
    }

    public class PlaystationController
    {
        readonly IPlaystation console;

        public PlaystationController(IPlaystation console)
        {
            this.console = console;
        }

        public void PressX()
        {
            console.PressX();
        }

        public void PressCircle()
        {
            console.PressCircle();
        }

        public void PressSquare()
        {
            console.PressSquare();
        }

        public void PressTriangle()
        {
            console.PressTriangle();
        }

        public void PressAllButtons()
        {
            PressX();
            PressCircle();
            PressSquare();
            PressTriangle();
        }
    }

    public class PlaystationToXboxControllerAdapter : IXbox
    {
        readonly IPlaystation console;

        public PlaystationToXboxControllerAdapter(IPlaystation console)
        {
            this.console = console;
        }

        public void PressA()
        {
            console.PressX();
        }

        public void PressB()
        {
            console.PressCircle();
        }

        public void PressX()
        {
            console.PressSquare();
        }

        public void PressY()
        {
            console.PressTriangle();
        }
    }

    public class XboxToPlaystationControllerAdapter : IPlaystation
    {
        readonly IXbox console;

        public XboxToPlaystationControllerAdapter(IXbox console)
        {
            this.console = console;
        }

        public void PressX()
        {
            console.PressA();
        }

        public void PressCircle()
        {
            console.PressB();
        }

        public void PressSquare()
        {
            console.PressX();
        }

        public void PressTriangle()
        {
            console.PressY();
        }
    }
}
