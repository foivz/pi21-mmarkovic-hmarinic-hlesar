﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    partial class Lokacija
    {

        public static void DodajLokaciju(Lokacija lokacija)
        {
            using (var context = new SkladisteDatabase())
            {
                context.Lokacijas.Add(lokacija);
                context.SaveChanges();
            }
        }

        public static List<Lokacija> DohvatiSveLokacije()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            select sveLokacije;

                return query.ToList();
            }
        }

        public static List<Lokacija> DohvatiBazicneLokacije()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            where sveLokacije.Nadlokacija == null
                            select sveLokacije;

                return query.ToList();
            }
        }

        public static List<Lokacija> DohvatiLokavijePremaNazivu(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            where sveLokacije.Naziv.Contains(naziv)
                            select sveLokacije;

                return query.ToList();
            }
        }

        public static Lokacija DohvatiLokacijuPremaIdu(int id)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            where sveLokacije.Id == id
                            select sveLokacije;

                return query.Single();
            }
        }

        public void DohvatiRobuNaSvimPodlokacijama(ref List<Roba> roba)
        {
            foreach (var zapis in Roba.DohvatiSvuRobuNaLokaciji(this))
            {
                Roba pronadeniZapis = roba.Find(x => x.Id == zapis.Id);
                if (pronadeniZapis == null)
                {
                    roba.Add(zapis);
                }
                else
                {
                    pronadeniZapis.Kolicina += zapis.Kolicina;
                }
            }

            foreach(var podlokacija in this.DohvatiPodlokacije())
            {
                podlokacija.DohvatiRobuNaSvimPodlokacijama(ref roba);
            }
        } 

        public List<Lokacija> DohvatiPodlokacije()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from podlokacije in context.Lokacijas
                            where podlokacije.Nadlokacija == this.Id
                            select podlokacije;

                return query.ToList();
            }
        }

        public bool ObrisiLokaciju()
        {
            using (var context = new SkladisteDatabase())
            {
                context.Lokacijas.Attach(this);
                context.Lokacijas.Remove(this);
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
