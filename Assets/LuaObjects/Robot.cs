using System;
using System.Collections.Generic;
using GamePieces;
using MoonSharp.Interpreter;

namespace LuaObjects
{
    [MoonSharpUserData]
    public class LuaRobot
    {
        public Robot myRobot;
        public Player currentPlayer;

        public LuaRobot(Robot myRobot, Player currentPlayer)
        {
            this.myRobot = myRobot;
            this.currentPlayer = currentPlayer;
        }


        public bool isMine()
        {
            return myRobot.myPlayer == currentPlayer.myPlayer;
        }

        public bool isEnemy()
        {
            return !isMine();
        }
        
        
        
        
        
        
        
        
        public bool move(int x, int y)
        {
            throw new NotImplementedException();
        }
        
        public List<object> getTargets()
        {
            throw new NotImplementedException();
        }

        public bool attack(EnemyRobot enemy)
        {
            throw new NotImplementedException();
        }

        public bool attack(CapturePoint enemyPoint)
        {
            throw new NotImplementedException();
        }

        public bool attack(Base enemyBase)
        {
            throw new NotImplementedException();
        }

        public int range()
        {
            throw new NotImplementedException();
        }

        public int attackRange()
        {
            throw new NotImplementedException();
        }
        
        public object closestTarget()
        {
            throw new NotImplementedException();
        }

        public int movesLeft()
        {
            throw new NotImplementedException();
        }

        public int health()
        {
            throw new NotImplementedException();
        }

        public DynValue position()
        {
            int x, y;
            throw new NotImplementedException();
            return DynValue.NewTuple(DynValue.NewNumber(x),DynValue.NewNumber(y));
        }

        public int id()
        {
            throw new NotImplementedException();
        }
        
        
    }
}











