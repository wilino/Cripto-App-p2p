using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Models;
using Google.Authenticator;



namespace WebApplication2.Logic.Login
{
    public class RegisterGoogleAuth
    {
    
        public static SetupCode ObtenerCodigoRegistroGoogleAuthenticator()
        {
            TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();

            var setupInfo = autenticador.GenerateSetupCode("Ejemplo Google Auth", "Antonio Banderas",
               "abcdefgh123", 300, 300);
            return setupInfo;
        }

        
        public static bool EnableGoogleAuthenticator(string Clave)
        {
            TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();
            var idUsuario = "abcdefgh123";

            var resultado = autenticador.ValidateTwoFactorPIN(idUsuario,
                Clave);

            if (resultado)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
