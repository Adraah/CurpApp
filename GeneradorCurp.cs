using System.Text;

namespace Core
{
    public static class GeneradorCurp
    {
        public static string Generar(string nombre, string apellidoP, string apellidoM, string fecha, string estado,string sexo)
        {
            nombre = nombre.ToUpperInvariant();
            apellidoP = apellidoP.ToUpperInvariant();
            apellidoM = apellidoM.ToUpperInvariant();
            estado = estado.ToUpperInvariant();

            var curp = new StringBuilder();

            curp.Append(apellidoP.Substring(0,2));
            curp.Append(apellidoM.Substring(0, 1));
            curp.Append(nombre.Substring(0, 1));
            curp.Append(fecha);
            curp.Append(sexo);
            curp.Append(estado);
            curp.Append(apellidoP.Substring(1, 2));
            curp.Append(apellidoM.Substring(1, 2));
            curp.Append(nombre.Substring(1, 2));
            curp.Append("0");
            curp.Append("9");

            return curp.ToString();
        }
    }
}
