using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Contracts
{
    public interface ITarget
    {
        void TakeAttack(int attack);
        bool IsDead();

        int GiveExperience();
    }
}
