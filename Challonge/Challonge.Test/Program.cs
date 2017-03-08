using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challonge.API;

namespace Challonge.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallongeService svc = new ChallongeService();
            svc.GetTournaments();
        }
    }
}
