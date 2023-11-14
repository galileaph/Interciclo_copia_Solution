namespace DigitalsoftWebApp.Models.Account
{
    public class LoggedUserMapper
    {
        public static LoggedUser loggedUserResponseToEntity(LoggedUserResponse user)
        {
            return new LoggedUser(user.UserId, user.EmpleadoId, user.Token, user.Email, user.Username, user.ProfilePicture,
                user.Empleado.PersonaNroIdentificacion, user.Empleado.PersonaNombres, user.Empleado.PersonaApellidos
          );
        }
    }
}
