using MoonSharp.Interpreter

namespace LuaObjects
{
    [MoonSharpUserData]
    public class LuaRobot : Target
    {
        public bool move(int x, int y)
        {
            throw new NotImplementedException();
        }
        
        public List<System.object> getTargets()
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
        
        public System.object closestTarget()
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

        public List<int> position()
        {
            throw new NotImplementedException();
        }

        public int id()
        {
            throw new NotImplementedException();
        }
        
        
    }
}