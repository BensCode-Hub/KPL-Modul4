using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul4_103082400008
{
    internal class PosisiKarakterGame
    {
       
    public enum State { Jongkok, Berdiri, Tengkurap, Terbang }

        private State currentState = State.Berdiri;

        public void TekanTombol(string tombol,int  nim)
        {
            State nextState = currentState;
            int hasilMod =  nim % 3;

            if (hasilMod == 1)
            {
                if (currentState != State.Berdiri && nextState == State.Berdiri) 
                    Console.WriteLine("posisi standby");
                if (currentState != State.Tengkurap && nextState == State.Tengkurap) 
                    Console.WriteLine("posisi istirahat");
            }

            if (currentState == State.Berdiri)
            {
                if (tombol == "TombolS") nextState = State.Jongkok;
                if (tombol == "TombolW") nextState = State.Terbang;
            }
            else if (currentState == State.Jongkok)
            {
                if (tombol == "TombolW") nextState = State.Berdiri;
                if (tombol == "TombolS") nextState = State.Tengkurap;
            }
            else if (currentState == State.Tengkurap)
            {
                if (tombol == "TombolW") nextState = State.Jongkok;
            }
            else if (currentState == State.Terbang)
            {
                if (tombol == "TombolS") nextState = State.Berdiri;
                if (tombol == "TombolX") nextState = State.Jongkok;
            }

            currentState = nextState;
            Console.WriteLine("State sekarang: " + currentState);
        }
    }
}
    

    

