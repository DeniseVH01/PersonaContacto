using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaContacto_C
{
    class Contacto : Persona

    {
        protected string Telefono;
        protected string CorreoElect;

        public string TelefonoP {
            get {
                

                return Telefono;

            }
            set { 
            Telefono = value;
    }
    }
    public string CorreoElectP {
        get {

            return CorreoElect;

        }
        set {
            CorreoElect = value;
        }
    }

        
        public Contacto(string  Nombre1, string APPat1, string APMat1, DateTime FechaN1, string RFC1, string  Telef1, string  correoelect1):base(Nombre1,APPat1,APMat1,FechaN1,RFC1 ) {
            Nombre = Nombre1;
        ApellidoPP = APPat1;
        ApellidoM = APMat1;
        FechaN = FechaN1;
        RFC = RFC1;
        TelefonoP = Telef1;
        CorreoElect = correoelect1;
}
    public  string Info {
            get {
                return "Nombre: "+NombreP +" " +ApellidoPP +" " +ApellidoPM+"\rFECHA NACIMIENTO: "+FechaNP.ToShortDateString()+"\rTELEFONO: "+TelefonoP+"\rCORREO ELECTRONICO: "+CorreoElectP+"\rRFC: "+RFCP ;                
}
        }
    }
}
