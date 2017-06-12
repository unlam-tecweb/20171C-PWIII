﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
   public  class PersistenciaReserva
    {
       MyContext ctx = new MyContext();
       public List<Versiones> ObtenerVersiones()
       {
           var versiones = (from v in ctx.Versiones select v).ToList();
           List<Versiones> listaversiones = new List<Versiones>();

           foreach (Versiones version  in versiones)
           {
               Versiones ver =  new Versiones();
               ver.IdVersion = version.IdVersion;
               ver.Nombre = version.Nombre;
               listaversiones.Add(ver);
           }

           return listaversiones;
       }

       public List<Reservas> ObtenerDias()
       {
           var dias = (from s in ctx.Reservas select s).ToList();
           List<Reservas> listaversiones = new List<Reservas>();
           foreach (Reservas reserva in dias)
           {
               Reservas re = new Reservas();
               re.IdReserva = reserva.IdVersion;
               re.FechaCarga = reserva.FechaCarga;
               listaversiones.Add(re);
           }
           return listaversiones;
       }

       public List<Reservas> ObtenerHorarios()
       {
           var horarios = (from s in ctx.Reservas select s).ToList();
           List<Reservas> listahorarios = new List<Reservas>();
           foreach (Reservas reserva in horarios)
           {
               Reservas re = new Reservas();
               re.IdReserva = reserva.IdVersion;
               re.FechaHoraInicio = reserva.FechaHoraInicio;
               listahorarios.Add(re);
           }
           return listahorarios;
       }
    }
}
