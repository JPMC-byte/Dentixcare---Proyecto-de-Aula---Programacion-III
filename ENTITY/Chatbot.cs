using System;

namespace ENTITY
{
    public class Chatbot
    {
        public string IdChatbot { get; set; }
        public string Plataforma { get; set; }
        public string NombreChatbot { get; set; }
        public int NumeroRecordatorios { get; set; }
        public string MensajeRecordatorios { get; set; }
        public string FrecuenciaRecordatorios { get; set; }
        public string IdConsultorio { get; set; }

        public Chatbot() { }

        public Chatbot(string idChatbot, string plataforma, string nombreChatbot, int numeroRecordatorios, string mensajeRecordatorios, string frecuenciaRecordatorios, Consultorio consultorio)
        {
            IdChatbot = idChatbot;
            Plataforma = plataforma;
            NombreChatbot = nombreChatbot;
            NumeroRecordatorios = numeroRecordatorios;
            MensajeRecordatorios = mensajeRecordatorios;
            FrecuenciaRecordatorios = frecuenciaRecordatorios;
            IdConsultorio = consultorio.Codigo;
        }

        public override string ToString()
        {
            return $"{IdChatbot};{Plataforma};{NombreChatbot};{NumeroRecordatorios};{MensajeRecordatorios};{FrecuenciaRecordatorios};{IdConsultorio}";
        }
    }
}
