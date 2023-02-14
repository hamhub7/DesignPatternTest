using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Creational.Builder
{
    public enum VehicleFrame
    {
        StardardKart,
        PipeFrame,
        Mach8,
        SteelDriver,
        CatCruiser,
        CircuitSpecial,
        TriSpeeder,
        Badwagon,
        Prancer,
        Biddybuggy,
        Landship,
        Sneeker,
        SportsCoupe,
        GoldStandard,
        GLA,
        W25SilverArrow,
        SL300Roadster,
        BlueFalcon,
        TanookiKart,
        BDasher,
        Streetle,
        PWing,
        KoopaClown,
        StandardBike,
        TheDuke,
        FLameRider,
        Varmint,
        MrScooty,
        MasterCycleZero,
        CityTripper,
        Comet,
        SportBike,
        JetBike,
        YoshiBike,
        MasterCycle,
        StandardATV,
        WildWiggler,
        TeddyBuggy,
        BoneRattler,
        SplatBuggy,
        Inkstrider
    }

    public enum VehicleWheels
    {
        Standard,
        Monster,
        Roller,
        Slim,
        Slick,
        Metal,
        Button,
        OffRoad,
        Sponge,
        Wood,
        Cushion,
        BlueStandard,
        HotMonster,
        AzureRoller,
        CrimsonSlim,
        CyberSlick,
        RetroOffRoad,
        GoldTires,
        GLATires,
        TriforceTires,
        AncientTires,
        LeafTires
    }

    public enum VehicleGlider
    {
        SuperGlider,
        CloudGlider,
        WarioWing,
        WaddleWing,
        PeachParasol,
        Parachute,
        Parafoil,
        FlowerGlider,
        BowserKite,
        PlaneGlider,
        MKTVParafoil,
        GoldGlider,
        HylianKite,
        Paraglider,
        PaperGlider
    }

    public class Vehicle
    {
        public readonly VehicleFrame frame;
        public readonly VehicleWheels wheels;
        public readonly VehicleGlider glider;

        public Vehicle(VehicleFrame frame, VehicleWheels wheels, VehicleGlider glider)
        {
            this.frame = frame;
            this.wheels = wheels;
            this.glider = glider;
        }

        private Vehicle(Builder builder)
        {
            frame = builder.frame ?? throw new NullReferenceException("Frame must be provided");
            wheels = builder.wheels ?? throw new NullReferenceException("Wheels must be provided");
            glider = builder.glider ?? throw new NullReferenceException("Glider must be provided");
        }

        public class Builder
        {
            public VehicleFrame? frame;
            public VehicleWheels? wheels;
            public VehicleGlider? glider;

            public Builder()
            {
                frame = null;
                wheels = null;
                glider = null;
            }

            public Builder WithFrame(VehicleFrame frame)
            {
                this.frame = frame;
                return this;
            }

            public Builder WithWheels(VehicleWheels wheels)
            {
                this.wheels = wheels;
                return this;
            }

            public Builder WithGlider(VehicleGlider glider)
            {
                this.glider = glider;
                return this;
            }

            public Vehicle Build()
            {
                return new Vehicle(this);
            }
        }
    }
}
