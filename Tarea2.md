# TAREA 2
## 2.1 Declaración de clases: atributos, métodos, encapsulamiento.
###   Lee y escribe un resumen con tus palabras del siguiente documento: http://msdn.microsoft.com/es-es/library/ms173109.aspx
Las clases y estructuras nos sirver para encapsular un conjunto de datos y comportamientos que formar un conjunto como una unidad logica. Estos datos y comportamientos se denominan miebros de la clase, estos poseen metodos, propiedades y eventos.
La declaracion de clases se utiliza para crear instancias u objetos en tiempo de ejecucion, por ejemplo, podemos decir que persona es el nombre de la clase, y P es una instancia de la clase personas, podria llamarse Persona.P, o persona.edad, donde edad seria la instancia o la propiedad por asi decirlo/
Una clase es un tipo de referencia, al crearse un objeto en base a esa clase, a ese objeto se le asigna una variable para que la contenga,
asi que cada vez que el valor del objeto se actualize tambien lo hara la variable que se le asigno, la cual hace de referencia para el objeto y ambos hacen referencia de si mismas.
Una estructura es un tipo de valor, al crearse una estructura, la variable que se le asigne guardara datos reales en ella, y se copiaran, se crean 2 copias de estos datos, la original y la variable, ninguna afecta la otra cuando se modifican los valores, por lo que son independientes una de otra.
Un uso adecuado de las clases es ser utilizadas en trabajos cuyos datos quieran ser manipulados despues de hacer dicha clase, lo contrario pasa con las estructuras, son buenas aplicandose en sistemas mas sencillos que no sufran modificaciones despues de su creacion.
### Encapsulamiento
Es uno de los elementos mas importantes (si no el que mas lo es) de la programacion orientada a objetos. El encapsulamiento consiste en proteger y delimitar la interaccion posterior que se tendra con los datos de una clase o estructura, para evitar malograr el funcionamiento correcto del sistema, esto se hace declaranado una clase o estructura como privada o protegida.
### Herencia
Solo las clases tienen esta caracteristica. La herencia es practicamente una clase que deriva de otra, por ejemplo, una clase principal llamada Persona y la subclase heredada llamada Hombre.
Una propiedad es que las clases se pueden declarar como abstractas, esto quiere decir que uno o varios metodos no tienen ninguna implentacion o uso. Tambien se pueden declarar como Sealed, esto evita que una clase pueda heredar otras.
## 2.2 Instanciación de una clase.
### Investiga sobre el operador new visto en clase. Describe algunos de sus usos.
Su principal funcion es crear objetos e invocar constructores, un ejemplo de esto es el siguiente:
+ Class1 obj  = new Class1(); 
Un constructor no puede ser usado en estructuras(struct).
## 2.3 Referencia al objeto actual.  

### La palabra clave **this** hace referencia a la instancia actual de la clase. 

+ Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.
+ Escribe un programa donde se utilice this como parámetro.

#### Estos ejercisios se encontraran en sus respectivos folders dentro del repositorio.(https://github.com/jr110/Tarea-2/blob/master/Programas%20Tarea%202/TareaThis.cs)
## 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.

### Lee y escribe un resumen con tus palabras de los siguientes documentos: 

   +     https://msdn.microsoft.com/es-ES/library/8f1hz171.aspx

+      https://msdn.microsoft.com/es-es/library/w5zay9db.aspx      

 +     https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx

  +     https://msdn.microsoft.com/es-es/library/14akc2c7.aspx
  
  ## Parámetros de métodos
 Los parametros declarados para un metodo realizan la operacion para las que fueron llamados y pieden los datos que estos almacenan al terminar la operacion del llamado si no se declaran con palabras claves apropiadas.
 Estas palabras son: 
 + **Params** : lo que hace es que el parametro pueda tomar un numero variable de argumentos, solo aplica a matrices unidimencionales. 
 + **in** : Este parametro es una referencia y se ejecuta o lee cuando se hace la llamada del metodo.
 + **ref** :Este, al igual que in, es una referencia, y este es mas flexible al poderse editar y modificar por el metodo llamada.
 + **out** : Este es igual es una referencia y se modifica unicamente cuando el metodo es llamada.
  cabe recalcar que estas palabras clave se declaran como parametros en un metodo.
  
 ## 2.5 Constructores y destructores: declaración, uso y aplicaciones.
 Los constructores son basicamente metodos de una clase,su funcion es inicializar estos solo se ejecutan cuando se requieren crear objetos, estos constructores se llaman igual que su clase. puede haber diferentes tipo de constructores como lo seria del tipo struct, estos son iguales a los constructores normales solo que estos no pueden contener un constructor predeterminado ya que el compilador otorga uno de manera automatica. solo las estructuras y las clases pueden definir constructores que acepten parametros. Un constructor puede invocar a otro mediante la palabra clave this.
 
  ## 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.

  ### Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.

  ### Debe de tener por lo menos las siguientes propiedades:

+ valor
+ color
    ### La clase debe contar por lo menos con:

      + Dos constructores sobrecargados.

      + Los operadores ==, <, > sobrecargados.

      + El uso de la palabra clave this.

   

   ### Utiliza tu clase dentro del método Main de tu programa, creando tres dados, arrojándolos e imprimiendo el mejor de ellos 

    ### o si alguno es igual.
    ## Trabajo en repositorio


