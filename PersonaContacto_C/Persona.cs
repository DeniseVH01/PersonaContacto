using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaContacto_C
{
    class Persona
    {
        protected String Nombre;
        protected String ApellidoP;
        protected String ApellidoM;
        protected DateTime FechaN;
        protected String RFC;

        public string NombreP {
            get {
                return Nombre;
            }
            set {
                Nombre = value;
            } }

        public string ApellidoPP {
            get {
                return ApellidoP;
            }
            set {
                ApellidoP = value;
            }
        }
        public string ApellidoPM {
            get {
                return ApellidoM;
            }
            set {
                ApellidoM = value;
            }
        }

        public DateTime FechaNP {
            get {
                return FechaN;
            }
            set {
                FechaN = value;
            }
        }

        public string RFCP {
            get {
                RFC = (ApellidoP.Substring(0, 2) + ApellidoM.Substring(0, 1) + Nombre.Substring(0, 1) + FechaN.ToString().Substring(8, 2) + FechaN.ToString().Substring(3, 2) + FechaN.ToString().Substring(0, 2)).ToUpper();
                return RFC;
            }

        }
        public  Persona(String Nombre1, String APPat1, String APMat1, DateTime  FechaN1, String RFC1) {
            Nombre = Nombre1;
        ApellidoPP = APPat1;
        ApellidoM = APMat1;
        FechaN = FechaN1;
        RFC = RFC1;
    }


    
    }
}

