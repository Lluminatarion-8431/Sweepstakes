using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    public interface IAccount
    {
        void Register(IMessage message);
        void Unregister(IMessage message);
        void Notify();
    }
}
