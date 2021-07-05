using CafeteriaModel;
using CafeteriaModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CafeteriaRewards_Web
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //cuando no viene de una peticion POST
            {
                List<Bebida> bebidas = new BebidasDAL().GetAll();
                bebidaDdl.DataSource = bebidas;
                //Indica que se va a mostrar en el dropdownlist
                bebidaDdl.DataTextField = "Nombre";
                //Indica que va a obtener en el dropdownlist
                bebidaDdl.DataValueField = "Codigo";
                bebidaDdl.DataBind();
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

            }
            else
            {

            }
        }

        protected void rutCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String rut = rutTxt.Text.Trim();

            if(rut == string.Empty)
            {
                //En caso que sea vacio
                rutCV.ErrorMessage = "Debe ingresar el rut";
                args.IsValid = false;
            }
            else
            {
                //Rut Valido: 12345678-9

                String[] rutArray = rut.Split('-');
                /*
                 * rutArray[0] = 12345678
                 * rutArray[1] = 9
                 */

                if(rutArray.Length == 2)
                {
                    if(rutArray[1].Length != 1)
                    {
                        //En caso que el digito verificador tiene mas de un caracter
                        rutCV.ErrorMessage = "El digito verificador debe tener un caracter";
                        args.IsValid = false;
                    }
                    else
                    {
                        //cumple el formato
                        args.IsValid = true;
                    }
                }
                else
                {
                    //Case en que rut no tiene un solo guion
                    rutCV.ErrorMessage="El rut debe tener un guion";
                    args.IsValid = false;
                }

            }
        }
    }
}