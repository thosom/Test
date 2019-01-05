using System;
using System.Collections.Generic;
using GamePieces;
using MoonSharp.Interpreter;

namespace LuaObjects
{
    [MoonSharpUserData]
    public class EnemyRobot
    {
        public Robot myRobot;
        public Player currentPlayer;

        public EnemyRobot(Robot myRobot, Player currentPlayer)
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
        
        
        
        public DynValue position()
        {
            int x, y;
            throw new NotImplementedException();
            return DynValue.NewTuple(DynValue.NewNumber(x),DynValue.NewNumber(y));
        }

        public int health()
        {
            throw new NotImplementedException();
        }
    }
}