// See https://aka.ms/new-console-template for more information
using Semana04IntroCSharp;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de aplicaciones web";
int edad = 20;
double salario = 2000;

var alumno = "Luis Chang";
var mundial = 2026;

var player = new Persona();
player.dni = 11223344;
player.name = "Paolo Guerrero";
player.phone = "051-897787878";
player.active = true;

var player2 = new Persona()
{
    dni = 11335577,
    name = "Claudio Pizarro",
    phone = "084-5454545",
    active = false,
};

var player3 = new Persona(22446688,"Gianluca Lapadula","878-54578878",true);
var player4 = new Persona(33559988, "Pedro Gallese", "051-78878787", true);

var personas = new List<Persona>();
personas.Add(player);
personas.Add(player2);
personas.Add(player3);
personas.Add(player4);

//Buscar a la persona Lapadula con DNI 22446688
//Linq Query Expressions

var busqueda =  (from p in personas
                 where p.dni == 22446688
                 select p).FirstOrDefault();

Console.WriteLine("La persona encontrada es: " 
                    + busqueda.name);

//Buscar por lambda expressions

var otraBusqueda = personas
                    .Where(a=>a.dni == 22446688)
                    .FirstOrDefault();

