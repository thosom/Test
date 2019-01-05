using GamePieces;
using MoonSharp.Interpreter;

namespace LuaObjects
{
    [MoonSharpUserData]
    public class Player
    {
        public GamePieces.Player myPlayer;
        public GamePieces.Player otherPlayer { get{
            return myPlayer.otherPlayer;
        }}
        public Player(GamePieces.Player me)
        {
            myPlayer = me;
        }
        
        public DynValue capturePoints(Script script)
        {
            DynValue list = DynValue.NewTable(script);

            foreach (var cp in myPlayer.myCapturePoints)
            {
                list.Table.Append(DynValue.FromObject(script,new CapturePoint(cp,this)));
            }
            foreach (var cp in myPlayer.myCapturePoints)
            {
                list.Table.Append(DynValue.FromObject(script,new CapturePoint(cp,this)));
            }
            return list;
        }

        public DynValue myRobots(Script script)
        {
            DynValue list = DynValue.NewTable(script);

            foreach (var robot in myPlayer.myRobots)
            {
                list.Table.Append(DynValue.FromObject(script,new LuaRobot(robot,this)));
            }
            return list;
        }
        
        public DynValue enemyRobots(Script script)
        {
            DynValue list = DynValue.NewTable(script);

            foreach (var robot in otherPlayer.myRobots)
            {
                list.Table.Append(DynValue.FromObject(script,new EnemyRobot(robot,this)));
            }
            return list;
        }

        public DynValue myBase(Script script)
        {
            return DynValue.FromObject(script, new Base(myPlayer.myBase, this));
        }

        public DynValue enemyBase(Script script)
        {
            return DynValue.FromObject(script, new Base(otherPlayer.myBase, this));
        }
        
        
        
        
        
        
        
        
    }
}