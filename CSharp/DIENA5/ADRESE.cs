﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA5
{
    public class ADRESE
    {
        public string Valsts;
        public string Pilseta;
        public string Iela;
        public string MajasNr;
        public int DzivoklaNr;
        public string PilnaAdrese()
        {
            return Valsts + "," + Pilseta + "," + Iela + "  " + MajasNr + "  " + DzivoklaNr;
        }
    }
}
