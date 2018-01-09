﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centrale
{

    class Program
    {
        static void Main(string[] args)
        {
            Centrale bugey = new Centrale();        // comme on a fait un central() {} tout ce qui etait dans les { s'est lancé quand on a fait l'objet
            bugey.Refroidir();

            Console.Read();
        }
    }

    class Centrale
    {
        //public List<RefroidirDelegate> ListeDelegue = new List<RefroidirDelegate>();
        public event RefroidirDelegate FaitChaud;

        //public ArrayList ListePompe = new ArrayList();
        public Centrale()
        {
            PompeHydraulique Ph1 = new PompeHydraulique();
            PompeElectrique Pe1 = new PompeElectrique();
            PompeElectrique Pe2 = new PompeElectrique();
            PompeManuelle Pm1 = new PompeManuelle();

            //ListePompe.Add(Ph1);
            //ListePompe.Add(Pe1);
            //ListePompe.Add(Pe2);
            //ListePompe.Add(Pm1);

            RefroidirDelegate dh1 = new RefroidirDelegate(Ph1.Refroidir);
            RefroidirDelegate de1 = new RefroidirDelegate(Pe1.Refroidir);
            RefroidirDelegate de2 = new RefroidirDelegate(Pe2.Refroidir);
            RefroidirDelegate dm1 = new RefroidirDelegate(Pm1.Refroidir);

            //ListeDelegue.Add(dh1);
            //ListeDelegue.Add(de1);
            //ListeDelegue.Add(de2);
            //ListeDelegue.Add(dm1);
            FaitChaud += dh1;
            FaitChaud += de1;
            FaitChaud += de2;
            FaitChaud += dm1;
        }
        //public void Refroidir()
        //{
        //    foreach(Object p in ListePompe)
        //    {
        //        if (p is PompeHydraulique)
        //            ((PompeHydraulique)p).Refroidir(); 
        //        else if (p is PompeElectrique)
        //            ((PompeElectrique)p).Refroidir();
        //        //else if (p is PompeManuelle)
        //        //    ((PompeManuelle)p).Refroidir();
        //        else
        //            throw new Exception("Erreur improbable !!");
        //    }
        //}
        public void Refroidir()
        {
            ParametreEventArgs args = new ParametreEventArgs
            {
                Temperature = 3000,
                Pression = 100
            };
            //foreach (RefroidirDelegate d in ListeDelegue)
            //{
            //    d.Invoke(args);
            //}
            FaitChaud(args);
        }
    }
    class PompeHydraulique
    {
        public void Refroidir(ParametreEventArgs args)
        {
            Console.WriteLine("({0}°) La pompe hydraulique est lancée..", args.Temperature);
        }
    }
    class PompeElectrique
    {
        public void Refroidir(ParametreEventArgs args)
        {
            Console.WriteLine("({0}°) La pompe électrique est lancée..", args.Temperature);
        }
    }
    class PompeManuelle
    {
        public void Refroidir(ParametreEventArgs args)
        {
            Console.WriteLine("({0}°) La pompe manuelle est lancée..", args.Temperature);
        }
    }

    delegate void RefroidirDelegate(ParametreEventArgs args);
    class ParametreEventArgs : EventArgs
    {
        public int Temperature;
        public int Pression;
    }
}
