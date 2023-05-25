using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    public Text resultText;

    public void RollDie()
    {
        int result = Random.Range(1, 7); // Generate a random number between 1 and 6 (inclusive)

        // Update the result text
        resultText.text = "You got: \n" + result.ToString();
    }
}
