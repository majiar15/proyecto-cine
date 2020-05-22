# Proyecto Cine 

## Autores
* *[Daniel Alfonso Salinas Salinas](https://github.com/danielsalinas70)*
* *[Diego Andres Esquivia Castro](https://github.com/Dekhas20)*
* *[Martin Jose Jimenez Aragon](https://github.com/majiar15)*
* *[Jesus David Morales Cano](https://github.com/jesusmoralescano)*




### metodo OpenInPanelCentral

` public void OpenFormInPanelCentral(object FormHijo = null)`
este metodo pertenecea la clase homeCajero se utiliza para abiri un formulario en el panel central donde originalmente va una imagen de bienvenidos

Formas de utilizar el metodo

en todas las clases de los formularios que van dentro de el panel padre se debe debe definir un parametro de tipo  homeCajero y creear una variable de tipo home cajero para asignarle el valor pasador por parametro en el constructor 
```C#
public partial class Reservas : Form{ 
    homeCajero formParent;
        public Reservas(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }
```
- Abrir formulario en el panel central

en donde se desea abrir el formulario en el panel se debe creear una clase del tipo del formulario a abrir y pasarle el formulario padre ya definido en la clase, llamar al metodo  `OpenFormInPanelCentral()`, pasar como parametro el formulario instanciado y al final cerrar el formulario actual 
```C#
cancelarReserva cancelarReservaForm = new cancelarReserva(this.formParent);
this.formParent.OpenFormInPanelCentral(cancelarReservaForm);
this.Close();
```

- Abrir imagen por defecto

usualmente se utilizara para redirigir a el homeCajero
en constructor de la clase actual se debe llamar al metodo `OpenFormInPanelCentral()` sin parametros y cerrar el formulario actual
```C#
this.formParent.OpenFormInPanelCentral();
this.Close();
```

