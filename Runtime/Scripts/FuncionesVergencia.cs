using UnityEngine;

namespace Alex.LibreriaVergencia
{
    public static class FuncionesVergencia
    {
        public static float CalculateVergenceAngle(float PD, float distanceToObject)
        {
            if (distanceToObject <= 0)
                return 0;

            float theta = 2 * Mathf.Atan((PD / 2) / distanceToObject);
            return theta * Mathf.Rad2Deg;
        }
    }
}