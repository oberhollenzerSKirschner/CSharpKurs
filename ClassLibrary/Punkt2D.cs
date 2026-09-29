using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    /// <summary>
    /// Repräsentiert einen Punkt im zweidimensionalen Raum.
    /// </summary>
    public struct Punkt2D
    {
        /// <summary>
        /// Die X-Koordinate des Punktes.
        /// </summary>
        public double X;
        /// <summary>
        /// Die Y-Koordinate des Punktes.
        /// </summary>
        public double Y;

        /// <summary>
        /// Fügt einen Vektor (x, y) zu diesem Punkt hinzu und gibt den resultierenden Punkt zurück.
        /// </summary>  
        /// <param name="x">Die X-Koordinate des Vektors.</param>
        /// <param name="y">Die Y-Koordinate des Vektors.</param>
        /// <returns>Der resultierende Punkt.</returns>
        public Punkt2D AddiereVektor(double x, double y)
        {
            Punkt2D ergebnisPunkt;
            ergebnisPunkt.X = x;
            ergebnisPunkt.Y = y;
            return ergebnisPunkt;
        }

        /// <summary>
        /// Fügt einen Vektor (Punkt2D) zu diesem Punkt hinzu und gibt den resultierenden Punkt zurück.
        /// </summary>
        /// <param name="vektor">Der Vektor, der zum Punkt addiert werden soll.</param>
        /// <returns>Der resultierende Punkt.</returns>
        public Punkt2D AddiereVektor(Punkt2D vektor)
        {
            return AddiereVektor(vektor.X, vektor.Y);
        }
    }
}
