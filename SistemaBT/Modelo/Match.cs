﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;    

namespace Modelo
{
    public class Match
    {
        /*
        private int idMatch;
        private DateTime fechaAsignacion;
        private DateTime fechaFin;
        private string estado;
        private BindingList<Encuesta> encuestas = new BindingList<Encuesta>();
        private BindingList<Aconsejado> aconsejados = new BindingList<Aconsejado>();

        public int IdMatch { get => idMatch; set => idMatch = value; }
        public DateTime FechaAsignacion { get => fechaAsignacion; set => fechaAsignacion = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Estado { get => estado; set => estado = value; }
        public BindingList<Encuesta> Encuestas { get => encuestas; set => encuestas = value; }
        public BindingList<Aconsejado> Aconsejados { get => aconsejados; set => aconsejados = value; }
        */


        ///*
        private int idMatch;
        private int idAconsejado; 
        private int idConsejero;
        private DateTime fechaAsignacion;
        private DateTime fechaFin;
        private string estado;
        private BindingList<Encuesta> encuestas = new BindingList<Encuesta>();

        public Match() { }

        public int IdAconsejado { get => idAconsejado; set => idAconsejado = value; }
        public int IdConsejero { get => idConsejero; set => idConsejero = value; }
        public DateTime FechaAsignacion { get => fechaAsignacion; set => fechaAsignacion = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Estado { get => estado; set => estado = value; }
        public BindingList<Encuesta> Encuestas { get => encuestas; set => encuestas = value; }
        public int IdMatch { get => idMatch; set => idMatch = value; }
        //*/
    }
}
