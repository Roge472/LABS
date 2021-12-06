using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftLab.OriginalBear
{
    public abstract class OriginalBear
    {
        public int GetSpeed()
        {
            string bearName = this.GetType().Name.Split('.').Last();
            switch (bearName)
            {
                case "Grizzly":
                    {
                        return 15;
                    }
                case "PolarBear":
                    {
                        return 10;
                    }
                case "Panda":
                    {
                        return 7;
                    }
                default:
                    return 0;
            }
        }
    }

    public class Grizzly : OriginalBear
    {
    }

    public class PolarBear : OriginalBear
    {
    }

    public class Panda : OriginalBear
    {
    }
}
