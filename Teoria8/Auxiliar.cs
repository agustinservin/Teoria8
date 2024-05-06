namespace Teoria8;
class Auxiliar
{
    // public void Procesar()
    // {
    //     FuncionEntera f; 
    //     f = SumaUno;// f = new FuncionEntera(SumaUno);
    //     Console.WriteLine(f?.Invoke(10));
    //     f = SumaDos;
    //     Console.WriteLine(f(10));
    // }  

    //expresiones lambda (metodos anonimos) f = (int n) => {return n+1;}; , si el parametro no es ref,out o in no es necesario aclarar el tipo del parametro f= (n) => ... si hay una sola instruccion no necesita llaves. Sin parametros f=()=> haceralgo;
    public void Procesar()
    {
       int[] v =[11, 5, 90];
        //Aplicar(v, SumaDos);
        //Imprimir(v);
        //Aplicar(v, SumaUno);
       Aplicar(v, n => n*2);
       Imprimir(v);
       Aplicar(v, n => n+10);
       Imprimir(v);
    } 
    int SumaUno(int n) => n + 1;
    int SumaDos(int n) => n + 2;

    void Aplicar(int[] v, FuncionEntera f)
    {
        for (int i = 0; i < v.Length; i++)
        {
            v[i] = f(v[i]);
        }
    }
    void Imprimir(int[] v)
    {
        foreach (int i in v)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }


}