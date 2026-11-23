using System;

public class AdaptadorGPS : IProveedorPosicionUTM
{
    // 1. CAMPOS / ATRIBUTOS
    private ModuloGPS moduloGPS;

    // 2. CONSTRUCTOR
    public AdaptadorGPS(ModuloGPS moduloGPS)
    {
        this.moduloGPS = moduloGPS;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public CoordenadaUTM ObtenerPosicionUTM()
    {
        CoordenadaGeografica posicion =
            moduloGPS.ObtenerPosicionActual();

        return ConvertirAUTM(posicion);
    }

    private CoordenadaUTM ConvertirAUTM(
        CoordenadaGeografica posicion)
    {
        double latitud = posicion.Latitud;
        double longitud = posicion.Longitud;

        if (!double.IsFinite(latitud) ||
            !double.IsFinite(longitud) ||
            latitud < -80 || latitud > 84 ||
            longitud < -180 || longitud > 180)
        {
            throw new ArgumentOutOfRangeException(
                nameof(posicion),
                "Coordenadas fuera del rango UTM.");
        }

        // Parámetros del elipsoide WGS84.
        double radio = 6378137.0;
        double f = 1.0 / 298.257223563;
        double e2 = f * (2 - f);
        double ePrima2 = e2 / (1 - e2);
        double k0 = 0.9996;

        // Determinación de la zona UTM.
        int zona = Math.Min(60,
            (int)Math.Floor((longitud + 180) / 6) + 1);

        // Excepciones geográficas de Noruega y Svalbard.
        if (latitud >= 56 && latitud < 64 &&
            longitud >= 3 && longitud < 12)
        {
            zona = 32;
        }

        if (latitud >= 72 && latitud < 84)
        {
            if (longitud >= 0 && longitud < 9)
                zona = 31;
            else if (longitud >= 9 && longitud < 21)
                zona = 33;
            else if (longitud >= 21 && longitud < 33)
                zona = 35;
            else if (longitud >= 33 && longitud < 42)
                zona = 37;
        }

        // Conversión de grados a radianes.
        double lat = latitud * Math.PI / 180;
        double lon = longitud * Math.PI / 180;
        double lonCentral = (zona * 6 - 183) *
                            Math.PI / 180;

        double sinLat = Math.Sin(lat);
        double cosLat = Math.Cos(lat);
        double tanLat = Math.Tan(lat);

        double n = radio /
            Math.Sqrt(1 - e2 * sinLat * sinLat);

        double t = tanLat * tanLat;
        double c = ePrima2 * cosLat * cosLat;
        double a = cosLat * (lon - lonCentral);

        // Arco meridiano.
        double m = radio * (
            (1 - e2 / 4 - 3 * Math.Pow(e2, 2) / 64
                - 5 * Math.Pow(e2, 3) / 256) * lat
            - (3 * e2 / 8 + 3 * Math.Pow(e2, 2) / 32
                + 45 * Math.Pow(e2, 3) / 1024)
                * Math.Sin(2 * lat)
            + (15 * Math.Pow(e2, 2) / 256
                + 45 * Math.Pow(e2, 3) / 1024)
                * Math.Sin(4 * lat)
            - 35 * Math.Pow(e2, 3) / 3072
                * Math.Sin(6 * lat));

        // Coordenada Este.
        double este = 500000 + k0 * n * (
            a + (1 - t + c) * Math.Pow(a, 3) / 6
            + (5 - 18 * t + t * t + 72 * c
                - 58 * ePrima2) * Math.Pow(a, 5) / 120);

        // Coordenada Norte.
        double norte = k0 * (
            m + n * tanLat * (
                Math.Pow(a, 2) / 2
                + (5 - t + 9 * c + 4 * c * c)
                    * Math.Pow(a, 4) / 24
                + (61 - 58 * t + t * t + 600 * c
                    - 330 * ePrima2)
                    * Math.Pow(a, 6) / 720));

        string hemisferio = "N";

        if (latitud < 0)
        {
            norte += 10000000;
            hemisferio = "S";
        }

        return new CoordenadaUTM(
            este, norte, zona, hemisferio);
    }
}