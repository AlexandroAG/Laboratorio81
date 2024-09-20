using System;

namespace Laboratorio86
{
    class ClaseBase
    {
        public void test()
        {
            // Implementación del método test.
        }

    }

    class ClaseHijo : ClaseBase
    {
        // No se puede sobrescribir masTests() porque está marcado como sealed.
    }
}
