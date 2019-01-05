using System;
using Boo.Lang;
using LuaObjects;
using MoonSharp.Interpreter;
using Console = LuaObjects.InGameEditor.Console;

namespace GamePieces
{
    public class Player
    {
        public static readonly int ROBOTCOUNT = 3;
        private Script MyScript;
        private DynValue myFunction;

        
        
        public Player otherPlayer;


        public List<Robot> myRobots;
        public Base myBase;
        public List<CapturePoint> myCapturePoints;

        //TODO: remove this
        [Obsolete("Please use Player.NewPlayers instead")] 
        public static Player _new(string code)
        {
            return new Player(code);
        }
        
        
        private Player(string AIcode)
        {
            MyScript = new Script(CoreModules.Preset_HardSandbox);

            MyScript.Globals["game"] = new LuaObjects.Player(this);
            MyScript.Globals["console"] = new Console(LuaInterface.Console);
            
            
            
            myFunction = MyScript.LoadString(AIcode);
            
            myRobots = new List<Robot>();
            for (int i = 0; i < ROBOTCOUNT; i++){ myRobots.Push(new Robot(this));}
            
            myCapturePoints = new List<CapturePoint>();
            myCapturePoints.Push(new CapturePoint(this));
            
            myBase = new Base(this);
        }

        public static PlayerGroup NewPlayers(string Player1AI, string Player2AI)
        {
            var p1 = new Player(Player1AI);
            var p2 = new Player(Player2AI);

            p1.otherPlayer = p2;
            p2.otherPlayer = p1;
            
            return new PlayerGroup(p1,p2);

        }

        public DynValue createCoroutine()
        {
            var coroutine = MyScript.CreateCoroutine(myFunction);
            coroutine.Coroutine.AutoYieldCounter = 100;
            return coroutine;
        }
        
        
        







    }
    
    public struct PlayerGroup
    {
        public readonly Player p1;
        public readonly Player p2;

        public PlayerGroup(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }
    
    
    
}