using System;
namespace sentencias
{
    public class Sentencias
    {
    }

    public void ejemploIF(){
        bool bandera = true;
        if ( bandera == true )
        {
            Console.WriteLine( "La bandera es verdadera." );
        }
        else
        {
            Console.WriteLine( "La bandera es falsa." );
        }
    }

    public void ejemploFOR(){
        for ( int i = 1; i <= 5; i++ )
        {
            Console.WriteLine( "El número actual es " + i );
        }
    }
}
