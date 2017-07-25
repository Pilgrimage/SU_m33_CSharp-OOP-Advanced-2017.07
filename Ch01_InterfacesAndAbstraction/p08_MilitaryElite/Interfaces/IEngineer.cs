﻿namespace p08_MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        IList<IRepair> Repairs { get; }
    }
}