using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Vettore 
{
    public class Vettore{
    public double x { get; set; }
    public double y { get; set; }
    public Vettore(double X, double Y)
    {
        X = x;
        Y = y;

    }
    public static Vettore operator -(Vettore v1, Vettore v2)
    {
        return new Vettore(v1.x - v2.x, v1.y - v2.y);
    }
    public static Vettore operator *(Vettore v1, Vettore v2)
    {
        return new Vettore(v1.x + v2.x, v1.y + v2.y);
    }

    public static Vettore operator *(Vettore v1, int n)
    {
        return new Vettore(v1.x * n, v1.y * n);
    }

    public static Vettore operator *(int n, Vettore v1)
    {
        return new Vettore(v1.x * n, v1.y * n);
    }

    public static Vettore operator /(Vettore v1, int n)
    {
        return new Vettore(v1.x / n, v1.y / n);
    }

    public static Vettore operator +(Vettore v1)
    {
        return new Vettore(v1.x, v1.y);
    }
    public static Vettore operator -(Vettore v1)
    {
        return new Vettore(-v1.x, -v1.y);
    }
    public static bool operator ==(Vettore v1, Vettore v2)
    {
        if (v1.x == v2.x && v1.y == v2.y)
            return true;
        else
            return false;
    }
    public static bool operator !=(Vettore v1, Vettore v2)
    {
        if (v1.x != v2.x)
            return true;
        else
            return false;
    }     
}
}
