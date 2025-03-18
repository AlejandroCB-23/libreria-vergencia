using UnityEngine;

namespace TuNombre.LibreriaVergencia
{
    public static class FuncionesVergencia
    {
        /// <summary>
        /// Calcula el ángulo de vergencia en grados.
        /// </summary>
        /// <param name="PD">Distancia interpupilar (en medida de Unity).</param>
        /// <param name="distanceToObject">Distancia al objeto (en medida de Unity).</param>
        /// <returns>El ángulo de vergencia en grados.</returns>
        public static float CalculateVergenceAngle(float PD, float distanceToObject)
        {
            // Validar la distancia al objeto
            if (distanceToObject <= 0)
            {
                Debug.LogWarning("La distancia al objeto debe ser mayor que 0.");
                return 0;
            }

            // Calcular el ángulo de vergencia en radianes
            float theta = 2 * Mathf.Atan((PD / 2) / distanceToObject);

            // Convertir a grados y devolver el resultado
            return theta * Mathf.Rad2Deg;
        }
    }
}