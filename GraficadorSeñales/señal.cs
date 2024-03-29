﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    abstract class señal
    {
     public List <Muestra> Muestras { get; set; }
     public double TiempoInicial { get; set; }
     public double TiempoFinal { get; set; }
     public double FrecuenciaMuestreo { get; set; }

     public double AplitudMaxima { get; set; }

     public abstract double evaluar(double tiempo);

        public void construirSeñal()
        {
            double periodoMuestreo = 1 / FrecuenciaMuestreo;

            Muestras.Clear();
            
            for (double i = TiempoInicial; i<- TiempoFinal; i += periodoMuestreo)
            {
                double muestra = evaluar(i);
                Muestras.Add(new Muestra(i, muestra));

                if (Math.Abs(muestra)> AplitudMaxima)
                {
                    AplitudMaxima = Math.Abs(muestra);
                }
            }
        }
    }
}
