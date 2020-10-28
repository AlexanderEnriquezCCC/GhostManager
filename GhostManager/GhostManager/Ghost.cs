using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GhostManager
{
    public enum GhostState { Chasing, Evading, Roving, Dead} //only need 2 really, roving for movement and dead to change how ghost looks.
    class Ghost
    {
        GhostState gState;

        public GhostState State{
            get { return gState; }
            set
            {
                if(gState != value)
                {
                    this.Log(string.Format("{0} was: {1} now {2}", this.ToString(), gState, value));
                }
            }
        }

        public Ghost()
        {
            this.gState = GhostState.Roving;
        }

        public void Death()
        {
            this.gState = GhostState.Dead;
        }

        public virtual void Log(string s)
        {
            //nothing
            Console.WriteLine(s);
        }
    }
}
