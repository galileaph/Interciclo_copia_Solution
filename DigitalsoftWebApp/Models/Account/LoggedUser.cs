using Newtonsoft.Json;

namespace DigitalsoftWebApp.Models.Account
{
    public class LoggedUser
    {
        public Guid UserId { get; set; }
        public long EmpleadoId { get; set; }

        public string Token { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }
        public object ProfilePicture { get; set; }
        public string PersonaNroIdentificacion { get; set; }
        public string PersonaNombres { get; set; }
        public string PersonaApellidos { get; set; }

        public LoggedUser(Guid userId, long empleadoId, string token, string email, string username, 
            object profilePicture, string personaNroIdentificacion, string personaNombres, string personaApellidos)
        {
            UserId = userId;
            EmpleadoId = empleadoId;
            Token = token;
            Email = email;
            Username = username;
            ProfilePicture = profilePicture;
            PersonaNroIdentificacion = personaNroIdentificacion;
            PersonaNombres = personaNombres;
            PersonaApellidos = personaApellidos;
        }
    }
}
