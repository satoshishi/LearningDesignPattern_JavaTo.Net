using System.Collections;
using System.Collections.Generic;
using System;

namespace ProtoType.Sample1
{
    public class Company
    {
        private Dictionary<DateTime,HololiverBase> livers;

        public Company() => livers = new Dictionary<DateTime, HololiverBase>();

        public void Register(DateTime date,HololiverBase liver) => livers.Add(date,liver);

        public HololiverBase Create(DateTime date) => livers[date].Clone();

    }
}