// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Abel Salazar Galindo ID");

int altura = 165;
int edad = 35;
string nombre = "Abel Salazar Galindo";
string lugarDeNacimiento = "Puebla";
var fechaDeNaciemiento = $"16 de Octubre de 1988, en {lugarDeNacimiento}";
string informacion = "es estudiante de platzi, en el curso de C#";
var hobby = "Ver deportes";

string id = $"La informacion de {nombre}:\n nacio el {fechaDeNaciemiento}, {lugarDeNacimiento},\n su altura es de {altura}cms,\n tiene {edad} años.\n" +
    $" Informacion relevante {informacion}, y su hobby es {hobby}";

Console.WriteLine(id);