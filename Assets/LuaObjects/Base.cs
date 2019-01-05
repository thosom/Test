using System;
using MoonSharp.Interpreter;

namespace LuaObjects
{
    public class Base
    {
        
        private GamePieces.Base myBase;
        public Player currentPlayer;
        
        public Base(GamePieces.Base cp,Player currentPlayer)
        {
            myBase = cp;
            this.currentPlayer = currentPlayer;
        }

        
        
        
        public bool isMine()
        {
            return myBase.myPlayer == currentPlayer.myPlayer;
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