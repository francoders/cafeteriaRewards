## Cafeteria Rewards

### Parte 1:
La empresa StarCap , dedicada a la venta de café le solicita generar un sistema para el ingreso de sus Clientes en un programa llamado StarCap Rewards
Para lo anterior, solicita que desarrolle la siguiente aplicación ASP.NET:

### AgregarCliente.aspx:
> El sistema debe solicitar:

1. **Nombre:** String
2. **Rut:** String (Con guión separador, en la parte derecha debe existir solo un carácter que representa el dígito verificador)
3. **Bebida Favorita:** String, seleccionable mediante un DropDownList, con alguno de los siguientes valores:

   - Frapuchino
   - Café
   - Té
   - Té Chai

4. Nivel de Cliente ( Seleccionable mediante un RadioButtonList ):
   - Silver
   - Gold
   - Platinum

En la parte inferior, un botón agregar que, al presionarlo, en el caso de que el rut del cliente no
exista en el sistema y todos sus campos estén ingresados, debe efectuar el ingreso de una nueva
instancia de Cliente, implementada en la capa DAL, en caso contrario debe mostrar un textdanger
con los errores de validación por cadacomponente del formulario con un mensaje
general de error.

### VerClientes.aspx:

> El formulario debe mostrar una grilla con los datos de los Clientes ingresados al sistema que
incluya:
- Nombre
- Bebida Favorita
- Nivel de Cliente
- Botón “Sacar del Programa”: Al presionar este botón el sistema debe dar de baja al Cliente del sistema, eliminando su registro.

En la parte superior debe existir un DropDownList que permita filtrar por Nivel de Cliente. Al
seleccionar una opción, el sistema debe mostrar solo los Clientes que sean del Nivel seleccionado.
Al lado del **DropDownList**, un CheckBox denominado “Todos”, cuando está activo este checkbox,
el DropDown se deshabilita y se muestran todos los Clientes del sistema.
Principal.master:
• Debe implementar bootstrap
• Debe poseer una barra con los vínculos de navegación a todas las páginas de la aplicación.
Todos los WebForm de la aplicación deben usarla como base.

 <p align="center"> 
    <img src="https://user-images.githubusercontent.com/71857156/124399672-ef4a1600-dcea-11eb-9e83-a8afad9cf252.png" alt="img">
 </p>

### Parte 2:
• Agregar un fichero Login.aspx que implemente un control de acceso mediante el uso del
componente asp:Login. Definir una lista de usuarios permitidas estática en UsuariosDAL <br>
• Implementar UpdatePanel y UpdateProgress para la carga mediante AJAX del filtro de Clientes.
