using System;
using System.Collections.Generic;
using MoonSharp.Interpreter;

namespace LuaObjects
{
    [MoonSharpUserData]
    public class CapturePoint
    {
        private GamePieces.CapturePoint myCP;
        public Player currentPlayer;
        
        public CapturePoint(GamePieces.CapturePoint cp,Player currentPlayer)
        {
            myCP = cp;
            this.currentPlayer = currentPlayer;
        }

        public bool isMine()
        {
            return this.currentPlayer.myPlayer == myCP.myPlayer;
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