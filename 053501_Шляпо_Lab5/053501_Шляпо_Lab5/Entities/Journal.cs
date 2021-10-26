using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    class Journal{
        private class DescribeEvent{
            public string traf;
            public string name;
            public DescribeEvent(string traf, string name){
                this.traf = traf;
                this.name = name;
            }
        }
        List<DescribeEvent> ListEvents = new List<DescribeEvent>();
        public Journal(){}

        public void RegistrationEvent(string traf, string name){
            DescribeEvent a = new DescribeEvent(traf, name);
            ListEvents.Add(a);
        }

        public void Info(){
            for (int i = 0; i < ListEvents.Count; i++){
                Console.WriteLine(ListEvents[i].traf);
                Console.WriteLine(ListEvents[i].name);
            }
        }
    }
}
