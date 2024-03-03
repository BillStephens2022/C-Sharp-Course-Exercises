using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1
{
    internal class M3 : BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model) {}

        public override void Repair()
        {
            base.Repair();
        }
    }
}
