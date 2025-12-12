using Bhaptics.SDK2;
using UnityEngine;

public static class TactSleeveHaptic
{
    
    
    public static void PlayTactSleevesTest()
    {
        // Motor-Intensitäten für die TactSleeves (Beispielwerte)
        int[] leftMotors = new int[] { 50, 50, 50 };  // Linker TactSleeve
        int[] rightMotors = new int[] { 50, 50, 50 }; // Rechter TactSleeve

        // Linker TactSleeve
        BhapticsLibrary.PlayMotors(
            1,              // Position: TactSleeve(Left)
            leftMotors,     // Motor-Intensitäten
            500             // Dauer in Millisekunden
        );

        // Rechter TactSleeve
        BhapticsLibrary.PlayMotors(
            2,              // Position: TactSleeve(Right)
            rightMotors,    // Motor-Intensitäten
            500             // Dauer in Millisekunden
        );
    }

    public static void StopTactSleevesTest()
    {
        BhapticsLibrary.StopAll(); // Stoppt alle laufenden Haptik-Effekte
    }
}