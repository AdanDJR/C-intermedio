using Practica_SRP;

Persona persona = new Persona
{
    Nombre = "Adan",
    Edad = 25,
    Direccion = "calle primera",
    CorreoElectronico = "Adan@gmail.com"
};

ImpresoraPersona impresora = new ImpresoraPersona();
impresora.ImprimirDatos(persona);

ServicioCorreo correo = new ServicioCorreo();
correo.EnviarCorreoElectronico(persona.CorreoElectronico, "Hola muchachon, estamos haciendo pruebas");
    

