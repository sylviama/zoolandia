using System;

namespace Zoolandia.Species
{
    interface IFire
    {
        int level();
        string skillName();

    }

    interface IRainner
    {
        int level();
        int CP();
    }
}