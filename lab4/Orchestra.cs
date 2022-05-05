using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Orchestra
    {
        private List<MusicalInstrument> musicalInstrumentList = new List<MusicalInstrument>();

        public Orchestra()
        {
            musicalInstrumentList.Add(new PercussionInstrument(name: "Барабан"));
            musicalInstrumentList.Add(new PercussionInstrument(name: "Великий барабан"));
            musicalInstrumentList.Add(new StringInstrument(name: "Гітара", isTuned: false, stringCount: 6));
            musicalInstrumentList.Add(new WindInstrument(name: "Сопілка"/*, isTuned: true*/));
            musicalInstrumentList.Add(new WindInstrument(name: "Саксофон", isTuned: true));
        }
        public void Show()
        {
            foreach (var musicalinstrument in musicalInstrumentList)
            {
                musicalinstrument.ShowInfo();
            }   
        }

        public void Sounds()
        {
            foreach (var musicalinstrument in musicalInstrumentList)
            {
                musicalinstrument.MakeSound();
            }
        }
    }
}
